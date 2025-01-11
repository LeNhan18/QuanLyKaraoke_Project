using QUANLY_KARAOKE_PROJECT;
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
using Microsoft.VisualBasic;
using BUS;
using System.Resources;
using System.Speech.Synthesis;
using NAudio.Wave;
using DAL;
using System.IO;

namespace QUANLY_KARAOKE_PROJECT
{

    public partial class Form1 : Form
    {
        private List<PHONG> listPhong;
        private KaraokeContextDB context;
        private SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        private readonly PhongService phongService = new PhongService();
        private readonly SanPhamService SanPhamService = new SanPhamService();
        private readonly HoaDonService hoaDonService = new HoaDonService();
        private readonly DatPhongService dat = new DatPhongService();
        private readonly KhachHangService KhachHangService = new KhachHangService();
        private readonly HoaDonSanPhamService hoaDonSanPhamService = new HoaDonSanPhamService();
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader; 

        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLoaiPhong formQuanLyLoaiPhong = new FormQuanLyLoaiPhong();
            formQuanLyLoaiPhong.ShowDialog();
        }
        private void BindGrid(List<PHONG> listPhong, List<SAN_PHAM> listSanPham)
        {
            //dataGridView_Phong.Rows.Clear();
            //foreach (var item in listPhong)
            //{
            //    int index = dataGridView_Phong.Rows.Add();
            //    dataGridView_Phong.Rows[index].Cells[0].Value = item.IDPhong;
            //    dataGridView_Phong.Rows[index].Cells[1].Value = item.TenPhong;
            //    dataGridView_Phong.Rows[index].Cells[2].Value = item.HienDung;
            //}
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
                if (context == null)
                    context = new KaraokeContextDB();

                listPhong = phongService.get3Row();
                var listSanPham = SanPhamService.LayDanhSachSanPham();

                DisplayRooms(listPhong);
                BindGrid(listPhong, listSanPham);
                LoadSongsToListView();
                timer1.Tick += timer1_Tick;
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            speechSynthesizer.SpeakAsync("Bạn có chắc chắn muốn thoát ứng dụng không?");
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                speechSynthesizer.SpeakAsync("Ứng dụng sẽ được đóng. Cảm ơn bạn!");
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
            if (dataGridView_SanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_SanPham.SelectedRows[0];
                string tenSanPham = selectedRow.Cells[1].Value.ToString();
                int donGia = Convert.ToInt32(selectedRow.Cells[2].Value);

                int idPhong = GetSelectedRoomID();
                if (idPhong == -1)
                {
                    MessageBox.Show("Vui lòng chọn phòng trước khi thêm sản phẩm!", "Thông báo");
                    return;
                }
                using (NhapSoLuong formNhapSoLuong = new NhapSoLuong(tenSanPham))
                {
                    if (formNhapSoLuong.ShowDialog() == DialogResult.OK)
                    {
                        int soLuong = formNhapSoLuong.SoLuong;
                        int thanhTien = soLuong * donGia;

                        ThemSanPhamVaoGridView(tenSanPham, soLuong, donGia, thanhTien);
                        SanPhamService.LuuSanPhamVaoCSDL(tenSanPham, soLuong, thanhTien, idPhong);

                    }
                }
            }
        }

        private void dataGridView_Phong_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            ////Chọn chuột phải cho từng hàng trong data grid view phòng
            //if (e.Button == MouseButtons.Right)
            //{
            //    dataGridView_Phong.Rows[e.RowIndex].Selected = true;
            //    rowIndex = e.RowIndex;
            //    dataGridView_Phong.CurrentCell = dataGridView_Phong.Rows[e.RowIndex].Cells[0];

            //    // Lấy giá trị hiện dùng từ DataGridView
            //    var hienDungValue = dataGridView_Phong.Rows[e.RowIndex].Cells[2].Value;

            //    if (hienDungValue != null && int.TryParse(hienDungValue.ToString(), out int hienDung))
            //    {
            //        if (hienDung == 0)
            //        {
            //            menuStripPhongChuaSuDung.Show(dataGridView_Phong, e.Location);
            //            menuStripPhongChuaSuDung.Show(Cursor.Position);
            //        }
            //        else if (hienDung == 1)
            //        {
            //            menuStripPhongDaSuDung.Show(dataGridView_Phong, e.Location);
            //            menuStripPhongDaSuDung.Show(Cursor.Position);
            //        }
            //    }
            //}
        }

        private void dataGridView_Phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (e.RowIndex >= 0 && e.RowIndex < dataGridView_Phong.Rows.Count)
            //    {
            //        DataGridViewRow selectedRow = dataGridView_Phong.Rows[e.RowIndex];
            //        string tenPhong = selectedRow.Cells[1].Value?.ToString() ?? "N/A";

            //        if (string.IsNullOrEmpty(tenPhong) || tenPhong == "N/A")
            //        {
            //            MessageBox.Show("Không thể lấy thông tin tên phòng.", "Lỗi");
            //            return;
            //        }
            //        label_TenPhong.Text = $"{tenPhong}";

            //        KaraokeContextDB context = new KaraokeContextDB();
            //        var phong = phongService.FindByTenPhong(tenPhong);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            //}
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
                var selectedButton = (System.Windows.Forms.Button)menuStripPhongChuaSuDung.SourceControl;
                int idPhong = (int)selectedButton.Tag;

                using (var context = new KaraokeContextDB())
                {
                    // Tìm phòng trong cơ sở dữ liệu
                    var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
                    if (phong != null && phong.HienDung == 0) // Nếu phòng chưa được sử dụng
                    {
                        // ---- Mở form chọn KH ----
                        using (ChonKhachHang frmChonKhach = new ChonKhachHang())
                        {
                            if (frmChonKhach.ShowDialog() == DialogResult.OK)
                            {
                                // Lấy IDKhachHang người dùng đã chọn
                                int selectedKH = frmChonKhach.SelectedKhachHangID;
                        
                                if (selectedKH == 0)
                                {
                                    MessageBox.Show("Bạn chưa chọn khách hàng, không thể sử dụng phòng!");
                                    return;
                                }
                                phong.HienDung = 1;
                                var datPhong = new DAT_PHONG
                                {
                                    IDPhong = idPhong,
                                    IDKhachHang = selectedKH, 
                                    ThoiGianVao = DateTime.Now,
                                    TienPhong = 0
                                };
                                context.DAT_PHONG.Add(datPhong);
                                context.SaveChanges();

                                speechSynthesizer.SpeakAsync(
                                    $"Phòng {phong.TenPhong} đã được sử dụng lúc {DateTime.Now:HH:mm:ss}"
                                );
                                MessageBox.Show(
                                    $"Phòng {phong.TenPhong} đã được sử dụng lúc {DateTime.Now:HH:mm:ss}"
                                );

                                ReloadRoomData();
                            }
                            else
                            {

                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng đã được sử dụng hoặc không tồn tại.");
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
            try
            {
                using (var context = new KaraokeContextDB())
                {
                    System.Windows.Forms.Button selectedButton = (System.Windows.Forms.Button)menuStripPhongChuaSuDung.SourceControl;
                    int idPhong = (int)selectedButton.Tag;

                    var phong = phongService.FINDPHONG(idPhong);
                    if (phong != null && phong.HienDung == 0)
                    {
                        try
                        {
                            Manhinhdatphong manhinhdatphong = new Manhinhdatphong(phong.TenPhong);
                            manhinhdatphong.ShowDialog();

                            phong.HienDung = 1;

                            selectedButton.ImageIndex = 1;
                            ReloadRoomData();

                            MessageBox.Show($"Phòng {phong.TenPhong} đã được sử dụng lúc {DateTime.Now.ToString("HH:mm:ss")}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi mở form đặt phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng đang được sử dụng!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Vui lòng chọn một phòng để đặt! {ex.Message}");
            }
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                // Lấy nút phòng được chọn từ menu context
                if (menuStripPhongDaSuDung.SourceControl is System.Windows.Forms.Button selectedButton)
                {
                    // Lấy ID phòng từ thuộc tính Tag của nút và chuyển sang string
                    int idPhong = (int)selectedButton.Tag;
                    int idKhach = context.DAT_PHONG.FirstOrDefault(dp => dp.IDPhong == idPhong).IDKhachHang;
                    // Mở form MhTinhTien và truyền ID phòng
                    MhTinhTien a = new MhTinhTien(idPhong, idKhach);
                    a.ShowDialog();
                    ReloadRoomData();
                    speechSynthesizer.SpeakAsync($"Bạn tính tiền {idPhong}");
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

        private void tínhTiềnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (KaraokeContextDB context = new KaraokeContextDB())
                {
                    if (menuStripPhongDaSuDung.SourceControl is System.Windows.Forms.Button selectedButton)
                    {
                        // Kiểm tra giá trị Tag của nút
                        if (selectedButton.Tag == null || !(selectedButton.Tag is int))
                        {
                            MessageBox.Show("Không thể xác định ID phòng từ nút được chọn!", "Lỗi");
                            return;
                        }

                        int idPhong = (int)selectedButton.Tag;
                       
                        // Lấy thông tin đặt phòng từ cơ sở dữ liệu
                        var datPhong = context.DAT_PHONG.FirstOrDefault(dp => dp.IDPhong == idPhong);
                        if (datPhong == null)
                        {
                            MessageBox.Show("Không tìm thấy thông tin phòng trong cơ sở dữ liệu!", "Lỗi");
                            return;
                        }
                        int idKhach = datPhong.IDKhachHang;
                        if (idKhach == 0)
                        {
                            MessageBox.Show("Phòng này chưa được gán cho khách hàng!", "Lỗi");
                            return;
                        }
                        MhTinhTien a = new MhTinhTien(idPhong, idKhach);
                        a.ShowDialog();

                        // Làm mới dữ liệu phòng
                        ReloadRoomData();

                        // Phát âm thanh thông báo
                        speechSynthesizer.SpeakAsync($"Bạn tính tiền {idPhong}");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xác định phòng được chọn!", "Lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi");
            }



        }
        private void DisplayRooms(List<PHONG> listPhong)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in listPhong)
            {
                System.Windows.Forms.Button btnRoom = new System.Windows.Forms.Button
                {
                    Text = item.TenPhong,
                    Tag = item.IDPhong,
                    Width = 120,
                    Height = 120,
                    BackColor = item.HienDung == 0 ? Color.LightSkyBlue : Color.LightSlateGray,
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Margin = new Padding(15),
                    TextAlign = ContentAlignment.BottomCenter

                };

                if (item.HienDung == 1) // Phòng đang sử dụng
                {
                    using (var context = new KaraokeContextDB())
                    {
                        var datPhong = context.DAT_PHONG.FirstOrDefault(dp => dp.IDPhong == item.IDPhong && dp.ThoiGianRa == null);
                        if (datPhong != null)
                        {
                            TimeSpan thoiGianSuDung = DateTime.Now - datPhong.ThoiGianVao;
                            string soGioSuDung = $"{(int)thoiGianSuDung.TotalHours:D2}:{thoiGianSuDung.Minutes:D2}"; // Hiển thị HH:mm
                            btnRoom.Text += $"\n{soGioSuDung}";
                        }
                    }
                }

                btnRoom.MouseUp += (sender, e) =>
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
                        int idPhong = (int)clickedButton.Tag;
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

                btnRoom.Click += (sender, e) =>
                {
                    System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
                    int idPhong = (int)clickedButton.Tag;

                    try
                    {
                        using (var context = new KaraokeContextDB())
                        {
                            // Lấy thông tin phòng và hóa đơn
                            var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
                            if (phong == null)
                            {
                                MessageBox.Show("Không tìm thấy thông tin phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            label_TenPhong.Text = phong.TenPhong; // Hiển thị tên phòng
                            speechSynthesizer.SpeakAsync($"Bạn đã chọn phòng {btnRoom.Text}");
                            if (phong.HienDung == 1) // Nếu phòng đang sử dụng
                            {
                                // Lấy thông tin đặt phòng mới nhất
                                var datPhong = context.DAT_PHONG
                                    .Where(dp => dp.IDPhong == phong.IDPhong)
                                    .OrderByDescending(dp => dp.ThoiGianVao)
                                    .FirstOrDefault();

                                txt_GioVao.Text = datPhong != null
                                    ? datPhong.ThoiGianVao.ToString("HH:mm:ss") // Hiển thị giờ vào
                                    : "Không có thông tin giờ vào";

                                HienThiSanPhamTheoPhong(idPhong); // Hiển thị danh sách sản phẩm
                            }
                            else // Nếu phòng chưa được sử dụng
                            {
                                txt_GioVao.Text = "Phòng trống";
                                dataGridView_SanPhamDaChon.Rows.Clear(); // Xóa danh sách sản phẩm
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi hiển thị chi tiết phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                if (item.HienDung == 0)
                {
                    btnRoom.Image = imageList1.Images[0];
                }
                else
                {
                    btnRoom.Image = imageList1.Images[1];
                }
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
            speechSynthesizer.SpeakAsync($"Bạn chuyển phòng{idPhong}");

            DisplayRooms(listPhong);
            ReloadRoomData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void dataGridView_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ThemSanPhamVaoGridView(string tenSanPham, int soLuong, int donGia, int thanhTien)
        {
            dataGridView_SanPhamDaChon.Rows.Add(
                tenSanPham,
                donGia,
                soLuong,
                thanhTien
            );
        }
        private int GetSelectedRoomID()
        {
            if (label_TenPhong.Text.StartsWith("P"))
            {
                var phong = phongService.FindByTenPhong(label_TenPhong.Text);
                if (phong != null)
                    return phong.IDPhong;
            }
            return -1; // Không có phòng nào được chọn
        }
        private void HienThiSanPhamTheoPhong(int idPhong)
        {
            try
            {

                // Lấy danh sách sản phẩm theo phòng
                var danhSachSanPham = context.HOA_DON_SAN_PHAM
                    .Where(hdsp => hdsp.IDPhong == idPhong)
                    .Select(hdsp => new
                    {
                        TenSanPham = hdsp.SAN_PHAM.TenSanPham,
                        DonGia = hdsp.SAN_PHAM.DonGia,
                        SoLuong = hdsp.SoLuong,
                        ThanhTien = hdsp.ThanhTien
                    })
                    .ToList();

                // Xóa dữ liệu cũ trong DataGridView
                dataGridView_SanPhamDaChon.Rows.Clear();

                // Hiển thị các sản phẩm đã được thêm vào hóa đơn
                foreach (var sp in danhSachSanPham)
                {
                    int index = dataGridView_SanPhamDaChon.Rows.Add();
                    dataGridView_SanPhamDaChon.Rows[index].Cells[0].Value = sp.TenSanPham;
                    dataGridView_SanPhamDaChon.Rows[index].Cells[1].Value = sp.DonGia;
                    dataGridView_SanPhamDaChon.Rows[index].Cells[2].Value = sp.SoLuong;
                    dataGridView_SanPhamDaChon.Rows[index].Cells[3].Value = sp.ThanhTien;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi hiển thị sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_BCTK_Click(object sender, EventArgs e)
        {
            ManHinhThongKe a = new ManHinhThongKe();
            a.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void btn_Hóadon_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (lvPlaylist.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bài hát!", "Thông báo");
                return;
            }

            string filePath = lvPlaylist.SelectedItems[0].SubItems[1].Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Đường dẫn bài hát không tồn tại!", "Lỗi");
                return;
            }

            try
            {
                waveOut?.Stop(); // Dừng bài hát hiện tại nếu đang phát
                waveOut = new WaveOutEvent();
                audioFileReader = new AudioFileReader(filePath);
                waveOut.Init(audioFileReader);
                waveOut.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi phát nhạc: {ex.Message}", "Lỗi");
            }
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            waveOut?.Stop(); // Dừng phát nhạc
        }
        private void BtnAddSong_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Files MP3 (*.mp3)|*.mp3|All files (*.*)|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var context = new KaraokeContextDB())
                        {
                            foreach (string filePath in openFileDialog.FileNames)
                            {
                                string fileName = Path.GetFileNameWithoutExtension(filePath);

                                // Kiểm tra nếu bài hát đã tồn tại trong cơ sở dữ liệu
                                bool songExists = context.PLAYLISTs.Any(p => p.FilePath == filePath);
                                if (!songExists)
                                {
                                    // Thêm bài hát mới vào cơ sở dữ liệu
                                    PLAYLIST newSong = new PLAYLIST
                                    {
                                        Names = fileName,
                                        FilePath = filePath
                                    };
                                    context.PLAYLISTs.Add(newSong);
                                }
                            }
                            context.SaveChanges();
                        }

                        // Tải lại danh sách bài hát từ cơ sở dữ liệu
                        LoadSongsToListView();
                        MessageBox.Show("Đã thêm bài hát thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi thêm bài hát: {ex.Message}");
                    }
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            waveOut?.Dispose();
            audioFileReader?.Dispose();
            base.OnFormClosing(e);
        }
        private void LoadPlaylist(string playlistName)
        {
            try
            {
                using (var context = new KaraokeContextDB())
                {
                    var songs = context.PLAYLISTs
                        .Where(p => p.Names == playlistName)
                        .ToList();

                    if (songs.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy bài hát nào trong playlist!", "Thông báo");
                        return;
                    }

                    lvPlaylist.Items.Clear();
                    foreach (var song in songs)
                    {
                        ListViewItem item = new ListViewItem(song.Names); // Cột Tên Bài Hát
                        item.SubItems.Add(song.FilePath); // Cột Đường Dẫn
                        lvPlaylist.Items.Add(item);
                    }

                    MessageBox.Show("Tải playlist thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải playlist: {ex.Message}");
            }
        }
        private void SavePlaylist(string playlistName, List<string> songPaths)
        {
            try
            {
                using (var context = new KaraokeContextDB())
                {
                    foreach (string path in songPaths)
                    {
                        string fileName = System.IO.Path.GetFileNameWithoutExtension(path);

                        // Kiểm tra xem bài hát đã tồn tại trong playlist chưa
                        if (!context.PLAYLISTs.Any(p => p.Names == fileName && p.FilePath == path))
                        {
                            PLAYLIST newSong = new PLAYLIST
                            {
                                Names = playlistName,
                                FilePath = path
                            };
                            context.PLAYLISTs.Add(newSong);
                        }
                    }
                    context.SaveChanges();
                    MessageBox.Show("Lưu playlist thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu playlist: {ex.Message}");
            }
        }

        private void LoadSongsToListView()
        {
            try
            {

                using (var context = new KaraokeContextDB())
                {
                    var songs = context.PLAYLISTs.ToList();

                    lvPlaylist.Items.Clear();
                    foreach (var song in songs)
                    {
                        ListViewItem item = new ListViewItem(song.Names); // Tên bài hát
                        item.SubItems.Add(song.FilePath); // Đường dẫn
                        lvPlaylist.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách bài hát: {ex.Message}");
            }
        }

        private void lvPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSanPham form = new ThemSanPham(dataGridView_SanPham);
            form.ShowDialog();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_SanPham.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView_SanPham.SelectedRows[0].Index;
                var sanPhamId = (int)dataGridView_SanPham.Rows[selectedRowIndex].Cells[0].Value;

                using (KaraokeContextDB db = new KaraokeContextDB())
                {
                    var selectedSanPham = db.SAN_PHAM.FirstOrDefault(sp => sp.IDSanPham == sanPhamId);
                    if (selectedSanPham != null)
                    {
                        ChinhSuaSanPham frm = new ChinhSuaSanPham(dataGridView_SanPham);
                        {
                            frm.SelectedSanPham = selectedSanPham;
                        };
                        frm.ShowDialog();
                        BindGrid(db.PHONGs.ToList(), db.SAN_PHAM.ToList());
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_SanPham.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView_SanPham.SelectedRows[0].Index;
                var sanPhamId = (int)dataGridView_SanPham.Rows[selectedRowIndex].Cells[0].Value;

                using (KaraokeContextDB db = new KaraokeContextDB())
                {
                    var selectedSanPham = db.SAN_PHAM.FirstOrDefault(sp => sp.IDSanPham == sanPhamId);
                    if (selectedSanPham != null)
                    {
                        ChiTietSanPham frm = new ChiTietSanPham(dataGridView_SanPham);
                        {
                            frm.SelectedSanPham = selectedSanPham;
                        };
                        frm.ShowDialog();
                        BindGrid(db.PHONGs.ToList(), db.SAN_PHAM.ToList());
                    }
                }
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_SanPham.SelectedRows.Count > 0)
                {
                    DialogResult rs = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rs == DialogResult.OK)
                    {
                        using (KaraokeContextDB db = new KaraokeContextDB())
                        {
                            // lấy thông tin từ datagridview
                            int selectedRowIndex = dataGridView_SanPham.SelectedRows[0].Index;
                            var cellValue = dataGridView_SanPham.Rows[selectedRowIndex].Cells["col_TenSanPham"].Value;
                            // tìm và xóa sản phẩm trong cơ sở dữ liệu
                            if (cellValue != null)
                            {
                                string tenSanPham = cellValue.ToString();
                                var sanpham = db.SAN_PHAM.FirstOrDefault(s => s.TenSanPham == tenSanPham);
                                if (sanpham != null)
                                {
                                    db.SAN_PHAM.Remove(sanpham);
                                    db.SaveChanges();
                                    // xóa dòng khỏi datagridview
                                    dataGridView_SanPham.Rows.RemoveAt(selectedRowIndex);
                                    MessageBox.Show("Sản phẩm đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thêmPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speechSynthesizer.SpeakAsync("Bạn vừa mở chức năng Quản lý loại phòng");
            ManHinhThemPhong a = new ManHinhThemPhong();
            a.ShowDialog();
            ReloadRoomData();
        }
        private void dataGridView_SanPhamDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chỉnhSửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Manhinhchinhsuaphonghat a = new Manhinhchinhsuaphonghat();
            a.ShowDialog();
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BaoCaoThongKeStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManHinhThongKe a = new ManHinhThongKe();
            a.ShowDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void xóaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
