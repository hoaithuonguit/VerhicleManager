USE [XeNang]
GO
/****** Object:  Table [dbo].[BanHang]    Script Date: 5/26/2018 6:55:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanHang](
	[ID] [int] NOT NULL,
	[ID_Product] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayBan] [datetime] NOT NULL,
 CONSTRAINT [PK_BanHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 5/26/2018 6:55:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DatHang](
	[ID] [int] NOT NULL,
	[TenNguoiDat] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
	[MailZalo] [varchar](50) NOT NULL,
	[TenHang] [nvarchar](200) NOT NULL,
	[ThoiGianCanLay] [datetime] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[TrangThai] [varchar](2) NOT NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 5/26/2018 6:55:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[ID] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayUpdated] [datetime] NOT NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MasterData]    Script Date: 5/26/2018 6:55:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MasterData](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Value] [nvarchar](200) NOT NULL,
	[Keys] [varchar](10) NOT NULL,
 CONSTRAINT [PK_MasterData] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhapHang]    Script Date: 5/26/2018 6:55:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhapHang](
	[ID] [int] NOT NULL,
	[NgayNhapHang] [date] NOT NULL,
	[ID_Product] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TinhTrang] [varchar](5) NOT NULL,
	[Hang] [nvarchar](50) NOT NULL,
	[PhanLoaiXe] [varchar](5) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[Loai] [varchar](2) NOT NULL,
 CONSTRAINT [PK_NhapHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/26/2018 6:55:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[ID] [int] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Loai] [varchar](5) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongTinSanPham]    Script Date: 5/26/2018 6:55:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongTinSanPham](
	[ID] [int] NOT NULL,
	[Hieu] [varchar](30) NOT NULL,
	[Doi] [varchar](30) NOT NULL,
	[Hang] [varchar](50) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[TinhTrang] [varchar](5) NOT NULL,
	[PhanLoai] [varchar](5) NOT NULL,
	[Image1] [varchar](max) NOT NULL,
	[Image2] [varchar](max) NULL,
	[Image3] [varchar](max) NULL,
	[Image4] [varchar](max) NULL,
	[Image5] [varchar](max) NULL,
 CONSTRAINT [PK_ThongTinSanPham] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
