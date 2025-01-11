using BUS;
using DAL;
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
using QRCoder;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class MhTinhTien : Form
    {
        private PrintDocument printDocument;  // Đối tượng PrintDocument để in hóa đơn
        private string invoiceContent;  // Nội dung hóa đơn
        private int _idPhong;
        private int _idKhachHang;
        private readonly HoaDonService hoaDonService = new HoaDonService();
        public MhTinhTien(int idPhong, int idKhachHang)
        {
            InitializeComponent();
            _idPhong = idPhong;
            _idKhachHang = idKhachHang;

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
                var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == _idPhong);

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
            CapNhatThongTinPhong();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CapNhatThongTinPhong()
        {
            using (var context = new KaraokeContextDB())
            {
                // Lấy thông tin đặt phòng và hóa đơn
                var datPhong = context.DAT_PHONG.FirstOrDefault(dp => dp.IDPhong == _idPhong && dp.ThoiGianRa == null);

                if (datPhong != null)
                {
                    TimeSpan thoiGianSuDung = DateTime.Now - datPhong.ThoiGianVao;
                    int soPhut = (int)Math.Ceiling(thoiGianSuDung.TotalMinutes);

                    int giaPhongMoiPhut = datPhong.PHONG.LOAI_PHONG.Gia / 60; // Giá mỗi phút
                    int tienPhong = soPhut * giaPhongMoiPhut;
                    rtb_TienPhong.Text = tienPhong.ToString();

                    // Tính tổng tiền sản phẩm
                    int tienSanPham = context.HOA_DON_SAN_PHAM
                        .Where(hdsp => hdsp.IDPhong == datPhong.IDPhong)
                        .Sum(hdsp => (int?)hdsp.ThanhTien) ?? 0; // Xử lý null

                    rtb_TienSanpham.Text = tienSanPham.ToString();

                    rtb_PhuThu.Text = "0"; // Mặc định không có phụ thu
                    rtb_KhuyenMai.Text = "0"; // Mặc định không có khuyến mãi

                    // Tính tổng ban đầu
                    int tongTam = tienPhong + tienSanPham;
                    rtb_Tong.Text = tongTam.ToString();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin đặt phòng hoặc phòng chưa được sử dụng.", "Lỗi");
                }
            }
        }
        private string GetCustomerName()
        {
            using (var context = new KaraokeContextDB())
            {
                var customer = context.KHACH_HANG.FirstOrDefault(k => k.IDKhachHang == _idKhachHang);
                return customer != null ? customer.HoTen : "Không xác định";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                invoiceContent = rtb_HoaDon.Text;

                // Hiển thị hộp thoại xem trước in
                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDocument,
                    Width = 800,
                    Height = 600
                };
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xem trước in: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Định nghĩa font chữ
            Font titleFont = new Font("Arial", 24, FontStyle.Bold);
            Font headerFont = new Font("Arial", 20, FontStyle.Bold);
            Font regularFont = new Font("Arial", 20 , FontStyle.Regular);
            Brush brush = Brushes.Black;
            string customerName = GetCustomerName();
            // Vị trí bắt đầu
            float x = 10; // Tọa độ x
            float y = 10; // Tọa độ y
            float lineHeight = regularFont.GetHeight(e.Graphics);

            // Tiêu đề
            e.Graphics.DrawString("HÓA ĐƠN KARAOKE HIHI ", titleFont, brush, x + 150, y);
            y += lineHeight * 2;

            e.Graphics.DrawString($"Khách hàng: {customerName}", headerFont, brush, x, y);
            y += lineHeight;

            // Thông tin chung
            e.Graphics.DrawString($"{label1.Text}", headerFont, brush, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Thời gian tạo: {DateTime.Now}", regularFont, brush, x, y);
            y += lineHeight * 2;

            // Đường kẻ ngang
            e.Graphics.DrawLine(Pens.Black, x, y, e.PageBounds.Width - x, y);
            y += lineHeight;

            // Chi tiết hóa đơn
            e.Graphics.DrawString("Chi tiết hóa đơn:", headerFont, brush, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Tiền phòng: {rtb_TienPhong.Text} VND", regularFont, brush, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Tiền sản phẩm: {rtb_TienSanpham.Text} VND", regularFont, brush, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Phụ thu: {rtb_PhuThu.Text} %", regularFont, brush, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Giảm giá: {rtb_KhuyenMai.Text} %", regularFont, brush, x, y);
            y += lineHeight * 2;

            // Tổng cộng
            e.Graphics.DrawLine(Pens.Black, x, y, e.PageBounds.Width - x, y);
            y += lineHeight;

            e.Graphics.DrawString($"TỔNG CỘNG: {rtb_Tong.Text} VND", headerFont, brush, x, y);
            y += lineHeight * 2;

            // Đường kẻ ngang cuối
            e.Graphics.DrawLine(Pens.Black, x, y, e.PageBounds.Width - x, y);
            y += lineHeight;
           
            // Lời cảm ơn
            e.Graphics.DrawString("CẢM ƠN QUÝ KHÁCH, HẸN GẶP LẠI!", titleFont, brush, x + 100, y);
            Bitmap qrCodeImage = GenerateQRCode(rtb_HoaDon.Text); // Tạo mã QR từ nội dung hóa đơn
            int qrCodeSize = 200; // Kích thước mã QR
            float qrCodeX = e.PageBounds.Width / 2 - qrCodeSize / 2; // Căn giữa mã QR
            float qrCodeY = e.PageBounds.Height - qrCodeSize - 50; // Tọa độ Y của mã QR (phía dưới)

            e.Graphics.DrawImage(qrCodeImage, qrCodeX, qrCodeY, qrCodeSize, qrCodeSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapNhatHoaDon();
        }

        private void CapNhatHoaDon()
        {
            try
            {
                // Lấy dữ liệu từ các ô nhập liệu
                int tienPhong = int.Parse(rtb_TienPhong.Text);
                int tienSanPham = int.Parse(rtb_TienSanpham.Text);
                float phuThuPercent = float.Parse(rtb_PhuThu.Text);
                float giamGiaPercent = float.Parse(rtb_KhuyenMai.Text);

                // Tính phụ thu và giảm giá theo phần trăm
                float phuThu = (tienPhong + tienSanPham) * (phuThuPercent / 100);
                float giamGia = (tienPhong + tienSanPham + phuThu) * (giamGiaPercent / 100);

                float tongTam = tienPhong + tienSanPham + phuThu;
                float tongCong = tongTam - giamGia;

                // Cập nhật nội dung hóa đơn
                string hoaDon = "------------HOA DON KARAOKE------------\n";
                hoaDon += $"Phòng: {label1.Text}\n";
                hoaDon += $"Thời gian tạo: {DateTime.Now}\n";
                hoaDon += $"Tiền phòng: {tienPhong:N0} VND\n";
                hoaDon += $"Tiền sản phẩm: {tienSanPham:N0} VND\n";
                hoaDon += $"Phụ thu ({phuThuPercent}%): {phuThu:N0} VND\n";
                hoaDon += $"Giảm giá ({giamGiaPercent}%): {giamGia:N0} VND\n";
                hoaDon += "---------------------------------------\n";
                hoaDon += $"TỔNG CỘNG: {tongCong:N0} VND\n";
                hoaDon += "------------CẢM ƠN QUÝ KHÁCH-----------";

                rtb_HoaDon.Text = hoaDon;
                ShowQRCode(hoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật hóa đơn: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetHoaDon()
        {
            rtb_HoaDon.Clear();
        }

        private void ResetGiaoDien()
        {
            rtb_TienPhong.Text = "0";
            rtb_TienSanpham.Text = "0";
            rtb_PhuThu.Text = "0";
            rtb_KhuyenMai.Text = "0";
            rtb_Tong.Text = "0";
            ResetHoaDon();
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                int tienPhong = int.Parse(rtb_TienPhong.Text);
                int tienSanPham = int.Parse(rtb_TienSanpham.Text);
                float phuThuPercent = float.Parse(rtb_PhuThu.Text);
                float giamGiaPercent = float.Parse(rtb_KhuyenMai.Text);

                // Tính phụ thu và giảm giá theo phần trăm
                float phuThu = (tienPhong + tienSanPham) * (phuThuPercent / 100);
                float giamGia = (tienPhong + tienSanPham + phuThu) * (giamGiaPercent / 100);

                float tongTam = tienPhong + tienSanPham + phuThu;
                float tongTien = tongTam - giamGia;

                // Lưu hóa đơn vào cơ sở dữ liệu
                using (var db = new KaraokeContextDB())
                {
                    // Tìm thông tin đặt phòng
                    var datPhong = db.DAT_PHONG.FirstOrDefault(dp => dp.IDPhong == _idPhong && dp.ThoiGianRa == null);
                    if (datPhong == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin đặt phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
          
                    HOA_DON newInvoice = new HOA_DON
                    {
                        IDHoaDon = hoaDonService.TAOMAHOADON(),
                        IDKhachHang = _idKhachHang,
                        IDDatPhong = datPhong.IDDatPhong,
                        NgayGioTao = DateTime.Now,
                        TongCong = (int)tongTam,
                        GiamGia = (int)giamGia,
                        Tong = (int)tongTien,
                        TrangThai = 1,
                        PhuThu = (int)phuThu
                    };

                    db.HOA_DON.Add(newInvoice);

                    // 2. Cập nhật trạng thái phòng
                    var phong = db.PHONGs.FirstOrDefault(p => p.IDPhong == _idPhong);
                    if (phong != null)
                    {
                        // Đặt trạng thái phòng về trống
                        phong.HienDung = 0;

                        // 3. Xóa tất cả sản phẩm đã thêm vào phòng
                        var hoaDonSanPhamCuaPhong = db.HOA_DON_SAN_PHAM
                            .Where(hdsp => hdsp.IDPhong == phong.IDPhong)
                            .ToList();

                        foreach (var item in hoaDonSanPhamCuaPhong)
                        {
                            db.HOA_DON_SAN_PHAM.Remove(item);
                        }
                    }

                    // 4. Cập nhật thời gian trả phòng
                    datPhong.ThoiGianRa = DateTime.Now;

                    // 5. Lưu tất cả thay đổi
                    db.SaveChanges();

                    MessageBox.Show("Thanh toán thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xử lý in hóa đơn nếu cần
                    if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        invoiceContent = rtb_HoaDon.Text;
                        printDocument.Print();
                    }

                    // Reset form
                    ResetGiaoDien();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Bitmap GenerateQRCode(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }

        private void ShowQRCode(string content)
        {
            Bitmap qrCodeImage = GenerateQRCode(content);
            pictureBox1.SizeMode =PictureBoxSizeMode.Zoom;
            pictureBox1.Image = qrCodeImage;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
