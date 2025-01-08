USE [master]
GO
/****** Object:  Database [QuanLyKaraokeNew]    Script Date: 1/6/2025 10:13:30 PM ******/
CREATE DATABASE [QuanLyKaraokeNew]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKaraokeNew', FILENAME = N'D:\SQL SERVER\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyKaraokeNew.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyKaraokeNew_log', FILENAME = N'D:\SQL SERVER\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyKaraokeNew_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyKaraokeNew] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKaraokeNew].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKaraokeNew] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKaraokeNew] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKaraokeNew] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyKaraokeNew', N'ON'
GO
ALTER DATABASE [QuanLyKaraokeNew] SET QUERY_STORE = OFF
GO
USE [QuanLyKaraokeNew]
GO
/****** Object:  Table [dbo].[DAT_PHONG]    Script Date: 1/6/2025 10:13:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAT_PHONG](
	[IDDatPhong] [int] IDENTITY(1,1) NOT NULL,
	[IDKhachHang] [int] NOT NULL,
	[IDPhong] [int] NOT NULL,
	[ThoiGianVao] [datetime] NOT NULL,
	[ThoiGianRa] [datetime] NULL,
	[TienPhong] [int] NOT NULL,
 CONSTRAINT [PK_DAT_PHONG] PRIMARY KEY CLUSTERED 
(
	[IDDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 1/6/2025 10:13:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[IDHoaDon] [varchar](50) NOT NULL,
	[IDKhachHang] [int] NOT NULL,
	[IDDatPhong] [int] NOT NULL,
	[NgayGioTao] [datetime] NOT NULL,
	[GhiChu] [nvarchar](255) NULL,
	[TongCong] [int] NOT NULL,
	[GiamGia] [int] NOT NULL,
	[Tong] [int] NOT NULL,
	[TrangThai] [tinyint] NOT NULL,
	[PhuThu] [int] NOT NULL,
 CONSTRAINT [PK_HOA_DON] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON_SAN_PHAM]    Script Date: 1/6/2025 10:13:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON_SAN_PHAM](
	[IDHoaDon] [varchar](50) NOT NULL,
	[IDSanPham] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[IDPhong] [int] NULL,
 CONSTRAINT [PK_HOA_DON_SAN_PHAM] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 1/6/2025 10:13:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[IDKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
 CONSTRAINT [PK_KHACH_HANG] PRIMARY KEY CLUSTERED 
(
	[IDKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAI_PHONG]    Script Date: 1/6/2025 10:13:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI_PHONG](
	[IDLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NOT NULL,
	[Gia] [int] NOT NULL,
 CONSTRAINT [PK_LOAI_PHONG] PRIMARY KEY CLUSTERED 
(
	[IDLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 1/6/2025 10:13:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[IDPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](50) NOT NULL,
	[IDLoaiPhong] [int] NOT NULL,
	[TrangThai] [tinyint] NOT NULL,
	[HienDung] [tinyint] NOT NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[IDPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PLAYLIST]    Script Date: 1/6/2025 10:13:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PLAYLIST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Names] [nvarchar](255) NOT NULL,
	[FilePath] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SAN_PHAM]    Script Date: 1/6/2025 10:13:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SAN_PHAM](
	[IDSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](255) NULL,
	[DonGia] [int] NOT NULL,
	[HienDung] [tinyint] NOT NULL,
 CONSTRAINT [PK_SAN_PHAM] PRIMARY KEY CLUSTERED 
(
	[IDSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONG_TIN_QUAN]    Script Date: 1/6/2025 10:13:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONG_TIN_QUAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenQuan] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_THONG_TIN_QUAN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DAT_PHONG] ON 
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (14, 1, 7, CAST(N'2024-12-22T14:49:09.037' AS DateTime), CAST(N'2024-12-25T22:57:33.203' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (15, 1, 2, CAST(N'2024-12-22T14:49:20.950' AS DateTime), CAST(N'2024-12-25T22:34:31.470' AS DateTime), 11580000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (16, 1, 4, CAST(N'2024-12-22T14:50:09.993' AS DateTime), CAST(N'2024-12-23T15:38:48.647' AS DateTime), 11460000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (17, 1, 3, CAST(N'2024-12-22T15:16:03.473' AS DateTime), CAST(N'2024-12-24T00:52:46.297' AS DateTime), 12600000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (18, 1, 4, CAST(N'2024-12-22T15:21:47.550' AS DateTime), CAST(N'2024-12-24T01:02:15.047' AS DateTime), 2040000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (19, 1, 6, CAST(N'2024-12-22T17:54:39.070' AS DateTime), CAST(N'2024-12-25T22:48:12.123' AS DateTime), 2560000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (20, 1, 5, CAST(N'2024-12-23T01:28:37.543' AS DateTime), CAST(N'2024-12-23T23:28:49.843' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (21, 1, 2, CAST(N'2024-12-23T01:34:08.603' AS DateTime), CAST(N'2024-12-26T00:39:52.810' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (22, 1, 2, CAST(N'2024-12-23T01:43:23.933' AS DateTime), CAST(N'2024-12-26T00:55:53.813' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (23, 1, 2, CAST(N'2024-12-23T12:39:11.960' AS DateTime), CAST(N'2024-12-26T01:01:40.590' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (24, 1, 3, CAST(N'2024-12-23T12:45:13.143' AS DateTime), CAST(N'2024-12-24T03:01:39.417' AS DateTime), 900000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (25, 1, 4, CAST(N'2024-12-23T12:53:08.227' AS DateTime), CAST(N'2024-12-24T02:48:29.373' AS DateTime), 840000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (26, 1, 5, CAST(N'2024-12-23T23:29:11.080' AS DateTime), CAST(N'2024-12-24T02:48:32.427' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (27, 1, 3, CAST(N'2024-12-24T00:52:10.967' AS DateTime), CAST(N'2024-12-24T03:10:47.103' AS DateTime), 180000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (29, 1, 6, CAST(N'2024-12-24T01:02:02.963' AS DateTime), CAST(N'2024-12-25T22:57:36.080' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (30, 1, 4, CAST(N'2024-12-24T02:11:19.157' AS DateTime), CAST(N'2024-12-24T03:08:15.423' AS DateTime), 60000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (31, 1, 4, CAST(N'2024-12-24T02:48:34.963' AS DateTime), CAST(N'2024-12-26T00:39:46.780' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (32, 1, 4, CAST(N'2024-12-24T02:48:52.943' AS DateTime), CAST(N'2024-12-26T08:25:52.580' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (33, 1, 3, CAST(N'2024-12-24T03:01:19.380' AS DateTime), CAST(N'2024-12-26T21:41:39.347' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (34, 1, 3, CAST(N'2024-12-24T03:02:08.197' AS DateTime), CAST(N'2024-12-26T23:50:24.060' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (35, 1, 5, CAST(N'2024-12-24T03:04:45.117' AS DateTime), CAST(N'2024-12-24T03:08:19.780' AS DateTime), 60000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (36, 1, 2, CAST(N'2024-12-24T03:05:13.643' AS DateTime), CAST(N'2024-12-26T01:02:05.407' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (37, 1, 10, CAST(N'2024-12-24T03:05:51.703' AS DateTime), CAST(N'2024-12-25T22:48:02.757' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (38, 1, 1, CAST(N'2024-12-24T03:07:31.180' AS DateTime), CAST(N'2024-12-25T22:48:08.343' AS DateTime), 13920000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (39, 1, 1, CAST(N'2024-12-25T22:48:15.280' AS DateTime), CAST(N'2024-12-26T00:39:56.007' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (40, 1, 6, CAST(N'2024-12-25T22:57:07.217' AS DateTime), CAST(N'2024-12-25T23:53:13.887' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (41, 1, 6, CAST(N'2024-12-25T22:57:38.373' AS DateTime), CAST(N'2024-12-25T23:55:27.403' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (42, 1, 4, CAST(N'2024-12-25T22:57:54.093' AS DateTime), CAST(N'2024-12-26T08:31:55.393' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (43, 1, 6, CAST(N'2024-12-25T23:53:17.110' AS DateTime), CAST(N'2024-12-26T00:40:32.957' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (44, 1, 5, CAST(N'2024-12-25T23:55:30.107' AS DateTime), CAST(N'2024-12-26T00:39:49.147' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (45, 1, 2, CAST(N'2024-12-26T00:23:16.487' AS DateTime), CAST(N'2024-12-26T22:57:41.320' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (46, 1, 1, CAST(N'2024-12-26T00:40:01.250' AS DateTime), CAST(N'2024-12-26T00:40:30.693' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (47, 1, 6, CAST(N'2024-12-26T00:40:20.027' AS DateTime), CAST(N'2024-12-26T08:32:41.133' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (48, 1, 2, CAST(N'2024-12-26T00:40:38.353' AS DateTime), CAST(N'2024-12-29T01:52:09.373' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (49, 1, 2, CAST(N'2024-12-26T00:56:10.620' AS DateTime), CAST(N'2024-12-29T03:10:02.923' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (51, 1, 2, CAST(N'2024-12-26T01:02:09.280' AS DateTime), CAST(N'2024-12-29T03:10:09.423' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (52, 1, 4, CAST(N'2024-12-26T07:55:18.210' AS DateTime), CAST(N'2024-12-26T08:32:19.530' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (53, 1, 4, CAST(N'2024-12-26T08:25:56.113' AS DateTime), CAST(N'2024-12-26T08:32:50.603' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (54, 1, 1, CAST(N'2024-12-26T08:26:05.103' AS DateTime), CAST(N'2024-12-26T08:30:06.187' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (55, 1, 1, CAST(N'2024-12-26T08:30:08.823' AS DateTime), CAST(N'2024-12-26T08:32:25.960' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (56, 1, 3, CAST(N'2024-12-26T08:30:14.830' AS DateTime), CAST(N'2024-12-27T19:43:08.367' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (57, 1, 5, CAST(N'2024-12-26T08:30:20.083' AS DateTime), CAST(N'2024-12-26T08:31:46.250' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (58, 1, 5, CAST(N'2024-12-26T08:31:50.370' AS DateTime), CAST(N'2024-12-26T08:32:48.427' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (59, 1, 4, CAST(N'2024-12-26T08:31:58.273' AS DateTime), CAST(N'2024-12-27T19:32:16.963' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (75, 3, 2, CAST(N'2024-12-27T18:53:39.707' AS DateTime), CAST(N'2024-12-29T03:10:28.733' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (76, 2, 10, CAST(N'2024-12-27T18:56:07.250' AS DateTime), CAST(N'2024-12-27T19:34:08.527' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (77, 1, 2, CAST(N'2024-12-27T19:03:04.177' AS DateTime), CAST(N'2024-12-29T03:13:29.323' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (78, 1, 3, CAST(N'2024-12-27T19:11:54.063' AS DateTime), CAST(N'2024-12-29T00:50:39.897' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (79, 1, 4, CAST(N'2024-12-27T19:14:14.787' AS DateTime), CAST(N'2024-12-27T19:32:46.517' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (80, 1, 5, CAST(N'2024-12-27T19:15:45.067' AS DateTime), CAST(N'2024-12-27T19:28:31.290' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (81, 1, 4, CAST(N'2024-12-27T19:32:42.007' AS DateTime), CAST(N'2024-12-27T19:33:14.363' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (82, 1, 4, CAST(N'2024-12-27T19:33:11.043' AS DateTime), CAST(N'2024-12-27T19:34:30.573' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (83, 1, 10, CAST(N'2024-12-27T19:33:17.857' AS DateTime), CAST(N'2024-12-27T19:34:25.323' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (84, 1, 10, CAST(N'2024-12-27T19:34:21.813' AS DateTime), NULL, 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (85, 1, 4, CAST(N'2024-12-27T19:34:27.927' AS DateTime), CAST(N'2024-12-27T19:42:13.410' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (86, 1, 4, CAST(N'2024-12-27T19:39:00.400' AS DateTime), CAST(N'2024-12-29T02:23:50.743' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (87, 3, 4, CAST(N'2024-12-27T19:43:00.847' AS DateTime), CAST(N'2024-12-29T02:24:21.567' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (88, 3, 3, CAST(N'2024-12-27T19:51:34.713' AS DateTime), CAST(N'2024-12-29T00:52:54.440' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (89, 3, 3, CAST(N'2024-12-27T19:52:11.920' AS DateTime), CAST(N'2024-12-29T00:53:00.613' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (90, 1, 7, CAST(N'2024-12-27T19:55:21.703' AS DateTime), CAST(N'2024-12-27T19:55:24.910' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (91, 1, 8, CAST(N'2024-12-27T19:55:31.847' AS DateTime), CAST(N'2024-12-29T00:46:54.350' AS DateTime), 1740000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (92, 1, 3, CAST(N'2024-12-29T00:49:52.877' AS DateTime), CAST(N'2024-12-29T00:58:49.870' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (93, 1, 3, CAST(N'2024-12-29T00:52:37.830' AS DateTime), CAST(N'2024-12-29T01:01:52.770' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (94, 1, 3, CAST(N'2024-12-29T00:58:32.317' AS DateTime), CAST(N'2024-12-29T01:02:11.017' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (95, 1, 3, CAST(N'2024-12-29T01:01:27.503' AS DateTime), CAST(N'2024-12-29T01:40:09.143' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (96, 1, 3, CAST(N'2024-12-29T01:01:56.057' AS DateTime), CAST(N'2024-12-29T01:40:15.007' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (97, 1, 3, CAST(N'2024-12-29T01:05:42.847' AS DateTime), CAST(N'2024-12-30T12:34:23.770' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (98, 1, 1, CAST(N'2024-12-29T01:24:56.583' AS DateTime), CAST(N'2024-12-29T01:25:15.773' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (99, 1, 3, CAST(N'2024-12-29T01:51:58.427' AS DateTime), CAST(N'2024-12-30T13:17:15.683' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (100, 1, 4, CAST(N'2024-12-29T02:23:29.990' AS DateTime), CAST(N'2024-12-29T02:24:37.293' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (101, 1, 4, CAST(N'2024-12-29T02:23:55.960' AS DateTime), CAST(N'2024-12-30T12:32:19.947' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (102, 1, 5, CAST(N'2024-12-29T02:24:04.910' AS DateTime), CAST(N'2024-12-29T02:24:23.837' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (103, 1, 6, CAST(N'2024-12-29T02:24:08.233' AS DateTime), CAST(N'2024-12-29T02:24:26.123' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (104, 1, 7, CAST(N'2024-12-29T02:24:10.977' AS DateTime), CAST(N'2024-12-29T02:24:28.627' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (105, 1, 8, CAST(N'2024-12-29T02:24:13.523' AS DateTime), CAST(N'2024-12-29T02:24:31.080' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (106, 1, 1, CAST(N'2024-12-29T02:24:16.513' AS DateTime), CAST(N'2024-12-29T02:24:19.117' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (107, 1, 4, CAST(N'2024-12-29T02:24:34.430' AS DateTime), CAST(N'2024-12-30T12:33:21.053' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (108, 1, 1, CAST(N'2024-12-29T03:09:51.750' AS DateTime), CAST(N'2024-12-30T16:02:34.830' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (109, 1, 3, CAST(N'2024-12-29T03:10:05.187' AS DateTime), CAST(N'2025-01-06T22:03:09.777' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (110, 1, 2, CAST(N'2024-12-29T03:10:22.197' AS DateTime), CAST(N'2024-12-31T08:14:31.913' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (111, 1, 2, CAST(N'2024-12-29T03:13:03.190' AS DateTime), NULL, 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (112, 1, 2, CAST(N'2024-12-29T03:14:56.640' AS DateTime), NULL, 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (113, 2, 4, CAST(N'2024-12-30T12:32:07.927' AS DateTime), CAST(N'2024-12-30T12:33:57.787' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (114, 2, 4, CAST(N'2024-12-30T12:32:26.513' AS DateTime), CAST(N'2024-12-30T12:34:09.613' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (115, 3, 4, CAST(N'2024-12-30T12:33:30.613' AS DateTime), CAST(N'2024-12-30T13:01:36.727' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (116, 2, 4, CAST(N'2024-12-30T12:34:03.540' AS DateTime), CAST(N'2024-12-30T13:03:01.943' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (117, 2, 3, CAST(N'2024-12-30T13:00:29.100' AS DateTime), CAST(N'2024-12-30T14:20:55.553' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (118, 2, 4, CAST(N'2024-12-30T13:00:47.597' AS DateTime), CAST(N'2024-12-30T14:17:57.560' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (119, 1, 4, CAST(N'2024-12-30T13:02:21.873' AS DateTime), CAST(N'2024-12-30T14:18:52.803' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (120, 4, 3, CAST(N'2024-12-30T14:15:03.573' AS DateTime), CAST(N'2024-12-30T14:21:16.710' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (121, 2, 4, CAST(N'2024-12-30T14:17:46.097' AS DateTime), CAST(N'2025-01-06T22:09:55.417' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (122, 4, 4, CAST(N'2024-12-30T14:18:13.537' AS DateTime), CAST(N'2025-01-06T22:11:11.987' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (123, 4, 5, CAST(N'2024-12-30T14:18:25.030' AS DateTime), CAST(N'2024-12-30T14:20:50.350' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (124, 1, 3, CAST(N'2024-12-30T14:21:11.583' AS DateTime), CAST(N'2024-12-30T15:02:50.903' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (125, 2, 11, CAST(N'2024-12-30T14:21:23.687' AS DateTime), CAST(N'2024-12-30T14:21:35.380' AS DateTime), 120000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (126, 2, 1, CAST(N'2024-12-30T14:23:09.587' AS DateTime), CAST(N'2024-12-30T14:23:13.840' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (127, 1, 3, CAST(N'2024-12-30T15:02:43.797' AS DateTime), CAST(N'2024-12-30T15:10:00.123' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (128, 5, 3, CAST(N'2024-12-30T15:09:45.110' AS DateTime), CAST(N'2024-12-30T15:59:01.600' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (129, 5, 11, CAST(N'2024-12-30T15:32:56.630' AS DateTime), CAST(N'2024-12-30T15:33:00.797' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (130, 2, 3, CAST(N'2024-12-30T15:58:03.390' AS DateTime), CAST(N'2025-01-06T22:09:49.047' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (131, 2, 12, CAST(N'2024-12-30T16:02:29.867' AS DateTime), CAST(N'2024-12-30T16:03:54.943' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (132, 2, 1, CAST(N'2024-12-30T16:02:42.287' AS DateTime), CAST(N'2024-12-30T16:06:05.530' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (133, 5, 2, CAST(N'2024-12-30T16:04:42.337' AS DateTime), NULL, 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (134, 5, 12, CAST(N'2024-12-30T16:05:32.247' AS DateTime), CAST(N'2025-01-06T22:10:04.947' AS DateTime), 1020000)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (135, 5, 5, CAST(N'2024-12-30T16:06:01.820' AS DateTime), CAST(N'2024-12-31T08:11:12.130' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (136, 5, 1, CAST(N'2024-12-30T16:06:10.203' AS DateTime), CAST(N'2025-01-06T22:02:21.780' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (137, 5, 2, CAST(N'2024-12-30T16:06:32.497' AS DateTime), NULL, 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (138, 5, 4, CAST(N'2024-12-30T16:06:41.210' AS DateTime), NULL, 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (139, 5, 6, CAST(N'2024-12-30T16:06:45.313' AS DateTime), CAST(N'2024-12-31T08:11:08.780' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (140, 5, 5, CAST(N'2024-12-31T08:12:23.827' AS DateTime), CAST(N'2024-12-31T08:12:36.457' AS DateTime), 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (141, 2, 1, CAST(N'2025-01-06T22:02:35.890' AS DateTime), NULL, 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (142, 5, 3, CAST(N'2025-01-06T22:03:22.330' AS DateTime), NULL, 0)
GO
INSERT [dbo].[DAT_PHONG] ([IDDatPhong], [IDKhachHang], [IDPhong], [ThoiGianVao], [ThoiGianRa], [TienPhong]) VALUES (143, 5, 4, CAST(N'2025-01-06T22:10:54.947' AS DateTime), NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[DAT_PHONG] OFF
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'67265811-125c-4747-9772-c10ad2030b29', 1, 91, CAST(N'2024-12-29T00:32:57.717' AS DateTime), NULL, 1830000, 0, 1830000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'd2be1457-44e1-4ae6-97de-03e358ce8142', 1, 92, CAST(N'2024-12-29T00:58:49.867' AS DateTime), NULL, 69000, 0, 69000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON1993', 2, 119, CAST(N'2024-12-30T14:18:52.800' AS DateTime), NULL, 362000, 0, 362000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON2009', 1, 16, CAST(N'2024-12-30T13:02:40.653' AS DateTime), N'Hóa đơn mới', 210000, 0, 210000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON2040', 1, 91, CAST(N'2024-12-29T00:32:26.613' AS DateTime), N'Hóa đơn mới', 90000, 0, 90000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON2065', 1, 121, CAST(N'2025-01-06T22:09:55.413' AS DateTime), NULL, 10838000, 0, 10838000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON2989', 2, 75, CAST(N'2024-12-29T03:10:28.733' AS DateTime), NULL, 1937000, 0, 1937000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON3187', 2, 15, CAST(N'2024-12-26T00:23:25.797' AS DateTime), N'Hóa đơn mới', 30000, 0, 30000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON3212', 1, 15, CAST(N'2024-12-30T15:06:09.133' AS DateTime), N'Hóa đơn mới', 80000, 0, 80000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON3221', 4, 15, CAST(N'2024-12-26T01:02:00.773' AS DateTime), N'Hóa đơn mới', 60000, 0, 60000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON3233', 5, 134, CAST(N'2024-12-31T08:29:54.977' AS DateTime), N'Hóa đơn mới', 30000, 0, 30000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON3484', 1, 38, CAST(N'2024-12-31T08:28:35.417' AS DateTime), N'Hóa đơn mới', 36000, 0, 36000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON3777', 1, 88, CAST(N'2024-12-29T00:52:54.440' AS DateTime), NULL, 1860000, 0, 1860000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON3837', 1, 17, CAST(N'2024-12-29T00:50:11.760' AS DateTime), N'Hóa đơn mới', 60000, 0, 60000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON3972', 4, 91, CAST(N'2024-12-29T00:46:54.330' AS DateTime), NULL, 1830000, 0, 1830000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON4183', 1, 116, CAST(N'2024-12-30T13:03:01.943' AS DateTime), NULL, 314000, 0, 314000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON4630', 1, 17, CAST(N'2024-12-29T01:39:58.880' AS DateTime), N'Hóa đơn mới', 90000, 0, 90000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON4677', 1, 78, CAST(N'2024-12-29T00:50:39.897' AS DateTime), NULL, 1860000, 0, 1860000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON4728', 2, 125, CAST(N'2024-12-30T15:58:31.827' AS DateTime), N'Hóa đơn mới', 30000, 0, 30000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON4763', 1, 15, CAST(N'2024-12-29T00:59:12.027' AS DateTime), N'Hóa đơn mới', 90000, 0, 90000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON4837', 2, 118, CAST(N'2024-12-30T14:17:57.557' AS DateTime), NULL, 363000, 0, 363000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON5472', 1, 109, CAST(N'2025-01-06T22:03:09.777' AS DateTime), NULL, 12744000, 0, 12744000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON5612', 4, 115, CAST(N'2024-12-30T13:01:36.723' AS DateTime), NULL, 104000, 0, 104000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON5763', 1, 122, CAST(N'2025-01-06T22:11:11.983' AS DateTime), NULL, 10838000, 0, 10838000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON6178', 1, 17, CAST(N'2024-12-31T08:28:21.097' AS DateTime), N'Hóa đơn mới', 90000, 0, 90000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON6445', 1, 16, CAST(N'2024-12-30T13:00:59.820' AS DateTime), N'Hóa đơn mới', 75000, 0, 75000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON6493', 2, 131, CAST(N'2024-12-30T16:03:54.940' AS DateTime), NULL, 1999, 0, 1999, 1, 666)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON6688', 5, 134, CAST(N'2024-12-30T16:05:38.997' AS DateTime), N'Hóa đơn mới', 15000, 0, 15000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON7048', 1, 110, CAST(N'2024-12-31T08:14:31.910' AS DateTime), NULL, 4896000, 979200, 3916800, 1, 1632000)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON7206', 1, 89, CAST(N'2024-12-29T00:53:00.613' AS DateTime), NULL, 0, 0, 0, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON7220', 2, 134, CAST(N'2025-01-06T22:10:04.943' AS DateTime), NULL, 13923185, 0, 13923185, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON7305', 1, 97, CAST(N'2024-12-30T12:34:23.767' AS DateTime), NULL, 2219000, 0, 2219000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON7377', 1, 136, CAST(N'2025-01-06T22:02:21.760' AS DateTime), NULL, 14645947, 0, 14645947, 1, 697426)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON7423', 3, 16, CAST(N'2024-12-25T23:45:50.493' AS DateTime), N'Hóa đơn mới', 30000, 0, 30000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON7717', 1, 17, CAST(N'2024-12-26T23:48:13.530' AS DateTime), N'Hóa đơn mới', 60000, 0, 60000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON8006', 2, 96, CAST(N'2024-12-29T01:40:15.007' AS DateTime), NULL, 0, 0, 0, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON8495', 1, 86, CAST(N'2024-12-29T02:23:50.740' AS DateTime), NULL, 1845000, 0, 1845000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON8879', 2, 20, CAST(N'2024-12-25T23:55:38.970' AS DateTime), N'Hóa đơn mới', 60000, 0, 60000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON8919', 1, 130, CAST(N'2025-01-06T22:09:49.027' AS DateTime), NULL, 10542000, 0, 10542000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'HOADON9497', 1, 95, CAST(N'2024-12-29T01:40:09.143' AS DateTime), NULL, 129000, 0, 129000, 1, 0)
GO
INSERT [dbo].[HOA_DON] ([IDHoaDon], [IDKhachHang], [IDDatPhong], [NgayGioTao], [GhiChu], [TongCong], [GiamGia], [Tong], [TrangThai], [PhuThu]) VALUES (N'STAR-7606', 1, 38, CAST(N'2024-12-25T22:49:35.197' AS DateTime), N'Hóa đơn mới', 30000, 0, 30000, 1, 0)
GO
INSERT [dbo].[HOA_DON_SAN_PHAM] ([IDHoaDon], [IDSanPham], [SoLuong], [ThanhTien], [IDPhong]) VALUES (N'HOADON2009', 7, 14, 210000, 4)
GO
INSERT [dbo].[HOA_DON_SAN_PHAM] ([IDHoaDon], [IDSanPham], [SoLuong], [ThanhTien], [IDPhong]) VALUES (N'HOADON3212', 10, 5, 80000, 2)
GO
INSERT [dbo].[HOA_DON_SAN_PHAM] ([IDHoaDon], [IDSanPham], [SoLuong], [ThanhTien], [IDPhong]) VALUES (N'HOADON3233', 8, 2, 30000, 13)
GO
INSERT [dbo].[HOA_DON_SAN_PHAM] ([IDHoaDon], [IDSanPham], [SoLuong], [ThanhTien], [IDPhong]) VALUES (N'HOADON3484', 6, 3, 36000, 1)
GO
INSERT [dbo].[HOA_DON_SAN_PHAM] ([IDHoaDon], [IDSanPham], [SoLuong], [ThanhTien], [IDPhong]) VALUES (N'HOADON4728', 1, 1, 30000, 11)
GO
INSERT [dbo].[HOA_DON_SAN_PHAM] ([IDHoaDon], [IDSanPham], [SoLuong], [ThanhTien], [IDPhong]) VALUES (N'HOADON6178', 4, 3, 90000, 3)
GO
INSERT [dbo].[HOA_DON_SAN_PHAM] ([IDHoaDon], [IDSanPham], [SoLuong], [ThanhTien], [IDPhong]) VALUES (N'HOADON6445', 8, 5, 75000, 4)
GO
INSERT [dbo].[HOA_DON_SAN_PHAM] ([IDHoaDon], [IDSanPham], [SoLuong], [ThanhTien], [IDPhong]) VALUES (N'HOADON6688', 5, 1, 15000, 13)
GO
SET IDENTITY_INSERT [dbo].[KHACH_HANG] ON 
GO
INSERT [dbo].[KHACH_HANG] ([IDKhachHang], [HoTen], [SDT], [DiaChi]) VALUES (1, N'NhanLe', N'0285082309', N'ngo A1')
GO
INSERT [dbo].[KHACH_HANG] ([IDKhachHang], [HoTen], [SDT], [DiaChi]) VALUES (2, N'Lê Thành Nhân', N'13758091', N'222222222')
GO
INSERT [dbo].[KHACH_HANG] ([IDKhachHang], [HoTen], [SDT], [DiaChi]) VALUES (3, N'Nhân', N'1234567889', N'nhà')
GO
INSERT [dbo].[KHACH_HANG] ([IDKhachHang], [HoTen], [SDT], [DiaChi]) VALUES (4, N'Tan', N'1241241124', N'aaaa')
GO
INSERT [dbo].[KHACH_HANG] ([IDKhachHang], [HoTen], [SDT], [DiaChi]) VALUES (5, N'Hieu', N'124124124', N'aaaa')
GO
SET IDENTITY_INSERT [dbo].[KHACH_HANG] OFF
GO
SET IDENTITY_INSERT [dbo].[LOAI_PHONG] ON 
GO
INSERT [dbo].[LOAI_PHONG] ([IDLoaiPhong], [TenLoaiPhong], [Gia]) VALUES (1, N'Thường', 60000)
GO
INSERT [dbo].[LOAI_PHONG] ([IDLoaiPhong], [TenLoaiPhong], [Gia]) VALUES (2, N'Vip', 80000)
GO
SET IDENTITY_INSERT [dbo].[LOAI_PHONG] OFF
GO
SET IDENTITY_INSERT [dbo].[PHONG] ON 
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (1, N'P101', 2, 1, 1)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (2, N'P102', 1, 1, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (3, N'P103', 1, 1, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (4, N'P104', 1, 1, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (5, N'P105', 1, 1, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (6, N'P201', 2, 1, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (7, N'P202', 2, 1, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (8, N'P203', 1, 1, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (9, N'P204', 1, 1, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (10, N'P205', 1, 1, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (11, N'P206', 1, 0, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (12, N'P207', 2, 0, 0)
GO
INSERT [dbo].[PHONG] ([IDPhong], [TenPhong], [IDLoaiPhong], [TrangThai], [HienDung]) VALUES (13, N'P208', 1, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[PHONG] OFF
GO
SET IDENTITY_INSERT [dbo].[PLAYLIST] ON 
GO
INSERT [dbo].[PLAYLIST] ([ID], [Names], [FilePath]) VALUES (7, N'Thien Ly Oi', N'C:\Users\Admin\Downloads\QUANLY_KARAOKE_PROJECT-20241221T131309Z-001\nhạc\Thien Ly Oi.mp3')
GO
INSERT [dbo].[PLAYLIST] ([ID], [Names], [FilePath]) VALUES (8, N'Mong You', N'C:\Users\Admin\Downloads\QUANLY_KARAOKE_PROJECT-20241221T131309Z-001\nhạc\Mong You.mp3')
GO
INSERT [dbo].[PLAYLIST] ([ID], [Names], [FilePath]) VALUES (9, N'Trai Dat Om Mat Troi', N'C:\Users\Admin\Downloads\QUANLY_KARAOKE_PROJECT-20241221T131309Z-001\nhạc\Trai Dat Om Mat Troi.mp3')
GO
INSERT [dbo].[PLAYLIST] ([ID], [Names], [FilePath]) VALUES (11, N'Về Miền Tây', N'C:\Users\Admin\Downloads\QUANLY_KARAOKE_PROJECT-20241221T131309Z-001\nhạc\Về Miền Tây.mp3')
GO
SET IDENTITY_INSERT [dbo].[PLAYLIST] OFF
GO
SET IDENTITY_INSERT [dbo].[SAN_PHAM] ON 
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (1, N'Trái cây dĩa', NULL, 30000, 1)
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (2, N'Bánh Ngọt', NULL, 20000, 0)
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (3, N'Bánh snack ', N'Túi', 10000, 1)
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (4, N'Bò Khô', NULL, 30000, 1)
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (5, N'Pepsi', N'Nước ngọt', 15000, 1)
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (6, N'Nước Suối', NULL, 12000, 1)
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (7, N'Nước cam', N'chai', 15000, 1)
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (8, N'Bia Tiger', N'Lon', 15000, 1)
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (9, N'Bia Sài Gòn', N'Lon', 12000, 0)
GO
INSERT [dbo].[SAN_PHAM] ([IDSanPham], [TenSanPham], [MoTa], [DonGia], [HienDung]) VALUES (10, N'Bia Heniken', N'Lon', 16000, 1)
GO
SET IDENTITY_INSERT [dbo].[SAN_PHAM] OFF
GO
SET IDENTITY_INSERT [dbo].[THONG_TIN_QUAN] ON 
GO
INSERT [dbo].[THONG_TIN_QUAN] ([ID], [TenQuan], [DiaChi], [SDT]) VALUES (1, N'KaraokeHiHi', N'Ngõ A Hẻm B', N'50813958')
GO
SET IDENTITY_INSERT [dbo].[THONG_TIN_QUAN] OFF
GO
ALTER TABLE [dbo].[HOA_DON] ADD  DEFAULT ((0)) FOR [GiamGia]
GO
ALTER TABLE [dbo].[HOA_DON] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[HOA_DON] ADD  DEFAULT ((0)) FOR [PhuThu]
GO
ALTER TABLE [dbo].[PHONG] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[PHONG] ADD  DEFAULT ((0)) FOR [HienDung]
GO
ALTER TABLE [dbo].[SAN_PHAM] ADD  DEFAULT ((1)) FOR [HienDung]
GO
ALTER TABLE [dbo].[DAT_PHONG]  WITH CHECK ADD  CONSTRAINT [FK_DAT_PHONG_KHACH_HANG] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[KHACH_HANG] ([IDKhachHang])
GO
ALTER TABLE [dbo].[DAT_PHONG] CHECK CONSTRAINT [FK_DAT_PHONG_KHACH_HANG]
GO
ALTER TABLE [dbo].[DAT_PHONG]  WITH CHECK ADD  CONSTRAINT [FK_DAT_PHONG_PHONG] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[PHONG] ([IDPhong])
GO
ALTER TABLE [dbo].[DAT_PHONG] CHECK CONSTRAINT [FK_DAT_PHONG_PHONG]
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
ALTER TABLE [dbo].[HOA_DON_SAN_PHAM]  WITH CHECK ADD  CONSTRAINT [FK_IDPhongHDSP] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[PHONG] ([IDPhong])
GO
ALTER TABLE [dbo].[HOA_DON_SAN_PHAM] CHECK CONSTRAINT [FK_IDPhongHDSP]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAI_PHONG] FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[LOAI_PHONG] ([IDLoaiPhong])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAI_PHONG]
GO
ALTER TABLE [dbo].[HOA_DON_SAN_PHAM]  WITH CHECK ADD CHECK  (([SoLuong]>(0)))
GO
ALTER TABLE [dbo].[LOAI_PHONG]  WITH CHECK ADD CHECK  (([Gia]>(0)))
GO
ALTER TABLE [dbo].[SAN_PHAM]  WITH CHECK ADD CHECK  (([DonGia]>(0)))
GO
USE [master]
GO
ALTER DATABASE [QuanLyKaraokeNew] SET  READ_WRITE 
GO
