using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhongService
    {
        KaraokeContextDB context = new KaraokeContextDB();
        public List<PHONG> getAll()
        {

            return context.PHONGs.ToList();
        }
        public List<PHONG> get3Row()
        {
            var rooms = context.PHONGs
                .Select(p => new
                {
                    p.IDPhong,
                    p.TenPhong,
                    p.HienDung
                })
                .ToList();

            return rooms.Select(r => new PHONG
            {
                IDPhong = r.IDPhong,
                TenPhong = r.TenPhong,
                HienDung = r.HienDung
            }).ToList();
        }
        public void SuDungPhong(int idPhong)
        {
            var phong = FINDPHONG(idPhong);
            if (phong != null && phong.HienDung == 0) // Nếu phòng chưa được sử dụng
            {
                // Cập nhật trạng thái phòng thành "Đang sử dụng"
                phong.HienDung = 1;

                var datPhong = new DAT_PHONG
                {
                    IDPhong = idPhong,
                    IDKhachHang = 1, // Giả sử ID khách hàng là 1 (thực tế phải lấy từ khách hàng)
                    ThoiGianVao = DateTime.Now, // Lưu thời gian vào
                    TienPhong = 0 // Ban đầu tiền phòng có thể để 0
                };
                context.DAT_PHONG.Add(datPhong);
                context.SaveChanges();
            }
          
        }
        public PHONG FINDPHONG(int idPhong)
        {
            return context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
        }
        public PHONG FindByTenPhong(string tenPhong)
        {
            return context.PHONGs.FirstOrDefault(p => p.TenPhong == tenPhong);
        }
    }
}
