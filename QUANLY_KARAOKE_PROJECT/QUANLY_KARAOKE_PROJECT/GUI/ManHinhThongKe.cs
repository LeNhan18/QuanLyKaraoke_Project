using BUS;
using DAL;
using QUANLY_KARAOKE_PROJECT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKaraoke_New_Project
{
    public partial class ManHinhThongKe : Form
    {
        public readonly PhongService phongService = new PhongService();
        public readonly HoaDonService hoaDonService = new HoaDonService();
        public ManHinhThongKe()
        {
            InitializeComponent();
            this.hoaDonService = hoaDonService;
            this.phongService = phongService;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Get the selected start and end dates
            DateTime ngayBatDau = dtp_start.Value.Date;
            DateTime ngayKetThuc = dtp_end.Value.Date;

            using (var context = new KaraokeContextDB())
            {
                // Query the invoices for the selected date range
                var danhSachThongKe = context.HOA_DON
                    .Where(hd => hd.NgayGioTao >= ngayBatDau && hd.NgayGioTao <= ngayKetThuc)
                    .Select(hd => new
                    {
                        MaHoaDon = hd.IDHoaDon,
                        NgayTao = hd.NgayGioTao,
                        TongTien = hd.TongCong,
                        KhachHang = hd.KHACH_HANG.HoTen
                    })
                    .ToList();

                dgv_DSThongKe.DataSource = danhSachThongKe;
                dgvBanHang.DataSource = danhSachThongKe;

                // Set column headers for better display
                dgv_DSThongKe.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
                dgv_DSThongKe.Columns["NgayTao"].HeaderText = "Ngày Tạo";
                dgv_DSThongKe.Columns["TongTien"].HeaderText = "Tổng Tiền (VND)";
                dgv_DSThongKe.Columns["KhachHang"].HeaderText = "Khách Hàng";

          
                dgv_DSThongKe.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgv_DSThongKe.Columns["TongTien"].DefaultCellStyle.Format = "N0";


                dgvBanHang.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
                dgvBanHang.Columns["NgayTao"].HeaderText = "Ngày Tạo";
                dgvBanHang.Columns["TongTien"].HeaderText = "Tổng Tiền (VND)";
                dgv_DSThongKe.Columns["KhachHang"].HeaderText = "Khách Hàng";


                dgvBanHang.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvBanHang.Columns["TongTien"].DefaultCellStyle.Format = "N0";

                txt_TongHoaDon.Text = $"Số lượng hóa đơn: {danhSachThongKe.Count}";
                txt_TongTien.Text = $"Tổng tiền: {danhSachThongKe.Sum(hd => hd.TongTien):N0} VND";
                dgv_DSThongKe.Refresh();
            }
        }


        private void dgv_DSThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void ManHinhThongKe_Load(object sender, EventArgs e)
        {
            try
            {

                var pHONGs = phongService.get3Row();
                dataGridView1.DataSource = pHONGs;
                dataGridView1.Columns["IDPhong"].HeaderText = "Mã phòng";
                dataGridView1.Columns["TenPhong"].HeaderText = "Tên phòng";
                dataGridView1.Columns["HienDung"].HeaderText = "Hiện dùng";

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.Name != "IDPhong" && col.Name != "TenPhong" && col.Name != "HienDung")
                    {
                        col.Visible = false; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
      
        }

        private void btn_TimkiemTheoMaHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã hóa đơn từ TextBox
                string maHoaDon = txt_TimKiem.Text.Trim();

                if (string.IsNullOrEmpty(maHoaDon))
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var context = new KaraokeContextDB())
                {
                    // Tìm kiếm hóa đơn theo mã
                    var danhSachThongKe = context.HOA_DON
                        .Where(hd => hd.IDHoaDon.ToString() == maHoaDon)
                        .Select(hd => new
                        {
                            MaHoaDon = hd.IDHoaDon,
                            NgayTao = hd.NgayGioTao,
                            TongTien = hd.TongCong,
                            KhachHang = hd.KHACH_HANG.HoTen
                        })
                        .ToList();

                    // Hiển thị kết quả lên DataGridView
                    dgv_DSThongKe.DataSource = danhSachThongKe;
                    dgvBanHang.DataSource = danhSachThongKe;

                    if (danhSachThongKe.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn nào với mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txt_TongHoaDon.Text = $"Số lượng hóa đơn: {danhSachThongKe.Count}";
                        txt_TongTien.Text = $"Tổng tiền: {danhSachThongKe.Sum(hd => hd.TongTien):N0} VND";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_TimkiemtheoTenkh_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên khách hàng từ TextBox
                string tenKhachHang = txt_TimKiem.Text.Trim();

                if (string.IsNullOrEmpty(tenKhachHang))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var context = new KaraokeContextDB())
                {
                    // Tìm kiếm hóa đơn theo tên khách hàng
                    var danhSachThongKe = context.HOA_DON
                        .Where(hd => hd.KHACH_HANG.HoTen.Contains(tenKhachHang))
                        .Select(hd => new
                        {
                            MaHoaDon = hd.IDHoaDon,
                            NgayTao = hd.NgayGioTao,
                            TongTien = hd.TongCong,
                            KhachHang = hd.KHACH_HANG.HoTen
                        })
                        .ToList();

                    // Hiển thị kết quả lên DataGridView
                    dgv_DSThongKe.DataSource = danhSachThongKe;
                    dgvBanHang.DataSource = danhSachThongKe;

                    if (danhSachThongKe.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn nào với tên khách hàng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txt_TongHoaDon.Text = $"Số lượng hóa đơn: {danhSachThongKe.Count}";
                        txt_TongTien.Text = $"Tổng tiền: {danhSachThongKe.Sum(hd => hd.TongTien):N0} VND";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
