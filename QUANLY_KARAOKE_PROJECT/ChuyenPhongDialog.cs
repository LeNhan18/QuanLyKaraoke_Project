using QUANLY_KARAOKE_PROJECT.Model;
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
    public partial class ChuyenPhongDialog : Form
    {
        KaraokeContextDB context = new KaraokeContextDB();
        private int currentRoomId;
        public ChuyenPhongDialog(int currentRoomId)
        {
            InitializeComponent();
            this.currentRoomId = currentRoomId;
        }

        private void ChuyenPhongDialog_Load(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách phòng từ cơ sở dữ liệu
                List<PHONG> a = context.PHONGs
                        .Where(p => p.HienDung == 0).ToList(); // Chỉ lấy phòng chưa sử dụng

                Fill(a);
                // Hiển thị danh sách phòng trong ComboBox
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phòng: {ex.Message}", "Lỗi");
            }
        }
        private void Fill(List<PHONG> a)
        {
            cmb_phong.DataSource = a;
            cmb_phong.DisplayMember = "TenPhong"; // Hiển thị tên phòng
            cmb_phong.ValueMember = "IDPhong";   // Gắn giá trị là ID phòng
        }

        private void btn_chapnhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_phong.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn phòng để chuyển!", "Thông báo");
                    return;
                }

                int newRoomId = (int)cmb_phong.SelectedValue; // ID của phòng được chọn

                using (KaraokeContextDB context = new KaraokeContextDB())
                {
                    // Cập nhật trạng thái phòng hiện tại (trả phòng)
                    PHONG currentRoom = context.PHONGs.FirstOrDefault(p => p.IDPhong == currentRoomId);
                    if (currentRoom != null)
                    {
                        currentRoom.HienDung = 0; // Đánh dấu phòng hiện tại là chưa sử dụng
                    }

                    // Cập nhật trạng thái phòng mới (sử dụng)
                    PHONG newRoom = context.PHONGs.FirstOrDefault(p => p.IDPhong == newRoomId);
                    if (newRoom != null)
                    {
                        newRoom.HienDung = 1; // Đánh dấu phòng mới là đang sử dụng
                    }

                    // Cập nhật thông tin đặt phòng (chuyển sang phòng mới)
                    DAT_PHONG datPhong = context.DAT_PHONG
                        .FirstOrDefault(dp => dp.IDPhong == currentRoomId && dp.ThoiGianRa == null);
                    if (datPhong != null)
                    {
                        datPhong.IDPhong = newRoomId; // Chuyển sang phòng mới
                    }

                    context.SaveChanges();
                }

                MessageBox.Show("Chuyển phòng thành công!", "Thông báo");
                this.DialogResult = DialogResult.OK; // Đóng dialog và báo thành công
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi chuyển phòng: {ex.Message}", "Lỗi");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Đóng dialog mà không thực hiện thay đổi
            this.Close();
        }
    }
}
