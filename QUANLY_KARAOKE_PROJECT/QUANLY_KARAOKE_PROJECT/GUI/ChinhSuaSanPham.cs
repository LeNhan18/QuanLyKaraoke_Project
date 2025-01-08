using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class ChinhSuaSanPham : Form
    {
        private DataGridView dataGridView_SanPham;
        public SAN_PHAM SelectedSanPham { get; set; }
        public ChinhSuaSanPham(DataGridView dtg)
        {
            InitializeComponent();
            this.dataGridView_SanPham = dtg;
        }

        public void BindGrid(List<SAN_PHAM> listSanPham)
        {
        }
        private void ChinhSuaSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                if (SelectedSanPham != null)
                {
                    txtTensanpham.Text = SelectedSanPham.TenSanPham;
                    txtDongia.Text = SelectedSanPham.DonGia.ToString();
                    txtMota.Text = SelectedSanPham.MoTa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB db = new KaraokeContextDB())
                {
                    // Lấy sản phẩm từ database để cập nhật
                    var sanPhamToUpdate = db.SAN_PHAM.FirstOrDefault(sp => sp.IDSanPham == SelectedSanPham.IDSanPham);
                    if (sanPhamToUpdate != null)
                    {
                        sanPhamToUpdate.TenSanPham = txtTensanpham.Text;
                        sanPhamToUpdate.DonGia = int.Parse(txtDongia.Text);
                        sanPhamToUpdate.MoTa = txtMota.Text;

                        db.SaveChanges();
                        // Cập nhật sản phẩm trong DataGridView (sử dụng SelectedSanPham)
                        SelectedSanPham.TenSanPham = sanPhamToUpdate.TenSanPham;
                        SelectedSanPham.DonGia = sanPhamToUpdate.DonGia;
                        SelectedSanPham.MoTa = sanPhamToUpdate.MoTa;
                        // Đặt kết quả trả về để form chính xử lý cập nhật DataGridView
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
