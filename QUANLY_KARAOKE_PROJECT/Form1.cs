using QUANLY_KARAOKE_PROJECT.Model;
using QuanLyKaraoke_New_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class Form1 : Form
    {
        private List<PHONG> listPhong;
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLoaiPhong frm = new FormQuanLyLoaiPhong();
            frm.Show();
        }
        private void BindGrid(List<PHONG> listPhong, List<SAN_PHAM> listSanPham)
        {
            dataGridView_Phong.Rows.Clear();
            foreach (var item in listPhong)
            {
                int index = dataGridView_Phong.Rows.Add();
                dataGridView_Phong.Rows[index].Cells[0].Value = item.IDPhong;
                dataGridView_Phong.Rows[index].Cells[1].Value = item.TenPhong;
                dataGridView_Phong.Rows[index].Cells[2].Value = item.HienDung;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                KaraokeContextDB context = new KaraokeContextDB();
                List<PHONG> listPhong = context.PHONGs.ToList(); //lấy các lớp
                List<SAN_PHAM> listSanPham = context.SAN_PHAM.ToList();
                DisplayRooms(listPhong);
                BindGrid(listPhong, listSanPham);
                ReloadRoomData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang frm = new QuanLyKhachHang();
            frm.ShowDialog();
        }


        private int rowIndex = 0;
        private void dataGridView_SanPham_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Chọn chuột phải cho từng hàng trong data grid view sản phảm
            if (e.Button == MouseButtons.Right)
            {
                dataGridView_SanPham.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                dataGridView_SanPham.CurrentCell = dataGridView_SanPham.Rows[rowIndex].Cells[0];
                this.menuStripSanPham.Show(dataGridView_SanPham, e.Location);
                menuStripSanPham.Show(Cursor.Position);
            }
        }

        private void thêmVàoPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapSoLuong nhapSoLuong = new NhapSoLuong();
            nhapSoLuong.ShowDialog();
            ReloadRoomData();

        }

        private void dataGridView_Phong_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Chọn chuột phải cho từng hàng trong data grid view phòng
            if (e.Button == MouseButtons.Right)
            {
                dataGridView_Phong.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                dataGridView_Phong.CurrentCell = dataGridView_Phong.Rows[e.RowIndex].Cells[0];

                // Lấy giá trị hiện dùng từ DataGridView
                var hienDungValue = dataGridView_Phong.Rows[e.RowIndex].Cells[2].Value;

                if (hienDungValue != null && int.TryParse(hienDungValue.ToString(), out int hienDung))
                {
                    if (hienDung == 0)
                    {
                        menuStripPhongChuaSuDung.Show(dataGridView_Phong, e.Location);
                        menuStripPhongChuaSuDung.Show(Cursor.Position);
                    }
                    else if (hienDung == 1)
                    {
                        menuStripPhongDaSuDung.Show(dataGridView_Phong, e.Location);
                        menuStripPhongDaSuDung.Show(Cursor.Position);
                    }
                }
            }
        }

        private void dataGridView_Phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView_Phong.Rows.Count)
                {
                    DataGridViewRow selectedRow = dataGridView_Phong.Rows[e.RowIndex];
                    string tenPhong = selectedRow.Cells[1].Value?.ToString() ?? "N/A";

                    if (string.IsNullOrEmpty(tenPhong) || tenPhong == "N/A")
                    {
                        MessageBox.Show("Không thể lấy thông tin tên phòng.", "Lỗi");
                        return;
                    }
                    label_TenPhong.Text = $"{tenPhong}";

                    KaraokeContextDB context = new KaraokeContextDB();
                    PHONG phong = context.PHONGs.FirstOrDefault(p => p.TenPhong == tenPhong);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void label_TenPhong_Click(object sender, EventArgs e)
        {

        }

        private void menuStripSanPham_Opening(object sender, CancelEventArgs e)
        {

        }


        private void sửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                // Lấy nút phòng được chọn từ menu context
                System.Windows.Forms.Button selectedButton = (System.Windows.Forms.Button)menuStripPhongChuaSuDung.SourceControl;
                int idPhong = (int)selectedButton.Tag; // Lấy ID phòng từ Tag của nút

                using (var context = new KaraokeContextDB())
                {
                    // Lấy thông tin phòng từ cơ sở dữ liệu
                    var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
                    if (phong != null && phong.HienDung == 0) // Phòng chưa được sử dụng
                    {
                        // Cập nhật trạng thái phòng
                        phong.HienDung = 1;

                        // Tạo một bản ghi mới trong bảng DAT_PHONG
                        DAT_PHONG datPhong = new DAT_PHONG
                        {
                            IDPhong = idPhong,
                            IDKhachHang = 1, // Giả sử ID khách hàng là 1 (cần thay thế bằng dữ liệu thực tế)
                            ThoiGianVao = DateTime.Now, // Lưu thời gian hiện tại
                            TienPhong = 0 // Ban đầu tiền phòng có thể để 0
                        };

                        // Thêm bản ghi vào cơ sở dữ liệu
                        context.DAT_PHONG.Add(datPhong);
                        context.SaveChanges();

                        // Hiển thị thông báo
                        MessageBox.Show($"Phòng {phong.TenPhong} đã được sử dụng lúc {DateTime.Now.ToString("HH:mm:ss")}");
                        ReloadRoomData(); // Cập nhật lại danh sách phòng trên giao diện
                    }
                    else
                    {
                        MessageBox.Show("Phòng đang được sử dụng!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sử dụng phòng: {ex.Message}");
            }
        }


        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Button selectedButton = (System.Windows.Forms.Button)menuStripPhongChuaSuDung.SourceControl;
            //int idPhong = (int)selectedButton.Tag;

            Manhinhdatphong datPhongForm = new Manhinhdatphong();
            datPhongForm.ShowDialog();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (menuStripPhongDaSuDung.SourceControl is System.Windows.Forms.Button selectedButton)
            {
                int idPhong = (int)selectedButton.Tag;

                using (var context = new KaraokeContextDB())
                {
                    var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
                    if (phong != null && phong.HienDung == 1)
                    {
                        phong.HienDung = 0;
                        context.SaveChanges();
                        MessageBox.Show($"Phòng {phong.TenPhong} đã được trả phòng.");
                        ReloadRoomData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể trả phòng. Phòng không được sử dụng.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể xác định phòng được chọn.");
            }
        }
       
        private void tínhTiềnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy nút phòng được chọn từ menu context
                if (menuStripPhongDaSuDung.SourceControl is System.Windows.Forms.Button selectedButton)
                {
                    // Lấy ID phòng từ thuộc tính Tag của nút và chuyển sang string
                    string idPhong = selectedButton.Tag.ToString();

                    // Mở form MhTinhTien và truyền ID phòng
                    MhTinhTien a = new MhTinhTien(idPhong);
                    a.ShowDialog(); // Hiển thị form
                }
                else
                {
                    MessageBox.Show("Không thể xác định phòng được chọn!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }

        }
        private void DisplayRooms(List<PHONG> listPhong)
        {
            flowLayoutPanel1.Controls.Clear(); // Xóa các nút cũ

            foreach (var item in listPhong)
            {
                // Tạo nút đại diện cho phòng
                System.Windows.Forms.Button btnRoom = new System.Windows.Forms.Button
                {
                    Text = item.TenPhong,
                    Tag = item.IDPhong, // Lưu ID phòng vào thuộc tính Tag
                    Width = 150,
                    Height = 80,
                    BackColor = item.HienDung == 0 ? Color.LightSkyBlue : Color.LightSlateGray // Màu sắc theo trạng thái
                };

                // Sự kiện chuột phải để hiển thị menu ngữ cảnh
                btnRoom.MouseUp += (sender, e) =>
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
                        int idPhong = (int)clickedButton.Tag;

                        // Lấy trạng thái phòng và hiển thị menu ngữ cảnh
                        var phong = listPhong.FirstOrDefault(p => p.IDPhong == idPhong);
                        if (phong != null)
                        {
                            if (phong.HienDung == 0)
                                menuStripPhongChuaSuDung.Show(clickedButton, e.Location);
                            else if (phong.HienDung == 1)
                                menuStripPhongDaSuDung.Show(clickedButton, e.Location);
                        }
                    }
                };

                // Sự kiện nhấn chuột để hiển thị thông tin phòng
                btnRoom.Click += (sender, e) =>
{
    System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
    int idPhong = (int)clickedButton.Tag;

    using (var context = new KaraokeContextDB())
    {
        // Lấy thông tin phòng từ cơ sở dữ liệu
        var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
        if (phong != null)
        {
            label_TenPhong.Text = $"{phong.TenPhong}";

            if (phong.HienDung == 1) // Phòng đang được sử dụng
            {
                // Truy vấn bản ghi đặt phòng mới nhất của phòng này
                var datPhong = context.DAT_PHONG
                    .Where(dp => dp.IDPhong == phong.IDPhong)
                    .OrderByDescending(dp => dp.ThoiGianVao)
                    .FirstOrDefault();

                // Hiển thị giờ vào
                if (datPhong != null)
                {
                    txt_GioVao.Text = datPhong.ThoiGianVao.ToString("HH:mm:ss");
                }
            }
            else
            {
                txt_GioVao.Text = "Phòng chưa được sử dụng";
            }
        }
    }
};

                // Gắn hình ảnh cho nút theo trạng thái
                if (item.HienDung == 0)
                {
                    btnRoom.Image = imageList1.Images[0]; // Hình ảnh phòng trống
                }
                else
                {
                    btnRoom.Image = imageList1.Images[1]; // Hình ảnh phòng đang sử dụng
                }

                // Thêm nút vào FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(btnRoom);
            }
        }
        private void ReloadRoomData()
        {
            try
            {
                using (var context = new KaraokeContextDB())
                {
                    listPhong = context.PHONGs.ToList(); // Lấy danh sách phòng từ cơ sở dữ liệu
                    DisplayRooms(listPhong); // Hiển thị lại danh sách phòng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lại dữ liệu phòng: {ex.Message}", "Lỗi");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStripPhongChuaSuDung_Opening(object sender, CancelEventArgs e)
        {

        }

        private void chuyểnPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void chuyểnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button selectedButton = (System.Windows.Forms.Button)menuStripPhongDaSuDung.SourceControl; // Lấy Button được chọn
            int idPhong = (int)selectedButton.Tag;

            // Hiển thị màn hình chuyển phòng
            ChuyenPhongDialog chuyenPhongForm = new ChuyenPhongDialog(idPhong);
            chuyenPhongForm.ShowDialog();

            // Sau khi chuyển phòng, cập nhật giao diện
            DisplayRooms(listPhong);
            ReloadRoomData();
        }
    }
}
