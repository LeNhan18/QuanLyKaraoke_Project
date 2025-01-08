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
    public partial class FormProgress : Form
    {
        private Timer progressTimer;
        private int progressValue;

        // Sự kiện báo hiệu khi hoàn tất
        public event Action ProgressCompleted;


        public FormProgress()
        {
            InitializeComponent();
            InitializeProgressEffect();
        }

        private void FormProgress_Load(object sender, EventArgs e)
        {

        }
     

        private void InitializeProgressEffect()
        {
            progressTimer = new Timer();
            progressTimer.Interval = 50; // Thời gian cập nhật mỗi bước (ms)
            progressTimer.Tick += ProgressTimer_Tick;

            progressValue = 0;
            progressBar.Value = 0;

            // Bắt đầu tiến trình
            progressTimer.Start();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            progressValue += 10; // Tăng phần trăm
            progressBar.Value = progressValue;
            lblStatus.Text = $"Đang tải... {progressValue}%";

            if (progressValue >= 100)
            {
                progressTimer.Stop();
                ProgressCompleted?.Invoke(); // Kích hoạt sự kiện khi hoàn tất
            }
        }
    
     }
}
