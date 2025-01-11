using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using QUANLY_KARAOKE_PROJECT;
using DAL;

namespace QuanLyKaraoke_New_Project
{
    public partial class Manhinhdatphong : Form
    {
        public readonly PhongService phongService = new PhongService();
        public readonly KhachHangService khachHangService = new KhachHangService();  
        public string TenPhong { get; set; }
        public Manhinhdatphong(string tenPhong)
        {
            InitializeComponent();
            TenPhong = tenPhong;
        }

        private void Manhinhdatphong_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new KaraokeContextDB())
                {
                    txt_tenphong.Text = TenPhong;

                    List<PHONG> listPhong = context.PHONGs.ToList();
                    PHONG phong = phongService.FindByTenPhong(TenPhong); // Tìm phòng theo tên

                    if (phong != null)
                    {
                        var idLoaiPhong = phong.IDLoaiPhong;
                        LOAI_PHONG loaiPhong = context.LOAI_PHONG.FirstOrDefault(lp => lp.IDLoaiPhong == idLoaiPhong);

                        if (loaiPhong != null)
                        {
                            // Gán giá trị cho lb_loaiphong và lb_gia
                            if (loaiPhong.IDLoaiPhong == 1)
                            {
                                lb_loaiphong.Text = "Thường";
                                lb_gia.Text = "60000";
                            }
                            else if (loaiPhong.IDLoaiPhong == 2)
                            {
                                lb_loaiphong.Text = "VIP";
                                lb_gia.Text = "80000";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB context = new KaraokeContextDB())
                {
                    string hotenKhachHang = txt_hotenkhachhang.Text.Trim();
                    string sdtText = txt_sodienthoai.Text.Trim();

                    if (!string.IsNullOrEmpty(hotenKhachHang) && !string.IsNullOrEmpty(sdtText))
                    {

                        if (int.TryParse(sdtText, out int sdt))
                        {
                            var khachHang = context.KHACH_HANG
                                .Where(kh => kh.HoTen.Contains(hotenKhachHang) && kh.SDT == sdt.ToString())
                                .Select(kh => new
                                {
                                    kh.IDKhachHang,
                                    kh.HoTen,
                                    kh.SDT,
                                    kh.DiaChi
                                })
                                .ToList();

                            if (khachHang.Any())
                            {
                              
                                dtg_danhsachkhachhang.DataSource = khachHang;

                                dtg_danhsachkhachhang.Columns["IDKhachHang"].HeaderText = "Mã Khách Hàng";
                                dtg_danhsachkhachhang.Columns["HoTen"].HeaderText = "Họ Tên";
                                dtg_danhsachkhachhang.Columns["SDT"].HeaderText = "Số Điện Thoại";
                                dtg_danhsachkhachhang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                            }
                            else
                            {
                                // Nếu không tìm thấy khách hàng, thông báo rằng khách hàng là mới
                                MessageBox.Show("Đây là khách hàng mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dtg_danhsachkhachhang.DataSource = null; // Xóa dữ liệu cũ trong DataGridView
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    { 
                        var listKhachHang = context.KHACH_HANG
                            .Select(kh => new
                            {
                                kh.IDKhachHang,
                                kh.HoTen,
                                kh.SDT,
                                kh.DiaChi
                            })
                            .ToList();

                        dtg_danhsachkhachhang.DataSource = listKhachHang;

                        // Tùy chỉnh hiển thị cho DataGridView (nếu cần)
                        dtg_danhsachkhachhang.Columns["IDKhachHang"].HeaderText = "Mã Khách Hàng";
                        dtg_danhsachkhachhang.Columns["HoTen"].HeaderText = "Họ Tên";
                        dtg_danhsachkhachhang.Columns["SDT"].HeaderText = "Số Điện Thoại";
                        dtg_danhsachkhachhang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            Manhinhthemkhachhangdatphong manhinhthemkhachhangdatphong = new Manhinhthemkhachhangdatphong();
            manhinhthemkhachhangdatphong.ShowDialog();
        }

        private void dtg_danhsachkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btn_datphong_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new KaraokeContextDB())
                {
                    string hotenKhachHang = txt_hotenkhachhang.Text.Trim();
                    string sdt = txt_sodienthoai.Text.Trim();
                    string tenPhong = txt_tenphong.Text.Trim();
                    DateTime thoigiandat = DateTime.Now;

                    if (string.IsNullOrEmpty(hotenKhachHang) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(tenPhong))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var khachHang = khachHangService.ktraSDT_HoTen(hotenKhachHang, sdt);
                    if (khachHang == null)
                    {
                        MessageBox.Show("Khách hàng không tồn tại!");
                        return;
                    }

                    var phong = phongService.FindByTenPhong(tenPhong);
                    if (phong == null)
                    {
                        MessageBox.Show("Phòng không hợp lệ!");
                        return;
                    }

                    // Kiểm tra trạng thái phòng
                    if (phong.HienDung == 1)
                    {
                        MessageBox.Show("Phòng hiện đang được sử dụng!");
                        return;
                    }
                

                    // Thêm thông tin đặt phòng
                    var datPhong = new DAT_PHONG
                    {
                        IDPhong = phong.IDPhong,
                        IDKhachHang = khachHang.IDKhachHang,
                        ThoiGianVao = thoigiandat,
                        TienPhong = 0
                    };
                    phong.HienDung = 1;
                    context.DAT_PHONG.Add(datPhong);
                    context.SaveChanges();

                    MessageBox.Show("Đặt phòng thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
