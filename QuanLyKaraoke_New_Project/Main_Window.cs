using QuanLyKaraoke_New_Project.Model;
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
        private void BindGrid(List<PHONG> listPhong, List<SAN_PHAM> listSanPham)
        {
            dataGridView_Phong.Rows.Clear();
            foreach (var item in listPhong)
            {
                int index = dataGridView_Phong.Rows.Add();
                dataGridView_Phong.Rows[index].Cells[0].Value = item.TenPhong;
            }
            dataGridView_SanPham.Rows.Clear();
            foreach (var item in listSanPham)
            {
                int index = dataGridView_SanPham.Rows.Add();
                dataGridView_SanPham.Rows[index].Cells[0].Value = item.IDSanPham;
                dataGridView_SanPham.Rows[index].Cells[1].Value = item.TenSanPham;
                dataGridView_SanPham.Rows[index].Cells[2].Value = item.DonGia;
            }
        }
        private void Frm_MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                QuanLyKaraokeModel context = new QuanLyKaraokeModel();
                List<PHONG> listPhong = context.PHONGs.ToList(); //lấy các lớp
                List<SAN_PHAM> listSanPham = context.SAN_PHAM.ToList();
                BindGrid(listPhong, listSanPham);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
