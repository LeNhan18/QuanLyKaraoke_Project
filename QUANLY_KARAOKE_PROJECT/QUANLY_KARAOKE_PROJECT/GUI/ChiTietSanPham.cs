using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class ChiTietSanPham : Form
    {
        private DataGridView dataGridView_SanPham;
        public SAN_PHAM SelectedSanPham { get; set; }
        public ChiTietSanPham(DataGridView dtg)
        {
            InitializeComponent();
            this.dataGridView_SanPham = dtg;

        }

        public void BindGrid(List<SAN_PHAM> listSanPham)
        {
        }
        private void ChiTietSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                if (SelectedSanPham != null)
                {
                    lblTensanpham.Text = SelectedSanPham.TenSanPham;
                    label2.Text = SelectedSanPham.DonGia.ToString();
                    lblMota.Text = SelectedSanPham.MoTa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
