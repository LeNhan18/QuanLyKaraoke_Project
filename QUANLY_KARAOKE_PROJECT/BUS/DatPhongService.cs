using DAL;
using System;
using System.Linq;

namespace BUS
{
    public class DatPhongService
    {
        private KaraokeContextDB context; // Khởi tạo context để truy cập cơ sở dữ liệu

        public DatPhongService()
        {
            context = new KaraokeContextDB(); // Khởi tạo context trong constructor
        }
        public DAT_PHONG ktraTheoID(int idPhong)
        {
            return context.DAT_PHONG.FirstOrDefault(dp => dp.IDPhong == idPhong && dp.ThoiGianRa == null);
        }
        // Đặt phòng
        public void DatPhong(int idPhong, int idKhachHang, DateTime thoiGianVao)
        {
            var datPhong = new DAT_PHONG
            {
                IDPhong = idPhong,
                IDKhachHang = idKhachHang,
                ThoiGianVao = thoiGianVao,
                TienPhong = 0 // Ban đầu tiền phòng là 0
            };

            try
            {
                context.DAT_PHONG.Add(datPhong); // Thêm thông tin đặt phòng vào cơ sở dữ liệu
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đặt phòng: " + ex.Message);
            }
        }

        // Trả phòng
        public void TraPhong(int idPhong)
        {
            var datPhong = ktraTheoID(idPhong);
            if (datPhong != null)
            {
                datPhong.ThoiGianRa = DateTime.Now; // Cập nhật thời gian trả phòng
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
            else
            {
                throw new Exception("Không tìm thấy thông tin đặt phòng hoặc phòng chưa được trả.");
            }
        }
        public int TinhTienPhong(int idPhong)
        {
            var datPhong = ktraTheoID(idPhong);
            if (datPhong == null)
                throw new Exception("Không tìm thấy thông tin đặt phòng!");

            var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
            if (phong == null)
                throw new Exception("Không tìm thấy thông tin phòng!");

            int giaCoBan = phong.LOAI_PHONG.Gia; 

            DateTime thoiGianVao = datPhong.ThoiGianVao;
            DateTime thoiGianHienTai = DateTime.Now;

            TimeSpan khoangThoiGian = thoiGianHienTai - thoiGianVao;
            int soGio = (int)Math.Ceiling(khoangThoiGian.TotalHours);

            int tienPhong = soGio * giaCoBan;

            datPhong.TienPhong = tienPhong;
            context.SaveChanges(); 

            return tienPhong;
        }

    }
}
