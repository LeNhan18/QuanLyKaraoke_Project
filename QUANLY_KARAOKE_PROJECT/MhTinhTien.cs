using QUANLY_KARAOKE_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class MhTinhTien : Form
    {
        private PrintDocument printDocument;  // Đối tượng PrintDocument để in hóa đơn
        private string invoiceContent;  // Nội dung hóa đơn
        private string _idPhong;
        public MhTinhTien(string idPhong)
        {
            InitializeComponent();
            _idPhong = idPhong;

            HienThiTenPhong();

            // Khởi tạo đối tượng PrintDocument và đăng ký sự kiện PrintPage
            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
            ResetHoaDon();
        }
        private void HienThiTenPhong()
        {
            using (var context = new KaraokeContextDB())
            {
                // Truy vấn thông tin phòng từ cơ sở dữ liệu
                var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong.ToString() == _idPhong);

                if (phong != null)
                {
                    // Hiển thị tên phòng trên Label
                    label1.Text = $"Phòng: {phong.TenPhong}";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin phòng!", "Lỗi");
                }
            }
        }

        private void MhTinhTien_Load(object sender, EventArgs e)
        {
            ResetHoaDon();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật nội dung hóa đơn từ RichTextBox
                invoiceContent = rtb_HoaDon.Text;

                // Hiển thị hộp thoại xem trước in
                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDocument,
                    Width = 800,
                    Height = 600
                };
                ResetHoaDon();
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xem trước in: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float x = 10; // Vị trí x bắt đầu
            float y = 10; // Vị trí y bắt đầu

            // Tách dòng hóa đơn để hiển thị từng dòng trên tài liệu in
            string[] lines = invoiceContent.Split('\n');
            foreach (string line in lines)
            {
                e.Graphics.DrawString(line, font, brush, x, y);
                y += font.GetHeight(); // Tăng vị trí y cho dòng tiếp theo
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapNhatHoaDon();
        }

        private void CapNhatHoaDon()
        {
            string maHoaDon = "11122024210133";
            DateTime thoiGianTao = DateTime.Now;
            TimeSpan thoiGianHat = TimeSpan.FromMinutes(24.97);

            decimal tienPhong = 0;
            decimal tienSanPham = 0;
            decimal phuThu = 0;
            decimal tongTam = tienPhong + tienSanPham + phuThu;
            decimal chietKhau = 0;
            decimal tongCong = tongTam - (tongTam * chietKhau / 100);

            // Tạo nội dung hóa đơn
            string hoaDon = "------------HOA DON KARAOKE------------\n";
            hoaDon += $"Ma Hoa Don: {maHoaDon}\n";
            hoaDon += $"Thoi Gian Tao: {thoiGianTao}\n";
            hoaDon += $"Thoi gian Hat: {thoiGianHat:hh\\:mm\\:ss}\n\n";
            hoaDon += $"Tien Gio: {tienPhong:N0}\n";
            hoaDon += $"Tien San Pham: {tienSanPham:N0}\n";
            hoaDon += $"Phu Thu: {phuThu:N0}\n";
            hoaDon += $"Tong Tam: {tongTam:N0}\n";
            hoaDon += $"Chiet Khau: {chietKhau}%\n\n";
            hoaDon += $"TONG CONG: {tongCong:N0}\n";
            hoaDon += "------------Cam on qui khach-------------";

            // Hiển thị hóa đơn trên RichTextBox
            rtb_HoaDon.Text = hoaDon;
        }
        private void ResetHoaDon()
        {
            rtb_HoaDon.Clear(); // Xóa toàn bộ nội dung
        
        }

        private void ResetGiaoDien()
        {
            rtb_TienPhong.Text = "0";  // Reset tiền phòng
            rtb_TienSanpham.Text = "0";  // Reset tiền sản phẩm
            rtb_PhuThu.Text = "0";  // Reset phụ thu
            rtb_KhuyenMai.Text = "0";  // Reset khuyến mãi
            rtb_Tong.Text = "0";  // Reset tổng tiền

            // Reset nội dung hóa đơn
            rtb_HoaDon.Clear(); // Xóa nội dung hóa đơn
            rtb_HoaDon.Text = "------------HOA DON KARAOKE------------\n";
            rtb_HoaDon.Text += "Nội dung hóa đơn sẽ hiển thị ở đây sau khi thanh toán.\n";
            rtb_HoaDon.Text += "---------------------------------------";
        }


        private void ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                int tienPhong = int.Parse(rtb_TienPhong.Text);
                int tienSanPham = int.Parse(rtb_TienSanpham.Text);
                int phuThu = int.Parse(rtb_PhuThu.Text);
                int giamGia = int.Parse(rtb_Tong.Text);

                // Tính tổng tiền
                int tongTam = tienPhong + tienSanPham + phuThu;
                int tongTien = tongTam - (tongTam * giamGia / 100);

                // Lưu hóa đơn vào cơ sở dữ liệu
                using (KaraokeContextDB db = new KaraokeContextDB())
                {
                    HOA_DON newInvoice = new HOA_DON
                    {
                        IDHoaDon = Guid.NewGuid().ToString(), // Mã hóa đơn duy nhất
                        IDKhachHang = 1, // ID khách hàng
                        IDDatPhong = 1, // ID đặt phòng (tùy chỉnh)
                        NgayGioTao = DateTime.Now, // Thời gian tạo
                        TongCong = tongTam,
                        GiamGia = giamGia,
                        Tong = tongTien,
                        TrangThai = 1, // Đã thanh toán
                        PhuThu = phuThu
                    };

                    db.HOA_DON.Add(newInvoice);
                    db.SaveChanges();
                }

                // Hiển thị hóa đơn trong RichTextBox
                CapNhatHoaDon();

                // Thông báo thành công
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // In hóa đơn nếu cần
                if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    invoiceContent = rtb_HoaDon.Text; // Lấy nội dung hóa đơn từ RichTextBox
                    printDocument.Print(); // Thực hiện in
                }

                // Reset giao diện (nếu cần)
                ResetGiaoDien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
