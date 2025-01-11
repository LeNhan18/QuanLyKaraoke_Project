using BUS;
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
    public partial class ManHinhThemPhong : Form
    {
        public readonly PhongService phongService;
        public KaraokeContextDB karaokeContextDB = new KaraokeContextDB();
        public PHONG newPhong { get; private set; }
        public ManHinhThemPhong()
        {
            InitializeComponent();
        }

        private void ManHinhThemPhong_Load(object sender, EventArgs e)
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
            dataGridView1.Rows.Clear();
            foreach (var p in listPhong)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = p.IDPhong;
                dataGridView1.Rows[index].Cells[1].Value = p.TenPhong;
                dataGridView1.Rows[index].Cells[2].Value = p.LOAI_PHONG.TenLoaiPhong;
                dataGridView1.Rows[index].Cells[3].Value = p.HienDung;
                dataGridView1.Rows[index].Cells[4].Value = p.LOAI_PHONG.Gia;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            //label6.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
            //txt_TenPhong.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
            //txtSDT.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
            //txtDiachi.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string tenPhong = txt_TenPhong.Text?.Trim();
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
                txt_TenPhong.Clear();
                comboBox_LoaiPhong.SelectedIndex = -1;
                label4.Text = "0 VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message);
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
                        label4.Text = loaiPhong.Gia.ToString("N0") + " VND";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

        }
    }
}
