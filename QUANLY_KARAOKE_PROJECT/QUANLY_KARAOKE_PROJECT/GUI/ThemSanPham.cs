using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class ThemSanPham : Form
    {
        private DataGridView dataGridView_SanPham;
        public ThemSanPham(DataGridView dtg)
        {
            InitializeComponent();
            this.dataGridView_SanPham = dtg;
        }

        public void BindGrid(List<SAN_PHAM> listSanPham)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB db = new KaraokeContextDB())
                {
                    // Kiểm tra trùng lặp tên sản phẩm
                    if (db.SAN_PHAM.Any(s => s.TenSanPham == txtTensanpham.Text))
                    {
                        MessageBox.Show("Tên sản phẩm đã tồn tại. Vui lòng thêm một sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo sản phẩm mới
                    var newSanPham = new SAN_PHAM
                    {
                        TenSanPham = txtTensanpham.Text,
                        DonGia = int.Parse(txtDongia.Text),
                        MoTa = txtMota.Text,
                    };

                    // Thêm vào database
                    db.SAN_PHAM.Add(newSanPham);
                    db.SaveChanges();

                    // Thêm sản phẩm vào DataGridView
                    dataGridView_SanPham.Rows.Add(newSanPham.IDSanPham, newSanPham.TenSanPham, newSanPham.DonGia, newSanPham.MoTa);

                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThemSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
