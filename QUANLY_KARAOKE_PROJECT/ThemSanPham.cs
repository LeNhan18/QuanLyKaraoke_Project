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
using QUANLY_KARAOKE_PROJECT.Model;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class ThemSanPham : Form
    {
        public ThemSanPham()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                KaraokeContextDB db = new KaraokeContextDB();
                List<SAN_PHAM> sanphamlist = db.SAN_PHAM.ToList();
                if (sanphamlist.All(s => s.TenSanPham == txtTensanpham.Text))
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại. Vui lòng thêm một sản phẩm khác. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                var newSanPham = new SAN_PHAM
                {
                    TenSanPham = txtTensanpham.Text,
                    DonGia = int.Parse(txtDongia.Text.ToString()),
                    MoTa = txtMota.Text,
                };
                db.SAN_PHAM.Add(newSanPham);
                db.SaveChanges();
                MessageBox.Show("Them sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
