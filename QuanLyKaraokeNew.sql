
GO
/****** Object:  Table [dbo].[DAT_PHONG]    Script Date: 16/12/2024 9:44:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAT_PHONG](
	[IDDatPhong] [varchar](50) NOT NULL,
	[IDKhachHang] [int] NULL,
	[IDPhong] [int] NULL,
	[ThoiGianVao] [datetime] NULL,
	[ThoiGianRa] [datetime] NULL,
	[TienPhong] [int] NULL,
 CONSTRAINT [PK_DAT_PHONG] PRIMARY KEY CLUSTERED 
(
	[IDDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 16/12/2024 9:44:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[IDHoaDon] [varchar](50) NOT NULL,
	[IDKhachHang] [int] NULL,
	[IDDatPhong] [varchar](50) NULL,
	[NgayGioTao] [varchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TongCong] [int] NULL,
	[GiamGia] [int] NULL,
	[Tong] [int] NULL,
	[TrangThai] [tinyint] NULL,
	[PhuThu] [int] NULL,
 CONSTRAINT [PK_HOA_DON] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON_SAN_PHAM]    Script Date: 16/12/2024 9:44:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON_SAN_PHAM](
	[IDHoaDon] [varchar](50) NOT NULL,
	[IDSanPham] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_HOA_DON_SAN_PHAM] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 16/12/2024 9:44:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[IDKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[DiaChi] [varchar](50) NULL,
 CONSTRAINT [PK_KHACH_HANG] PRIMARY KEY CLUSTERED 
(
	[IDKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAI_PHONG]    Script Date: 16/12/2024 9:44:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI_PHONG](
	[IDLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[Gia] [int] NULL,
 CONSTRAINT [PK_LOAI_PHONG] PRIMARY KEY CLUSTERED 
(
	[IDLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 16/12/2024 9:44:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[IDPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [varchar](50) NULL,
	[IDLoaiPhong] [int] NULL,
	[TrangThai] [tinyint] NULL,
	[HienDung] [tinyint] NULL,
 CONSTRAINT [PK_PHONG_1] PRIMARY KEY CLUSTERED 
(
	[IDPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SAN_PHAM]    Script Date: 16/12/2024 9:44:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SAN_PHAM](
	[IDSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[HienDung] [tinyint] NULL,
 CONSTRAINT [PK_SAN_PHAM] PRIMARY KEY CLUSTERED 
(
	[IDSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONG_TIN_QUAN]    Script Date: 16/12/2024 9:44:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONG_TIN_QUAN](
	[ID] [int] NOT NULL,
	[TenQuan] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
 CONSTRAINT [PK_THONG_TIN_QUAN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DAT_PHONG]  WITH CHECK ADD  CONSTRAINT [FK_DAT_PHONG_KHACH_HANG] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[KHACH_HANG] ([IDKhachHang])
GO
ALTER TABLE [dbo].[DAT_PHONG] CHECK CONSTRAINT [FK_DAT_PHONG_KHACH_HANG]
GO
ALTER TABLE [dbo].[DAT_PHONG]  WITH CHECK ADD  CONSTRAINT [FK_DAT_PHONG_PHONG1] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[PHONG] ([IDPhong])
GO
ALTER TABLE [dbo].[DAT_PHONG] CHECK CONSTRAINT [FK_DAT_PHONG_PHONG1]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_DAT_PHONG] FOREIGN KEY([IDDatPhong])
REFERENCES [dbo].[DAT_PHONG] ([IDDatPhong])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [FK_HOA_DON_DAT_PHONG]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_KHACH_HANG] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[KHACH_HANG] ([IDKhachHang])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [FK_HOA_DON_KHACH_HANG]
GO
ALTER TABLE [dbo].[HOA_DON_SAN_PHAM]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_SAN_PHAM_HOA_DON] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HOA_DON] ([IDHoaDon])
GO
ALTER TABLE [dbo].[HOA_DON_SAN_PHAM] CHECK CONSTRAINT [FK_HOA_DON_SAN_PHAM_HOA_DON]
GO
ALTER TABLE [dbo].[HOA_DON_SAN_PHAM]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_SAN_PHAM_SAN_PHAM] FOREIGN KEY([IDSanPham])
REFERENCES [dbo].[SAN_PHAM] ([IDSanPham])
GO
ALTER TABLE [dbo].[HOA_DON_SAN_PHAM] CHECK CONSTRAINT [FK_HOA_DON_SAN_PHAM_SAN_PHAM]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAI_PHONG] FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[LOAI_PHONG] ([IDLoaiPhong])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAI_PHONG]
GO
