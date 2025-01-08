using BUS;
using DAL;
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
       
    }
}
