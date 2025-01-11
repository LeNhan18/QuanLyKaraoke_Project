using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BUS
{
    public class KhachHangService
    {
        public KHACH_HANG NewKhachHang { get; private set; }
        KaraokeContextDB context = new KaraokeContextDB();
       public KHACH_HANG ktraSDT_HoTen(string hotenKhachHang ,string sdt)
        {
            return context.KHACH_HANG.FirstOrDefault(kh =>  kh.HoTen.Contains(hotenKhachHang)&& kh.SDT.Contains(sdt));
        }
        public List<KHACH_HANG> GetAllKhachHang()
        {
            return context.KHACH_HANG.ToList();
        }
        public KHACH_HANG CreateKH(string hoTen,string sdt, string diaChi)
        {
            var newKhachHang = new KHACH_HANG
            {
                HoTen = hoTen,
                SDT = sdt,
                DiaChi = diaChi
            };
            return newKhachHang;
        }
        public void CreateKhachHang(KHACH_HANG khachHang)
        {
            context.KHACH_HANG.Add(khachHang);
            context.SaveChanges();
        }
        public List<KHACH_HANG> LayDanhSachKhachHang()
        {
            try
            {
                return context.KHACH_HANG.OrderBy(k => k.HoTen).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khách hàng: " + ex.Message);
            }
        }
    }
}
