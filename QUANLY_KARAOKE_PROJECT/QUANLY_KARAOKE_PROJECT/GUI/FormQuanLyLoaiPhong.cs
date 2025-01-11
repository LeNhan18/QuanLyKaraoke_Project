using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class FormQuanLyLoaiPhong : Form
    {
        public readonly PhongService phongService;
        public KaraokeContextDB karaokeContextDB = new KaraokeContextDB();
        public PHONG newPhong { get; private set; }
        public FormQuanLyLoaiPhong()
        {
            InitializeComponent();
        }

        private void FormQuanLyLoaiPhong_Load(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB context = new KaraokeContextDB())
                {
                    List<PHONG> listPhong = context.PHONGs.ToList();
                    BindGrid(listPhong);
                    List<LOAI_PHONG> listLoaiPhong = context.LOAI_PHONG.ToList();
                    FillLoaiPhongCombobox(listLoaiPhong);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillLoaiPhongCombobox(List<LOAI_PHONG> listLoaiPhong)
        {
            this.comboBox_LoaiPhong.DataSource = listLoaiPhong;
            this.comboBox_LoaiPhong.DisplayMember = "TenLoaiPhong";
            this.comboBox_LoaiPhong.ValueMember = "IDLoaiPhong";
        }
        private void BindGrid(List<PHONG> listPhong)
        {
            dataGridView_LoaiPhong.Rows.Clear();
            foreach (var p in listPhong)
            {
                int index = dataGridView_LoaiPhong.Rows.Add();
                dataGridView_LoaiPhong.Rows[index].Cells[0].Value = p.IDPhong;
                dataGridView_LoaiPhong.Rows[index].Cells[1].Value = p.TenPhong;
                dataGridView_LoaiPhong.Rows[index].Cells[2].Value = p.LOAI_PHONG.TenLoaiPhong;
                dataGridView_LoaiPhong.Rows[index].Cells[3].Value = p.HienDung;
                dataGridView_LoaiPhong.Rows[index].Cells[4].Value = p.LOAI_PHONG.Gia;
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string tenPhong = txt_Name.Text?.Trim();
                if (string.IsNullOrWhiteSpace(tenPhong))
                {
                    MessageBox.Show("Tên phòng không được để trống!");
                    return;
                }

                if (comboBox_LoaiPhong.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn loại phòng!");
                    return;
                }

                int idLoaiPhong = (int)comboBox_LoaiPhong.SelectedValue;

                // Tạo đối tượng phòng mới
                var newPhong = new PHONG
                {
                    TenPhong = tenPhong,
                    IDLoaiPhong = idLoaiPhong,
                    TrangThai = 0, // Mặc định trạng thái chưa hoạt động
                    HienDung = 0  // Mặc định chưa sử dụng
                };

                // Thêm phòng vào database
                karaokeContextDB.PHONGs.Add(newPhong);
                karaokeContextDB.SaveChanges();

                // Hiển thị lại DataGridView
                BindGrid(karaokeContextDB.PHONGs.ToList());

                // Gửi thông báo
                MessageBox.Show("Thêm phòng thành công!");

                // Xóa dữ liệu nhập
                txt_Name.Clear();
                comboBox_LoaiPhong.SelectedIndex = -1;
                label10.Text = "0 VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem dòng hiện tại có hợp lệ không
                if (dataGridView_LoaiPhong.CurrentRow != null)
                {
                    // Lấy ID phòng từ dòng hiện tại
                    int idPhong = Convert.ToInt32(dataGridView_LoaiPhong.CurrentRow.Cells[0].Value);

                    // Hiển thị hộp thoại xác nhận
                    DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        using (KaraokeContextDB context = new KaraokeContextDB())
                        {
                            // Tìm phòng cần xóa
                            var phong = context.PHONGs.SingleOrDefault(p => p.IDPhong == idPhong);
                            if (phong != null)
                            {
                                context.PHONGs.Remove(phong); // Xóa phòng
                                context.SaveChanges(); // Lưu thay đổi
                                MessageBox.Show("Xóa thành công!", "Thông báo");

                                // Cập nhật lại DataGridView
                                List<PHONG> listPhong = context.PHONGs.ToList();
                                BindGrid(listPhong);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy phòng cần xóa!", "Thông báo");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phòng để xóa!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_LoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            try
            {
  
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView_LoaiPhong.Rows[e.RowIndex];
                    txt_Name.Text = row.Cells[1].Value.ToString(); // Tên Phòng
                    comboBox_LoaiPhong.Text = row.Cells[2].Value.ToString();
                    label5.Text = row.Cells[4].Value.ToString();
                    // Loại Phòng

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo lỗi");
            
        }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dòng đang chọn trong DataGridView
                if (dataGridView_LoaiPhong.CurrentRow != null)
                {
                    int idPhong = Convert.ToInt32(dataGridView_LoaiPhong.CurrentRow.Cells[0].Value);

                    using (KaraokeContextDB context = new KaraokeContextDB())
                    {
     
                        var phong = context.PHONGs.SingleOrDefault(p => p.IDPhong == idPhong);
                        if (phong != null)
                        {
                            phong.TenPhong = txt_Name.Text;
                            phong.IDLoaiPhong = Convert.ToInt32(comboBox_LoaiPhong.SelectedValue);
                            context.SaveChanges();
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");

                            BindGrid(context.PHONGs.ToList());
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phòng cần sửa!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phòng để sửa!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_Name.Text.Trim(); // Lấy từ khóa tìm kiếm tên phòng
                int selectedLoaiPhongID = comboBox_LoaiPhong.SelectedValue != null
                                          ? Convert.ToInt32(comboBox_LoaiPhong.SelectedValue)
                                          : 0; // Lấy ID Loại Phòng được chọn

                using (KaraokeContextDB context = new KaraokeContextDB())
                {
                    // Tìm kiếm dựa trên Tên Phòng và Loại Phòng
                    var listPhong = context.PHONGs
                                           .Where(p =>
                                               (string.IsNullOrEmpty(keyword) || p.TenPhong.Contains(keyword)) &&
                                               (selectedLoaiPhongID == 0 || p.IDLoaiPhong == selectedLoaiPhongID))
                                           .ToList();

                    BindGrid(listPhong); // Hiển thị danh sách kết quả lên DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_LoaiPhong.SelectedValue is int selectedID)
                {
                    var loaiPhong = karaokeContextDB.LOAI_PHONG.FirstOrDefault(lp => lp.IDLoaiPhong == selectedID);
                    if (loaiPhong != null)
                    {
                        label10.Text = loaiPhong.Gia.ToString("N0") + " VND";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
