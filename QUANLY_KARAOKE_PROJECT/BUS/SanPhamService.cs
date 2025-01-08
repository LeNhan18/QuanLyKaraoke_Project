using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamService
    {
        private KaraokeContextDB context;
        private HoaDonService hoaDonService = new HoaDonService();
        public SanPhamService()
        {
            context = new KaraokeContextDB();
        }
        public SAN_PHAM LayTheoTen(string tenSanPham)
        {
            try
            {
                return context.SAN_PHAM.FirstOrDefault(sp => sp.TenSanPham == tenSanPham);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy sản phẩm theo tên: " + ex.Message);
            }
        }
        public List<SAN_PHAM> LayDanhSachSanPham()
        {
            try
            {
                return context.SAN_PHAM.ToList(); 
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sản phẩm: " + ex.Message);
            }
        }

        // Tìm sản phẩm theo tên
        public SAN_PHAM TimSanPhamTheoTen(string tenSanPham)
        {
            try
            {
                return context.SAN_PHAM.FirstOrDefault(sp => sp.TenSanPham == tenSanPham); // Tìm sản phẩm theo tên
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm sản phẩm: " + ex.Message);
            }
        }
        public int TinhTienSanPham(int soLuong, int donGia)
        {
            return soLuong * donGia; 
        }


        public bool KiemTraSanPhamTonTai(string tenSanPham)
        {
            try
            {
                var sanPham = context.SAN_PHAM.FirstOrDefault(sp => sp.TenSanPham == tenSanPham);
                return sanPham != null; 
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra sản phẩm: " + ex.Message);
            }
        }
        public void LuuSanPhamVaoCSDL(string tenSanPham, int soLuong, int thanhTien, int idPhong)
        {
            try
            {
                if (context == null)
                {
                  
                    return;
                }
                var sanPham = context.SAN_PHAM.FirstOrDefault(sp => sp.TenSanPham == tenSanPham && sp.HienDung == 1);
                if (sanPham == null)
                {
                    return;
                }
                var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong && p.HienDung == 1);
                if (phong == null)
                {
                    return;
                }
                var datPhong = context.DAT_PHONG.FirstOrDefault(dp => dp.IDPhong == idPhong);
                if (datPhong == null)
                {
                 
                    return;
                }
                var hoaDon = context.HOA_DON.FirstOrDefault(hd => hd.IDDatPhong == idPhong && hd.TrangThai == 1);
                DateTime thoiGianVao = datPhong.ThoiGianVao;
                DateTime thoiGianHienTai = DateTime.Now;
                TimeSpan khoangThoiGian = thoiGianHienTai - thoiGianVao;
                int soGio = (int)Math.Ceiling(khoangThoiGian.TotalHours);
                int tienPhong = phong.LOAI_PHONG.Gia * soGio;
                datPhong.TienPhong = tienPhong;
                if (hoaDon == null)
                {
                    hoaDon = new HOA_DON
                    {
                        IDHoaDon = hoaDonService.TAOMAHOADON(),
                        IDKhachHang = datPhong.IDKhachHang,
                        IDDatPhong = datPhong.IDDatPhong,
                        NgayGioTao = DateTime.Now,
                        GhiChu = "Hóa đơn mới",
                        TongCong = 0,
                        GiamGia = 0,
                        Tong = 0,
                        TrangThai = 1,
                        PhuThu = 0
                    };
                    context.HOA_DON.Add(hoaDon);
                }
                if (soLuong <= 0)
                {
                    return;
                }
                var existingRecord = context.HOA_DON_SAN_PHAM.FirstOrDefault(
                    hdsp => hdsp.IDSanPham == sanPham.IDSanPham &&
                    hdsp.IDPhong == idPhong &&
                    hdsp.IDHoaDon == hoaDon.IDHoaDon);

                if (existingRecord != null)
                {
                    existingRecord.SoLuong += soLuong;
                    existingRecord.ThanhTien += thanhTien;
                }
                else
                {
                    HOA_DON_SAN_PHAM hoaDonSanPham = new HOA_DON_SAN_PHAM
                    {
                        IDHoaDon = hoaDon.IDHoaDon,
                        IDSanPham = sanPham.IDSanPham,
                        SoLuong = soLuong,
                        ThanhTien = thanhTien,
                        IDPhong = idPhong
                    };
                    context.HOA_DON_SAN_PHAM.Add(hoaDonSanPham);
                }
                hoaDon.TongCong += thanhTien;
                hoaDon.Tong += thanhTien;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi chi tiết
                string innerMessage = ex.InnerException != null ? ex.InnerException.Message : "Không có thông tin chi tiết.";
            }
        }
        
    }
}
