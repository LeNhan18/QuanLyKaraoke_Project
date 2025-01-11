using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;

namespace QuanLyKaraoke_New_Project
{
    public partial class Manhinhthemkhachhangdatphong : Form
    {
        public readonly KhachHangService khachHangService = new KhachHangService() ;
        public KaraokeContextDB karaokeContextDB = new KaraokeContextDB() ;
        public KHACH_HANG newKhachHang { get; private set; }
        public Manhinhthemkhachhangdatphong()

        {
            InitializeComponent();
           
        }

        private void Manhinhthemkhachhangdatphong_Load(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB context = new KaraokeContextDB())
                {
                    List<KHACH_HANG> listKhachHang = context.KHACH_HANG.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_chapnhan_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txt_hoten.Text.Trim();
                string sdt = txt_sdt.Text.Trim();
                string diaChi = txt_diachi.Text.Trim();

                // Kiểm tra nhập liệu
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra khách hàng đã tồn tại
                KHACH_HANG existingKhachHang = khachHangService.ktraSDT_HoTen(hoTen, sdt);
                if (existingKhachHang != null)
                {
                    MessageBox.Show("Khách hàng đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Tạo mới khách hàng
                newKhachHang = khachHangService.CreateKH(hoTen, sdt, diaChi);
                khachHangService.CreateKhachHang(newKhachHang); // Lưu khách hàng mới vào database

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

                ClearInputFields();
                this.Close();
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show($"Lỗi tham chiếu null: {nre.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ClearInputFields()
        {
            txt_hoten.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
