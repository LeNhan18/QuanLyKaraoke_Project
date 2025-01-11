using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonSanPhamService
    {
        KaraokeContextDB context = new KaraokeContextDB();
        //public List<HOA_DON_SAN_PHAM> getHDSPTheoIDPhong(int idPhong)
        //{
        //    return context.HOA_DON_SAN_PHAM.Where(hdsp => hdsp.IDPhong == idPhong)
        //                .Select(hdsp => new HOA_DON_SAN_PHAM
        //                {
        //                    IDSanPham = hdsp.SAN_PHAM.IDSanPham,
        //                     = hdsp.SAN_PHAM.DonGia,
        //                    SoLuong = hdsp.SoLuong,
        //                    ThanhTien = hdsp.ThanhTien
        //                })
        //                .ToList();
        //}
        public List<HOA_DON_SAN_PHAM> getHDSPTheoIDPhong(int idPhong)
        {
            return context.HOA_DON_SAN_PHAM.Where(hdsp => hdsp.IDPhong == idPhong).ToList();
        }

    }
}
