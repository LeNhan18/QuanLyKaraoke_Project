using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAL;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB context = new KaraokeContextDB())
                {
                    List<KHACH_HANG> listKhachHang = context.KHACH_HANG.ToList();
                    BindGrid(listKhachHang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<KHACH_HANG> listKhachHang)
        {
            dataGridView1.Rows.Clear();
            foreach (var kh in listKhachHang)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = kh.IDKhachHang;
                dataGridView1.Rows[index].Cells[1].Value = kh.HoTen;
                dataGridView1.Rows[index].Cells[2].Value = kh.SDT;
                dataGridView1.Rows[index].Cells[3].Value = kh.DiaChi;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            txtMakhachhang.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
            txtHoten.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
            txtSDT.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
            txtDiachi.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB db = new KaraokeContextDB())
                {
                    if (!int.TryParse(txtMakhachhang.Text, out int idKhachHang))
                    {
                        MessageBox.Show("ID khách hàng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    KHACH_HANG khachHang = db.KHACH_HANG.FirstOrDefault(kh => kh.IDKhachHang == idKhachHang);

                    if (khachHang != null)
                    {
                        string newSDT = txtSDT.Text?.Trim();

                        if (db.KHACH_HANG.Any(kh => kh.SDT == newSDT && kh.IDKhachHang != idKhachHang))
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        khachHang.HoTen = txtHoten.Text?.Trim();
                        khachHang.SDT = newSDT;
                        khachHang.DiaChi = txtDiachi.Text?.Trim();

                        db.SaveChanges();

                        BindGrid(db.KHACH_HANG.ToList());
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB db = new KaraokeContextDB())
                {
                    string newSDT = txtSDT.Text?.Trim();

                    if (db.KHACH_HANG.Any(kh => kh.SDT == newSDT))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newKhachHang = new KHACH_HANG
                    {
                        HoTen = txtHoten.Text?.Trim(),
                        SDT = newSDT,
                        DiaChi = txtDiachi.Text?.Trim()
                    };

                    db.KHACH_HANG.Add(newKhachHang);
                    db.SaveChanges();

                    BindGrid(db.KHACH_HANG.ToList());
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtHoten.Clear();
                    txtSDT.Clear();
                    txtDiachi.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB db = new KaraokeContextDB())
                {
                    if (!int.TryParse(txtMakhachhang.Text, out int idKhachHang))
                    {
                        MessageBox.Show("ID khách hàng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var khachHang = db.KHACH_HANG.FirstOrDefault(kh => kh.IDKhachHang == idKhachHang);

                    if (khachHang != null)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            db.KHACH_HANG.Remove(khachHang);
                            db.SaveChanges();

                            BindGrid(db.KHACH_HANG.ToList());
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtMakhachhang.Clear();
                            txtHoten.Clear();
                            txtSDT.Clear();
                            txtDiachi.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB db = new KaraokeContextDB())
                {
                    string hoTen = txtHoten.Text?.Trim();
                    string diaChi = txtDiachi.Text?.Trim();
                    string sdt = txtSDT.Text?.Trim();
                    string idKhachHangText = txtMakhachhang.Text?.Trim();

                    IQueryable<KHACH_HANG> query = db.KHACH_HANG;

                    if (!string.IsNullOrEmpty(hoTen))
                    {
                        query = query.Where(kh => kh.HoTen.Contains(hoTen));
                    }

                    if (!string.IsNullOrEmpty(diaChi))
                    {
                        query = query.Where(kh => kh.DiaChi.Contains(diaChi));
                    }

                    if (!string.IsNullOrEmpty(sdt))
                    {
                        query = query.Where(kh => kh.SDT == sdt);
                    }

                    if (!string.IsNullOrEmpty(idKhachHangText) && int.TryParse(idKhachHangText, out int idKhachHang))
                    {
                        query = query.Where(kh => kh.IDKhachHang == idKhachHang);
                    }

                    List<KHACH_HANG> result = query.ToList();
                    BindGrid(result);

                    if (result.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtMakhachhang.Text = row.Cells[0].Value.ToString(); // Tên Phòng
                    txtHoten.Text = row.Cells[1].Value.ToString();
                    txtSDT.Text = row.Cells[2].Value.ToString();
                    txtDiachi.Text = row.Cells[3].Value.ToString();
                    // Loại Phòng

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo lỗi");

            }
        }
    }
}