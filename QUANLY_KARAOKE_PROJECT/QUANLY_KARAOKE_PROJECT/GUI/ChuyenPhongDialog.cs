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
            cmb_phong.DisplayMember = "TenPhong";
            cmb_phong.ValueMember = "IDPhong";   
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

                int newRoomId = (int)cmb_phong.SelectedValue;

                using (KaraokeContextDB context = new KaraokeContextDB())
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            PHONG currentRoom = context.PHONGs.FirstOrDefault(p => p.IDPhong == currentRoomId);
                            if (currentRoom != null)
                            {
                                currentRoom.HienDung = 0; 
                            }
                            PHONG newRoom = context.PHONGs.FirstOrDefault(p => p.IDPhong == newRoomId);
                            if (newRoom != null)
                            {
                                newRoom.HienDung = 1; 
                            }
                            DAT_PHONG datPhong = context.DAT_PHONG
                                .FirstOrDefault(dp => dp.IDPhong == currentRoomId && dp.ThoiGianRa == null);
                            if (datPhong != null)
                            {
                                datPhong.IDPhong = newRoomId; 
                            }
                            var hoaDonSanPhams = context.HOA_DON_SAN_PHAM
                                .Where(hd => hd.IDPhong == currentRoomId)
                                .ToList();

                            foreach (var hd in hoaDonSanPhams)
                            {
                                hd.IDPhong = newRoomId;
                            }
                            context.SaveChanges();
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }

                MessageBox.Show("Chuyển phòng và các hóa đơn sản phẩm liên quan thành công!", "Thông báo");
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
