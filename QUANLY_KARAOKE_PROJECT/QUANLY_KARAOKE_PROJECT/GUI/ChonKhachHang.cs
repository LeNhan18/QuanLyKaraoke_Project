using BUS;
using QuanLyKaraoke_New_Project;
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
    public partial class ChonKhachHang : Form
    {
        private readonly KhachHangService khachHangService = new KhachHangService();
        public int SelectedKhachHangID { get; set; } = 0;
        public ChonKhachHang()
        {
            InitializeComponent();
        }

        private void ChonKhachHang_Load(object sender, EventArgs e)
        {
            var dsKhachHang = khachHangService.LayDanhSachKhachHang();
            cmbKH.DataSource = dsKhachHang;
            cmbKH.DisplayMember = "HoTen";
            cmbKH.ValueMember = "IDKhachHang";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbKH.SelectedValue != null)
            {
                SelectedKhachHangID = (int)cmbKH.SelectedValue;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Manhinhthemkhachhangdatphong frm = new Manhinhthemkhachhangdatphong();
            if (frm.ShowDialog() == DialogResult.OK)
            {
          
                var dsKhachHang = khachHangService.LayDanhSachKhachHang();
                cmbKH.DataSource = dsKhachHang;
                cmbKH.DisplayMember = "TenKhachHang";
                cmbKH.ValueMember = "IDKhachHang";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
