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
    public partial class Frm_MainWindow : Form
    {
        public Frm_MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void quảnLýLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyLoaiPhong frm = new frm_QuanLyLoaiPhong();
            frm.Show();
        }

        private void dataGridView_Phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ManHinhThongKe a = new ManHinhThongKe();
            a.Show();
        }
    }
}
