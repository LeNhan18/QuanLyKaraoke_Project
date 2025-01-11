using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_KARAOKE_PROJECT.GUI
{
    public partial class ThongTinQuan : Form
    {
         private Timer progressTimer;
        private int progressValue;


        public ThongTinQuan()
        {
            InitializeComponent();
            
        }
     
        private void ThongTinQuan_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenQuanNhap = txtTenQuan.Text.Trim();
          

            if (string.IsNullOrEmpty(tenQuanNhap))
            {
                MessageBox.Show("Vui lòng nhập tên quán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new KaraokeContextDB())
            {
                var quan = context.THONG_TIN_QUAN.FirstOrDefault(q => q.TenQuan == tenQuanNhap);

                if (quan != null)
                {
                    
                    MessageBox.Show($"Chào mừng đến {quan.TenQuan}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLogin.Enabled = false;
                    lblStatus.Text = "Đang kiểm tra thông tin...";
                    FormProgress formProgress = new FormProgress();
                    formProgress.Show();
                    formProgress.ProgressCompleted += () =>
                    {
                        Form1 formMain = new Form1();
                        formMain.Show();
                        formProgress.Close();
                    };

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên quán không hợp lệ. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
          
             
        }

   

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTenQuan_Click(object sender, EventArgs e)
        {

        }
    }
}

