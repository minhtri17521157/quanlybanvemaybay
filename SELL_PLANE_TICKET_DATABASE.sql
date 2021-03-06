USE [master]
GO
/****** Object:  Database [SELL_PLANE_TICKET_DATABASE]    Script Date: 5/4/2020 9:20:22 PM ******/
CREATE DATABASE [SELL_PLANE_TICKET_DATABASE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SELL_PLANE_TICKET_DATABASE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SELL_PLANE_TICKET_DATABASE.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SELL_PLANE_TICKET_DATABASE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SELL_PLANE_TICKET_DATABASE_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SELL_PLANE_TICKET_DATABASE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET ARITHABORT OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET  MULTI_USER 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SELL_PLANE_TICKET_DATABASE]
GO
/****** Object:  Table [dbo].[CHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUYENBAY](
	[MACB] [varchar](10) NOT NULL,
	[MATB] [varchar](10) NULL,
	[NGAYGIO] [datetime] NULL,
	[THOIGIANBAY] [float] NULL,
	[MADG] [varchar](10) NULL,
	[MAHHK] [nvarchar](10) NULL,
 CONSTRAINT [PK_CB] PRIMARY KEY CLUSTERED 
(
	[MACB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTCHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTCHUYENBAY](
	[MACTCB] [varchar](10) NOT NULL,
	[MACB] [varchar](10) NULL,
	[MASANBAYTG] [varchar](10) NULL,
	[THOIGIANDUNG] [float] NULL,
	[GHICHU] [nvarchar](100) NULL,
 CONSTRAINT [PK_CTCB] PRIMARY KEY CLUSTERED 
(
	[MACTCB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTDOANHTHUTHANG]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTDOANHTHUTHANG](
	[THANG] [varchar](3) NOT NULL,
	[NAM] [varchar](5) NOT NULL,
	[MACHUYENBAY] [varchar](10) NOT NULL,
	[SOVEBANDUOC] [int] NULL,
	[DOANHTHU] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CTDTTHANG] PRIMARY KEY CLUSTERED 
(
	[THANG] ASC,
	[NAM] ASC,
	[MACHUYENBAY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOANHTHUNAM]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOANHTHUNAM](
	[NAM] [varchar](5) NOT NULL,
	[DOANHTHU] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DTNAM] PRIMARY KEY CLUSTERED 
(
	[NAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOANHTHUTHANG]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOANHTHUTHANG](
	[THANG] [varchar](3) NOT NULL,
	[NAM] [varchar](5) NOT NULL,
	[SOCHUYENBAY] [int] NULL,
	[DOANHTHU] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DTTHANG] PRIMARY KEY CLUSTERED 
(
	[THANG] ASC,
	[NAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DONGIA]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DONGIA](
	[MADG] [varchar](10) NOT NULL,
	[DONGIA] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DG] PRIMARY KEY CLUSTERED 
(
	[MADG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGHANGKHONG]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHANGKHONG](
	[MAHHK] [nvarchar](10) NOT NULL,
	[TENHHNK] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_HANGHANGKHONG] PRIMARY KEY CLUSTERED 
(
	[MAHHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGVE]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGVE](
	[MAHV] [varchar](10) NOT NULL,
	[TENHV] [nvarchar](20) NULL,
	[TYLE] [int] NULL,
	[TINHTRANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_HV] PRIMARY KEY CLUSTERED 
(
	[MAHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANHKHACH]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANHKHACH](
	[MAHK] [varchar](10) NOT NULL,
	[TENHK] [nvarchar](100) NULL,
	[CMND] [nvarchar](9) NULL,
	[SDT] [nvarchar](15) NULL,
 CONSTRAINT [PK_HK] PRIMARY KEY CLUSTERED 
(
	[MAHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANHLI]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANHLI](
	[MAHL] [nvarchar](10) NOT NULL,
	[MAHHK] [nvarchar](10) NOT NULL,
	[TENHL] [nvarchar](10) NULL,
	[GIA] [int] NULL,
 CONSTRAINT [PK_HANHLI] PRIMARY KEY CLUSTERED 
(
	[MAHL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[id_Nhan_Vien] [int] NOT NULL,
	[TenNhanVien] [nchar](50) NULL,
	[DiaChi] [nchar](100) NULL,
	[SoDienThoai] [nchar](15) NULL,
	[Email] [nchar](30) NULL,
	[CMND] [nchar](10) NULL,
	[UserName] [nchar](100) NULL,
	[PassWord] [nchar](50) NULL,
	[TrangThai] [bit] NULL,
	[Avatar] [nchar](100) NULL,
	[ChuThich] [text] NULL,
	[LOAI] [nvarchar](10) NULL,
	[PassWord2] [nchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[id_Nhan_Vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANBAY](
	[MASB] [varchar](10) NOT NULL,
	[TENSANBAY] [nvarchar](100) NULL,
	[TINHTRANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_SB] PRIMARY KEY CLUSTERED 
(
	[MASB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[TGBAYTOITHIEU] [float] NULL,
	[SOSBTRUNGGIANTOIDA] [int] NULL,
	[TGDUNGTOITHIEU] [float] NULL,
	[TGDUNGTOIDA] [float] NULL,
	[TGCHAMNHATDATVE] [int] NULL,
	[TGCHAMNHATHUYVE] [int] NULL,
	[SLHANGVE] [int] NULL,
	[SLSANBAYTOIDA] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TINHTRANGVE]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TINHTRANGVE](
	[MATTVE] [varchar](10) NOT NULL,
	[MACB] [varchar](10) NULL,
	[MAHV] [varchar](10) NULL,
	[SLGHE] [int] NULL,
	[SLGHETRONG] [int] NULL,
	[SLGHEDAT] [int] NULL,
 CONSTRAINT [PK_TTV] PRIMARY KEY CLUSTERED 
(
	[MATTVE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TUYENBAY](
	[MATB] [varchar](10) NOT NULL,
	[MASBDI] [varchar](10) NULL,
	[MASBDEN] [varchar](10) NULL,
 CONSTRAINT [PK_TB] PRIMARY KEY CLUSTERED 
(
	[MATB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VECHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VECHUYENBAY](
	[MAVE] [varchar](10) NOT NULL,
	[MACB] [varchar](10) NULL,
	[MAHV] [varchar](10) NULL,
	[MAHK] [varchar](10) NULL,
	[GIA] [decimal](18, 0) NULL,
	[NGAYGD] [date] NULL,
	[NGAYHUY] [date] NULL,
	[LOAIVE] [nvarchar](10) NULL,
	[MANHANVIEN] [int] NULL,
	[MAHL] [nvarchar](10) NULL,
 CONSTRAINT [PK_VCB] PRIMARY KEY CLUSTERED 
(
	[MAVE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0001', N'TB0001', CAST(0x0000AA8E00000000 AS DateTime), 60, N'DG0001', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0002', N'TB0002', CAST(0x0000AB1300000000 AS DateTime), 70, N'DG0001', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0003', N'TB0003', CAST(0x0000AB2900000000 AS DateTime), 80, N'DG0002', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0004', N'TB0001', CAST(0x0000AD7C00000000 AS DateTime), 90, N'DG0002', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0005', N'TB0001', CAST(0x0000AA8F001CCB18 AS DateTime), 90, N'DG0001', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0006', N'TB0001', CAST(0x0000AA91001EE178 AS DateTime), 33, N'DG0001', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0007', N'TB0003', CAST(0x0000AA820058BA74 AS DateTime), 60, N'DG0001', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0008', N'TB0001', CAST(0x0000AA7F00D1C8B0 AS DateTime), 80, N'DG0001', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0009', N'TB0005', CAST(0x0000AA9C0096DC50 AS DateTime), 75, N'DG0001', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0010', N'TB0001', CAST(0x0000AA8300D170CC AS DateTime), 40, N'DG0001', NULL)
INSERT [dbo].[CHUYENBAY] ([MACB], [MATB], [NGAYGIO], [THOIGIANBAY], [MADG], [MAHHK]) VALUES (N'CB0011', N'TB0001', CAST(0x0000AA8300D170CC AS DateTime), 30, N'DG0001', NULL)
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT1', N'CB0001', N'SB0003', 20, NULL)
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT10', N'CB0007', N'SB0006', 15, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT11', N'CB0008', N'SB0003', 13, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT12', N'CB0009', N'SB0004', 14, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT13', N'CB0011', N'SB0003', 69, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT2', N'CB0002', N'SB0004', 15, NULL)
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT3', N'CB0005', N'SB0003', 15, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT4', N'CB0005', N'SB0004', 12, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT5', N'CB0005', N'SB0005', 11, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT6', N'CB0006', N'SB0003', 20, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT7', N'CB0006', N'SB0004', 10, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT8', N'CB0006', N'SB0005', 18, N'')
INSERT [dbo].[CTCHUYENBAY] ([MACTCB], [MACB], [MASANBAYTG], [THOIGIANDUNG], [GHICHU]) VALUES (N'CT9', N'CB0006', N'SB0006', 17, N'')
INSERT [dbo].[CTDOANHTHUTHANG] ([THANG], [NAM], [MACHUYENBAY], [SOVEBANDUOC], [DOANHTHU]) VALUES (N'7', N'2019', N'CB0001', 1, CAST(525000 AS Decimal(18, 0)))
INSERT [dbo].[CTDOANHTHUTHANG] ([THANG], [NAM], [MACHUYENBAY], [SOVEBANDUOC], [DOANHTHU]) VALUES (N'7', N'2019', N'CB0006', 1, CAST(525000 AS Decimal(18, 0)))
INSERT [dbo].[DOANHTHUNAM] ([NAM], [DOANHTHU]) VALUES (N'2019', CAST(1050000 AS Decimal(18, 0)))
INSERT [dbo].[DOANHTHUTHANG] ([THANG], [NAM], [SOCHUYENBAY], [DOANHTHU]) VALUES (N'7', N'2019', 2, CAST(1050000 AS Decimal(18, 0)))
INSERT [dbo].[DONGIA] ([MADG], [DONGIA]) VALUES (N'DG0001', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[DONGIA] ([MADG], [DONGIA]) VALUES (N'DG0002', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[HANGVE] ([MAHV], [TENHV], [TYLE], [TINHTRANG]) VALUES (N'1', N'VIP', 105, N'Không khả dụng')
INSERT [dbo].[HANGVE] ([MAHV], [TENHV], [TYLE], [TINHTRANG]) VALUES (N'2', N'Thường', 100, N'Khả dụng')
INSERT [dbo].[HANHKHACH] ([MAHK], [TENHK], [CMND], [SDT]) VALUES (N'HK0000', N'Thức', N'1203213', N'090')
INSERT [dbo].[HANHKHACH] ([MAHK], [TENHK], [CMND], [SDT]) VALUES (N'HK0001', N'Minh', N'3331343', N'23')
INSERT [dbo].[HANHKHACH] ([MAHK], [TENHK], [CMND], [SDT]) VALUES (N'HK0013', N'Lê Phục Quân', N'69696969', N'113')
INSERT [dbo].[HANHKHACH] ([MAHK], [TENHK], [CMND], [SDT]) VALUES (N'HK0019', N'Đặng Vĩnh Siêu', N'22287576', N'692135')
INSERT [dbo].[HANHKHACH] ([MAHK], [TENHK], [CMND], [SDT]) VALUES (N'HK0020', N'Sieu', N'123123123', N'123123123')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0001', N'Tân Sơn Nhất', N'Không hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0002', N'Nội Bài', N'Hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0003', N'Đà Nẵng', N'Hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0004', N'Cần Thơ', N'Hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0005', N'Hải Phòng', N'Hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0006', N'Vinh', N'Hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0007', N'Quảng Ninh', N'Hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0008', N'Phú Quốc', N'Hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0009', N'Singapore', N'Hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0010', N'Cà Mau', N'Hoạt động')
INSERT [dbo].[SANBAY] ([MASB], [TENSANBAY], [TINHTRANG]) VALUES (N'SB0011', N'Tân Sơn Nhất', N'Không hoạt động')
INSERT [dbo].[THAMSO] ([TGBAYTOITHIEU], [SOSBTRUNGGIANTOIDA], [TGDUNGTOITHIEU], [TGDUNGTOIDA], [TGCHAMNHATDATVE], [TGCHAMNHATHUYVE], [SLHANGVE], [SLSANBAYTOIDA]) VALUES (30, 1, 10, 90, 1, 1, 2, 2)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'MTTV10', N'CB0006', N'1', 30, 29, 1)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'MTTV11', N'CB0007', N'1', 50, 50, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'MTTV12', N'CB0007', N'2', 100, 100, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'MTTV13', N'CB0008', N'1', 22, 22, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'MTTV14', N'CB0009', N'1', 70, 70, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'MTTV15', N'CB0010', N'1', 30, 30, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'MTTV16', N'CB0011', N'1', 17, 17, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'MTTV9', N'CB0005', N'1', 20, 20, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'TT0001', N'CB0001', N'1', 40, 39, 1)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'TT0002', N'CB0001', N'2', 50, 50, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'TT0003', N'CB0002', N'1', 50, 50, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'TT0004', N'CB0002', N'2', 60, 60, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'TT0005', N'CB0003', N'1', 30, 30, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'TT0006', N'CB0003', N'2', 70, 70, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'TT0007', N'CB0004', N'1', 40, 40, 0)
INSERT [dbo].[TINHTRANGVE] ([MATTVE], [MACB], [MAHV], [SLGHE], [SLGHETRONG], [SLGHEDAT]) VALUES (N'TT0008', N'CB0004', N'2', 80, 80, 0)
INSERT [dbo].[TUYENBAY] ([MATB], [MASBDI], [MASBDEN]) VALUES (N'TB0001', N'SB0001', N'SB0002')
INSERT [dbo].[TUYENBAY] ([MATB], [MASBDI], [MASBDEN]) VALUES (N'TB0002', N'SB0002', N'SB0001')
INSERT [dbo].[TUYENBAY] ([MATB], [MASBDI], [MASBDEN]) VALUES (N'TB0003', N'SB0001', N'SB0003')
INSERT [dbo].[TUYENBAY] ([MATB], [MASBDI], [MASBDEN]) VALUES (N'TB0004', N'SB0003', N'SB0001')
INSERT [dbo].[TUYENBAY] ([MATB], [MASBDI], [MASBDEN]) VALUES (N'TB0005', N'SB0009', N'SB0001')
INSERT [dbo].[VECHUYENBAY] ([MAVE], [MACB], [MAHV], [MAHK], [GIA], [NGAYGD], [NGAYHUY], [LOAIVE], [MANHANVIEN], [MAHL]) VALUES (N'VE0000', N'CB0006', N'1', N'HK0020', CAST(525000 AS Decimal(18, 0)), CAST(0xDA3F0B00 AS Date), NULL, N'Vé mua', NULL, NULL)
INSERT [dbo].[VECHUYENBAY] ([MAVE], [MACB], [MAHV], [MAHK], [GIA], [NGAYGD], [NGAYHUY], [LOAIVE], [MANHANVIEN], [MAHL]) VALUES (N'VE0001', N'CB0001', N'1', N'HK0013', CAST(525000 AS Decimal(18, 0)), CAST(0xDA3F0B00 AS Date), NULL, N'Vé mua', NULL, NULL)
ALTER TABLE [dbo].[CHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_CB_TB] FOREIGN KEY([MATB])
REFERENCES [dbo].[TUYENBAY] ([MATB])
GO
ALTER TABLE [dbo].[CHUYENBAY] CHECK CONSTRAINT [FK_CB_TB]
GO
ALTER TABLE [dbo].[CHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENBAY_DONGIA] FOREIGN KEY([MADG])
REFERENCES [dbo].[DONGIA] ([MADG])
GO
ALTER TABLE [dbo].[CHUYENBAY] CHECK CONSTRAINT [FK_CHUYENBAY_DONGIA]
GO
ALTER TABLE [dbo].[CHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENBAY_HANGHANGKHONG] FOREIGN KEY([MAHHK])
REFERENCES [dbo].[HANGHANGKHONG] ([MAHHK])
GO
ALTER TABLE [dbo].[CHUYENBAY] CHECK CONSTRAINT [FK_CHUYENBAY_HANGHANGKHONG]
GO
ALTER TABLE [dbo].[CTCHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_CTCB_CB] FOREIGN KEY([MACB])
REFERENCES [dbo].[CHUYENBAY] ([MACB])
GO
ALTER TABLE [dbo].[CTCHUYENBAY] CHECK CONSTRAINT [FK_CTCB_CB]
GO
ALTER TABLE [dbo].[CTCHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_CTCHUYENBAY_SB] FOREIGN KEY([MASANBAYTG])
REFERENCES [dbo].[SANBAY] ([MASB])
GO
ALTER TABLE [dbo].[CTCHUYENBAY] CHECK CONSTRAINT [FK_CTCHUYENBAY_SB]
GO
ALTER TABLE [dbo].[CTDOANHTHUTHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTDTT_CB] FOREIGN KEY([MACHUYENBAY])
REFERENCES [dbo].[CHUYENBAY] ([MACB])
GO
ALTER TABLE [dbo].[CTDOANHTHUTHANG] CHECK CONSTRAINT [FK_CTDTT_CB]
GO
ALTER TABLE [dbo].[TINHTRANGVE]  WITH CHECK ADD  CONSTRAINT [FK_TINHTRANGVE_HV] FOREIGN KEY([MAHV])
REFERENCES [dbo].[HANGVE] ([MAHV])
GO
ALTER TABLE [dbo].[TINHTRANGVE] CHECK CONSTRAINT [FK_TINHTRANGVE_HV]
GO
ALTER TABLE [dbo].[TINHTRANGVE]  WITH CHECK ADD  CONSTRAINT [FK_TTV_CB] FOREIGN KEY([MACB])
REFERENCES [dbo].[CHUYENBAY] ([MACB])
GO
ALTER TABLE [dbo].[TINHTRANGVE] CHECK CONSTRAINT [FK_TTV_CB]
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_TTTUYENBAY_SB] FOREIGN KEY([MASBDI])
REFERENCES [dbo].[SANBAY] ([MASB])
GO
ALTER TABLE [dbo].[TUYENBAY] CHECK CONSTRAINT [FK_TTTUYENBAY_SB]
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_TTUYENBAY_SB] FOREIGN KEY([MASBDEN])
REFERENCES [dbo].[SANBAY] ([MASB])
GO
ALTER TABLE [dbo].[TUYENBAY] CHECK CONSTRAINT [FK_TTUYENBAY_SB]
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_TUYENBAY_SB] FOREIGN KEY([MASBDI])
REFERENCES [dbo].[SANBAY] ([MASB])
GO
ALTER TABLE [dbo].[TUYENBAY] CHECK CONSTRAINT [FK_TUYENBAY_SB]
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_TUYENBAY_SB123] FOREIGN KEY([MASBDI])
REFERENCES [dbo].[SANBAY] ([MASB])
GO
ALTER TABLE [dbo].[TUYENBAY] CHECK CONSTRAINT [FK_TUYENBAY_SB123]
GO
ALTER TABLE [dbo].[VECHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_VECB_CB] FOREIGN KEY([MACB])
REFERENCES [dbo].[CHUYENBAY] ([MACB])
GO
ALTER TABLE [dbo].[VECHUYENBAY] CHECK CONSTRAINT [FK_VECB_CB]
GO
ALTER TABLE [dbo].[VECHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_VECHUYENBAY_HANHLI] FOREIGN KEY([MAHL])
REFERENCES [dbo].[HANHLI] ([MAHL])
GO
ALTER TABLE [dbo].[VECHUYENBAY] CHECK CONSTRAINT [FK_VECHUYENBAY_HANHLI]
GO
ALTER TABLE [dbo].[VECHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_VECHUYENBAY_HK] FOREIGN KEY([MAHK])
REFERENCES [dbo].[HANHKHACH] ([MAHK])
GO
ALTER TABLE [dbo].[VECHUYENBAY] CHECK CONSTRAINT [FK_VECHUYENBAY_HK]
GO
ALTER TABLE [dbo].[VECHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_VECHUYENBAY_HV] FOREIGN KEY([MAHV])
REFERENCES [dbo].[HANGVE] ([MAHV])
GO
ALTER TABLE [dbo].[VECHUYENBAY] CHECK CONSTRAINT [FK_VECHUYENBAY_HV]
GO
ALTER TABLE [dbo].[VECHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_VECHUYENBAY_NHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([id_Nhan_Vien])
GO
ALTER TABLE [dbo].[VECHUYENBAY] CHECK CONSTRAINT [FK_VECHUYENBAY_NHANVIEN]
GO
/****** Object:  Trigger [dbo].[UPDATE_DOANHTHUTHANG_WHEN_UPDATE_CTDOANHTHUTHANG]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UPDATE_DOANHTHUTHANG_WHEN_UPDATE_CTDOANHTHUTHANG]
ON [dbo].[CTDOANHTHUTHANG]
FOR UPDATE
AS
BEGIN
	DECLARE @THANG VARCHAR(3)=(SELECT THANG FROM INSERTED)
	DECLARE @NAM VARCHAR(5)=(SELECT NAM FROM INSERTED)
	DECLARE @DOANHTHU DECIMAL =(SELECT SUM(DOANHTHU) FROM CTDOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG)
	DECLARE @SOCHUYENBAY INT =(SELECT COUNT(DISTINCT MACB) FROM VECHUYENBAY WHERE YEAR(NGAYGD)=@NAM AND MONTH(NGAYGD)=@THANG AND LOAIVE='Vé mua')
	UPDATE DOANHTHUTHANG SET DOANHTHU=@DOANHTHU, SOCHUYENBAY=@SOCHUYENBAY WHERE NAM=@NAM AND THANG=@THANG
END

GO
/****** Object:  Trigger [dbo].[ADD_DOANHTHUNAM_WHEN_UPDATE_DOANHTHUTHANG]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[ADD_DOANHTHUNAM_WHEN_UPDATE_DOANHTHUTHANG]
ON [dbo].[DOANHTHUTHANG]
FOR INSERT
AS
BEGIN
	DECLARE @NAM VARCHAR(5)=(SELECT NAM FROM INSERTED)
	DECLARE @DOANHTHU DECIMAL =(SELECT SUM(DOANHTHU) FROM DOANHTHUTHANG WHERE NAM=@NAM)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM DOANHTHUNAM WHERE NAM=@NAM)
	IF(@COUNT=0)
	BEGIN
		INSERT INTO DOANHTHUNAM(NAM, DOANHTHU) VALUES(@NAM, @DOANHTHU)
	END
	ELSE
	BEGIN
		UPDATE DOANHTHUNAM SET DOANHTHU=@DOANHTHU WHERE NAM=@NAM
	END
END

GO
/****** Object:  Trigger [dbo].[UPDATE_DOANHTHUNAM_WHEN_UPDATE_DOANHTHUTHANG]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UPDATE_DOANHTHUNAM_WHEN_UPDATE_DOANHTHUTHANG]
ON [dbo].[DOANHTHUTHANG]
FOR UPDATE
AS
BEGIN
	DECLARE @NAM VARCHAR(5)=(SELECT NAM FROM INSERTED)
	DECLARE @DOANHTHU DECIMAL =(SELECT SUM(DOANHTHU) FROM DOANHTHUTHANG WHERE NAM=@NAM)
	UPDATE DOANHTHUNAM SET DOANHTHU=@DOANHTHU WHERE NAM=@NAM
END

GO
/****** Object:  Trigger [dbo].[CHECK_CHAM_NHAT_DAT_VE_]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CHECK_CHAM_NHAT_DAT_VE_]
ON [dbo].[VECHUYENBAY]
FOR INSERT
AS

BEGIN
	DECLARE @MACB VARCHAR(10)=(SELECT MACB FROM INSERTED)
	DECLARE @LOAIVE NVARCHAR(10)=(SELECT LOAIVE FROM INSERTED)
	DECLARE @MAVE VARCHAR(10)=(SELECT MAVE FROM INSERTED)
	DECLARE @NGAYGIO DATETIME = (SELECT NGAYGIO FROM CHUYENBAY WHERE MACB=@MACB)
	DECLARE @NGAYGD DATETIME = (SELECT NGAYGD FROM INSERTED)
	DECLARE @TGCHAMNHATDATVE INT = (SELECT TGCHAMNHATDATVE FROM THAMSO)
	
	IF(DATEDIFF(day, @NGAYGD, @NGAYGIO)<@TGCHAMNHATDATVE)
	BEGIN
		 ROLLBACK TRANSACTION
	END
END

GO
/****** Object:  Trigger [dbo].[INSERT_CHITIET_CTDOANHTHUTHANG_WHEN_INSERT_VECHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_CHITIET_CTDOANHTHUTHANG_WHEN_INSERT_VECHUYENBAY]
ON [dbo].[VECHUYENBAY]
FOR INSERT
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(NGAYGD) FROM INSERTED)
	DECLARE @THANG VARCHAR(5)= (SELECT MONTH(NGAYGD) FROM INSERTED)
	DECLARE @MACHUYENBAY VARCHAR(10)= (SELECT MACB FROM INSERTED)
	DECLARE @LOAIVE NVARCHAR(10) = (SELECT LOAIVE FROM INSERTED) 
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM CTDOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG AND MACHUYENBAY=@MACHUYENBAY)
	IF(@LOAIVE=N'Vé mua')
	BEGIN
		IF(@COUNT=0)
		BEGIN
			INSERT INTO CTDOANHTHUTHANG(THANG, NAM, MACHUYENBAY, SOVEBANDUOC, DOANHTHU) VALUES(@THANG, @NAM, @MACHUYENBAY, 0, 0)
		END
	END
END


GO
/****** Object:  Trigger [dbo].[INSERT_CONLAI_CTDOANHTHUTHANG_WHEN_INSERT_VECHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_CONLAI_CTDOANHTHUTHANG_WHEN_INSERT_VECHUYENBAY]
ON [dbo].[VECHUYENBAY]
FOR INSERT
AS
BEGIN
	DECLARE @MACHUYENBAY VARCHAR(10)=(SELECT MACB FROM INSERTED)
	DECLARE @THANG VARCHAR(3)=(SELECT MONTH(NGAYGD) FROM INSERTED)
	DECLARE @NAM VARCHAR(5)=(SELECT YEAR(NGAYGD) FROM INSERTED)
	DECLARE @GIATIEN DECIMAL =(SELECT GIA FROM INSERTED)
	DECLARE @SOVEBANDUOC INT =(SELECT COUNT(MAVE) FROM VECHUYENBAY WHERE MACB=@MACHUYENBAY AND MONTH(NGAYGD)=@THANG AND YEAR(NGAYGD)=@NAM AND LOAIVE=N'Vé mua')
	UPDATE CTDOANHTHUTHANG SET DOANHTHU+=@GIATIEN, SOVEBANDUOC=@SOVEBANDUOC WHERE MACHUYENBAY=@MACHUYENBAY
END

GO
/****** Object:  Trigger [dbo].[INSERT_CTDOANHTHUTHANG_WHEN_UPDATE_THANHTOAN_CHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_CTDOANHTHUTHANG_WHEN_UPDATE_THANHTOAN_CHUYENBAY]
ON [dbo].[VECHUYENBAY]
FOR UPDATE
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(NGAYGD) FROM INSERTED)
	DECLARE @THANG VARCHAR(5)= (SELECT MONTH(NGAYGD) FROM INSERTED)
	DECLARE @MACHUYENBAY VARCHAR(10)= (SELECT MACB FROM INSERTED)
	DECLARE @LOAIVE NVARCHAR(10) = (SELECT LOAIVE FROM INSERTED) 
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM CTDOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG AND MACHUYENBAY=@MACHUYENBAY)
	IF(@LOAIVE=N'Vé mua')
	BEGIN
		IF(@COUNT=0)
		BEGIN
			INSERT INTO CTDOANHTHUTHANG(THANG, NAM, MACHUYENBAY, SOVEBANDUOC, DOANHTHU) VALUES(@THANG, @NAM, @MACHUYENBAY, 0, 0)
		END
	END
END

GO
/****** Object:  Trigger [dbo].[INSERT_DOANHTHUNAM_WHEN_INSERT_VECHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_DOANHTHUNAM_WHEN_INSERT_VECHUYENBAY]
ON [dbo].[VECHUYENBAY]
FOR INSERT
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(NGAYGD) FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM DOANHTHUNAM WHERE NAM=@NAM)
	DECLARE @LOAIVE NVARCHAR = (SELECT LOAIVE FROM INSERTED)
	IF(@LOAIVE=N'Vé mua')
	BEGIN
		IF(@COUNT=0)
		BEGIN
			INSERT INTO DOANHTHUNAM(NAM, DOANHTHU) VALUES(@NAM, 0)
		END
	END
END

GO
/****** Object:  Trigger [dbo].[INSERT_DOANHTHUNAM_WHEN_UPDATE_THANH_TOAN_VECHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_DOANHTHUNAM_WHEN_UPDATE_THANH_TOAN_VECHUYENBAY]
ON [dbo].[VECHUYENBAY]
FOR UPDATE
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(NGAYGD) FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM DOANHTHUNAM WHERE NAM=@NAM)
	DECLARE @LOAIVE NVARCHAR = (SELECT LOAIVE FROM INSERTED)
	IF(@LOAIVE=N'Vé mua')
	BEGIN
		IF(@COUNT=0)
		BEGIN
			INSERT INTO DOANHTHUNAM(NAM, DOANHTHU) VALUES(@NAM, 0)
		END
	END
END

GO
/****** Object:  Trigger [dbo].[INSERT_DOANHTHUTHANG_WHEN_INSERT_VECHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_DOANHTHUTHANG_WHEN_INSERT_VECHUYENBAY]
ON [dbo].[VECHUYENBAY]
FOR INSERT
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(NGAYGD) FROM INSERTED)
	DECLARE @THANG VARCHAR(5)= (SELECT MONTH(NGAYGD) FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM DOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG)
	DECLARE @LOAIVE NVARCHAR(10) = (SELECT LOAIVE FROM INSERTED)
	IF(@LOAIVE=N'Vé mua')
	BEGIN
		IF(@COUNT=0)
		BEGIN
			INSERT INTO DOANHTHUTHANG(THANG, NAM, SOCHUYENBAY, DOANHTHU) VALUES(@THANG, @NAM, 0, 0)
		END
	END
	
END

GO
/****** Object:  Trigger [dbo].[INSERT_DOANHTHUTHANG_WHEN_UPDATE_THANH_TOAN_VECHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_DOANHTHUTHANG_WHEN_UPDATE_THANH_TOAN_VECHUYENBAY]
ON [dbo].[VECHUYENBAY]
FOR UPDATE
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(NGAYGD) FROM INSERTED)
	DECLARE @THANG VARCHAR(5)= (SELECT MONTH(NGAYGD) FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM DOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG)
	DECLARE @LOAIVE NVARCHAR(10) = (SELECT LOAIVE FROM INSERTED)
	IF(@LOAIVE=N'Vé mua')
	BEGIN
		IF(@COUNT=0)
		BEGIN
			INSERT INTO DOANHTHUTHANG(THANG, NAM, SOCHUYENBAY, DOANHTHU) VALUES(@THANG, @NAM, 0, 0)
		END
	END
	
END

GO
/****** Object:  Trigger [dbo].[UPDATE_NGAY_HUY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[UPDATE_NGAY_HUY]
ON [dbo].[VECHUYENBAY]
FOR INSERT
AS

BEGIN
	DECLARE @MACB VARCHAR(10)=(SELECT MACB FROM INSERTED)
	DECLARE @LOAIVE NVARCHAR(10)=(SELECT LOAIVE FROM INSERTED)
	DECLARE @MAVE VARCHAR(10)=(SELECT MAVE FROM INSERTED)
	DECLARE @NGAYGIO DATETIME = (SELECT NGAYGIO FROM CHUYENBAY WHERE MACB=@MACB)
	DECLARE @TGCHAMNHATHUYVE INT = (SELECT TGCHAMNHATHUYVE FROM THAMSO)
	DECLARE @NGAYHUY DATE = DATEADD(DAY, -@TGCHAMNHATHUYVE, @NGAYGIO)  
	IF (@LOAIVE=N'Vé đặt')
	BEGIN
		UPDATE VECHUYENBAY SET NGAYHUY=@NGAYHUY WHERE MAVE=@MAVE
	END
END

GO
/****** Object:  Trigger [dbo].[UPDATE_TINHTRANGVE_WHEN_HUY_VECHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UPDATE_TINHTRANGVE_WHEN_HUY_VECHUYENBAY]
ON [dbo].[VECHUYENBAY]
FOR UPDATE
AS
BEGIN
	DECLARE @MACHUYENBAY VARCHAR(10)=(SELECT MACB FROM INSERTED)
	DECLARE @MAHANGVE VARCHAR(10)=(SELECT MAHV FROM INSERTED)
	DECLARE @TONGSOGHE INT =(SELECT SLGHE FROM TINHTRANGVE WHERE MACB=@MACHUYENBAY AND MAHV=@MAHANGVE)

	UPDATE TINHTRANGVE SET SLGHETRONG=SLGHETRONG+1,SLGHEDAT=SLGHEDAT-1 WHERE MACB=@MACHUYENBAY AND MAHV=@MAHANGVE
END


GO
/****** Object:  Trigger [dbo].[UPDATE_TINHTRANGVE_WHEN_INSERT_VECHUYENBAY]    Script Date: 5/4/2020 9:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UPDATE_TINHTRANGVE_WHEN_INSERT_VECHUYENBAY]
ON [dbo].[VECHUYENBAY]
FOR INSERT
AS
BEGIN
	DECLARE @MACHUYENBAY VARCHAR(10)=(SELECT MACB FROM INSERTED)
	DECLARE @MAHANGVE VARCHAR(10)=(SELECT MAHV FROM INSERTED)
	DECLARE @TONGSOGHE INT =(SELECT SLGHE FROM TINHTRANGVE WHERE MACB=@MACHUYENBAY AND MAHV=@MAHANGVE)
	DECLARE @SOGHEMUA INT =(SELECT COUNT(MAVE) FROM VECHUYENBAY WHERE MACB=@MACHUYENBAY AND MAHV=@MAHANGVE AND (LOAIVE=N'Vé mua' OR LOAIVE =N'Vé đặt'))
	
	UPDATE TINHTRANGVE SET SLGHETRONG=@TONGSOGHE-@SOGHEMUA,SLGHEDAT=@SOGHEMUA WHERE MACB=@MACHUYENBAY AND MAHV=@MAHANGVE
	
END


GO
USE [master]
GO
ALTER DATABASE [SELL_PLANE_TICKET_DATABASE] SET  READ_WRITE 
GO
