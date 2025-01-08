using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonService
    {
        private KaraokeContextDB context; 
        public HoaDonService()
        {
            context = new KaraokeContextDB();
        }

        // Tạo hóa đơn
        public void TaoHoaDon(int idKhachHang, int idPhong, int tienPhong, int tienSanPham, int giamGia, int phuThu)
        {
            int tongTien = tienPhong + tienSanPham + phuThu - giamGia;

            var hoaDon = new HOA_DON
            {
                IDHoaDon = TAOMAHOADON(),
                IDKhachHang = idKhachHang,
                IDDatPhong = idPhong,
                NgayGioTao = DateTime.Now,
                TongCong = tienPhong + tienSanPham,
                GiamGia = giamGia,
                PhuThu = phuThu,
                Tong = tongTien,
                TrangThai = 1 // Hóa đơn đã thanh toán
            };

            try
            {
                context.HOA_DON.Add(hoaDon); // Thêm hóa đơn vào cơ sở dữ liệu
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo hóa đơn: " + ex.Message);
            }
        }

        public int TinhTongTien(int tienPhong, int tienSanPham, int giamGia, int phuThu)
        {
            return tienPhong + tienSanPham + phuThu - giamGia; // Tính tổng tiền của hóa đơn
        }
        public void TinhTienPhong(int idPhong)
        {
            try
            {
                var datPhong = context.DAT_PHONG.FirstOrDefault(dp => dp.IDPhong == idPhong && dp.ThoiGianRa == null);

                if (datPhong == null)
                {
                    throw new Exception("Không tìm thấy thông tin đặt phòng hoặc phòng chưa được trả.");
                }
                var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
                if (phong == null)
                {
                    throw new Exception("Không tìm thấy phòng.");
                }
                DateTime thoiGianVao = datPhong.ThoiGianVao;
                DateTime thoiGianHienTai = DateTime.Now;

                TimeSpan khoangThoiGian = thoiGianHienTai - thoiGianVao;
                int soGio = (int)Math.Ceiling(khoangThoiGian.TotalHours);
                int tienPhong = phong.LOAI_PHONG.Gia * soGio;
                datPhong.TienPhong = tienPhong;
                context.SaveChanges();
                Console.WriteLine($"Tiền phòng: {tienPhong} VND, Số giờ sử dụng: {soGio} giờ.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tính tiền phòng: {ex.Message}");
            }
        }
        //public string TaoHoaDon(int idPhong)
        //{
        //    try
        //    {
        //        // Tạo mã hóa đơn mới
        //        string maHoaDon = Guid.NewGuid().ToString();

        //        // Kiểm tra xem phòng có tồn tại và đang sử dụng không
        //        var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
        //        if (phong == null || phong.HienDung == 0)
        //        {
        //            throw new Exception("Phòng không được sử dụng!");
        //        }

        //        // Lấy danh sách sản phẩm đã thêm vào phòng
        //        var danhSachSanPham = context.HOA_DON_SAN_PHAM
        //                                        .Where(hdsp => hdsp.IDPhong == idPhong)
        //                                        .ToList();

        //        if (danhSachSanPham.Count == 0)
        //        {
        //            throw new Exception("Phòng này chưa có sản phẩm nào!");
        //        }

        //        // Tính tổng tiền cho hóa đơn
        //        int tongTienSanPham = danhSachSanPham.Sum(sp => sp.ThanhTien);

        //        // Tạo hóa đơn mới
        //        var hoaDon = new HOA_DON
        //        {
        //            IDHoaDon = maHoaDon,
        //            IDKhachHang = 1, // ID khách hàng có thể thay đổi
        //            IDDatPhong = idPhong,
        //            NgayGioTao = DateTime.Now,
        //            GhiChu = "Hóa đơn tự động",
        //            TongCong = tongTienSanPham, // Tổng tiền sản phẩm
        //            GiamGia = 0, // Giảm giá (nếu có, có thể thêm sau)
        //            PhuThu = 0, // Phụ thu (nếu có, có thể thêm sau)
        //            Tong = tongTienSanPham, // Tổng tiền hóa đơn
        //            TrangThai = 0 // Trạng thái đang xử lý
        //        };

        //        // Lưu hóa đơn vào cơ sở dữ liệu
        //        context.HOA_DON.Add(hoaDon);
        //        context.SaveChanges();  // Lưu hóa đơn

        //        // Cập nhật thông tin chi tiết hóa đơn cho từng sản phẩm
        //        foreach (var sanPham in danhSachSanPham)
        //        {
        //            sanPham.IDHoaDon = maHoaDon;
        //        }

        //        // Sau khi cập nhật thông tin chi tiết hóa đơn cho sản phẩm, lưu lại
        //        context.SaveChanges(); // Chỉ cần gọi SaveChanges một lần sau khi đã cập nhật hết

        //        return maHoaDon;  // Trả về mã hóa đơn đã tạo
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi khi tạo hóa đơn: {ex.Message}");
        //    }
        //}

        //public void CapNhatTongTienHoaDon(string idHoaDon)
        //{
        //    try
        //    {
        //        var hoaDon = context.HOA_DON.FirstOrDefault(hd => hd.IDHoaDon == idHoaDon);
        //        if (hoaDon == null)
        //        {
        //            throw new Exception("Không tìm thấy hóa đơn!");
        //        }

        //        // Lấy tổng tiền từ các sản phẩm đã thêm vào hóa đơn
        //        int tienSanPham = context.HOA_DON_SAN_PHAM
        //                                .Where(hdsp => hdsp.IDHoaDon == idHoaDon)
        //                                .Sum(hdsp => hdsp.ThanhTien);

        //        int phuThu = hoaDon.PhuThu;  // Phụ thu
        //        int giamGia = hoaDon.GiamGia;  // Giảm giá

        //        // Tính lại tổng tiền
        //        hoaDon.Tong = hoaDon.TongCong + tienSanPham + phuThu - giamGia;
        //        context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi khi cập nhật tổng tiền hóa đơn: {ex.Message}");
        //    }
        //}
        //public void ThemSanPhamVaoHoaDon(int idPhong, string tenSanPham, int soLuong)
        //{
        //    try
        //    {
        //        // Tìm phòng theo ID
        //        var phong = context.PHONGs.FirstOrDefault(p => p.IDPhong == idPhong);
        //        if (phong == null)
        //        {
        //            throw new Exception("Không tìm thấy phòng!");
        //        }

        //        // Kiểm tra xem phòng có đang được sử dụng hay không
        //        if (phong.HienDung == 0)
        //        {
        //            throw new Exception("Phòng chưa được sử dụng, không thể thêm sản phẩm!");
        //        }

        //        // Tìm sản phẩm theo tên
        //        var sanPham = context.SAN_PHAM.FirstOrDefault(sp => sp.TenSanPham == tenSanPham);
        //        if (sanPham == null)
        //        {
        //            throw new Exception("Sản phẩm không tồn tại trong hệ thống!");
        //        }

        //        // Tạo hóa đơn nếu chưa có
        //        var hoaDon = context.HOA_DON.FirstOrDefault(hd => hd.IDDatPhong == phong.IDPhong && hd.TrangThai == 0);
        //        if (hoaDon == null)
        //        {
        //            hoaDon = new HOA_DON
        //            {
        //                IDHoaDon = Guid.NewGuid().ToString(),
        //                IDKhachHang = 1,
        //                IDDatPhong = phong.IDPhong,
        //                NgayGioTao = DateTime.Now,
        //                GhiChu = "Hóa đơn tự động",
        //                TongCong = 0,
        //                GiamGia = 0,
        //                PhuThu = 0,
        //                Tong = 0,
        //                TrangThai = 0
        //            };

        //            context.HOA_DON.Add(hoaDon);
        //            context.SaveChanges(); // Lưu hóa đơn vào cơ sở dữ liệu
        //        }

        //        // Lấy thông tin ID hóa đơn
        //        string idHoaDon = hoaDon.IDHoaDon;

        //        // Tính thành tiền của sản phẩm
        //        int thanhTien = soLuong * sanPham.DonGia;

        //        // Thêm sản phẩm vào hóa đơn
        //        var hoaDonSanPham = new HOA_DON_SAN_PHAM
        //        {
        //            IDHoaDon = idHoaDon,
        //            IDSanPham = sanPham.IDSanPham,
        //            SoLuong = soLuong,
        //            ThanhTien = thanhTien,
        //            IDPhong = idPhong
        //        };

        //        context.HOA_DON_SAN_PHAM.Add(hoaDonSanPham);
        //        context.SaveChanges(); // Lưu vào cơ sở dữ liệu

        //        // Cập nhật lại tổng tiền của hóa đơn
        //        hoaDon.TongCong += thanhTien;
        //        hoaDon.Tong += thanhTien;
        //        context.SaveChanges(); // Lưu lại hóa đơn với tổng tiền đã cập nhật
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Đã xảy ra lỗi khi thêm sản phẩm vào hóa đơn: {ex.Message}");
        //    }
        //}

        public string TAOMAHOADON()
        {
            string[] words = { "HOADON" };
            Random random = new Random();
            string wordPart = words[random.Next(words.Length)];
            string numberPart = random.Next(1000, 9999).ToString();

            return $"{wordPart}{numberPart}";
        }
    }
}
