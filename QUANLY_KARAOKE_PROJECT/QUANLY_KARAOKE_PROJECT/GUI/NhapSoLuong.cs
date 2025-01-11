using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class NhapSoLuong : Form
    {
        public int SoLuong { get; private set; } 
        public string TenSanPham { get; set; }
        public NhapSoLuong(string tenSanPham)
        {
            InitializeComponent();
            TenSanPham = tenSanPham;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NhapSoLuong_Load(object sender, EventArgs e)
        {
            lb_TenSanPham.Text = $"Sản phẩm: {TenSanPham}";
            txt_soluongsp.Text = SoLuong.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_soluongsp.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.TryParse(txt_soluongsp.Text.Trim(), out int soLuong))
            {
                if (soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SoLuong = soLuong;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
