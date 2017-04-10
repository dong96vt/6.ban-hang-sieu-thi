
USE [TTN_banhangsieuthi]
GO

/****** Object:  Table [dbo].[nhanvien]    Script Date: 10/04/2017 7:12:10 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[nhanvien](
	[ma] [varchar](10) NOT NULL,
	[mahienthi] [nvarchar](20) NULL,
	[hoten] [nvarchar](200) NULL,
	[quequan] [nvarchar](100) NULL,
	[diachi] [nvarchar](100) NULL,
	[gioitinh] [int] NULL,
	[ngaysinh] [date] NULL,
	[luong] [int] NULL,
	[chucvu] [nvarchar](100) NULL,
	[id] [varchar](20) UNIQUE,
	[pass] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
USE [TTN_banhangsieuthi]
GO

/****** Object:  Table [dbo].[hanghoa]    Script Date: 10/04/2017 6:49:06 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[hanghoa](
	[ma] [varchar](10) NOT NULL,
	[mahienthi] [nvarchar](20) NULL,
	[ten] [nvarchar](200) NULL,
	[soluongcon] [int] NULL,
	[loaihang] [nvarchar](100) NULL,
	[gia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [TTN_banhangsieuthi]
GO

/****** Object:  Table [dbo].[hoadon]    Script Date: 10/04/2017 6:49:54 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[hoadon](
	[ma] [varchar](10) NOT NULL,
	[mahienthi] [nvarchar](20) NULL,
	[khachhangma] [varchar](10) NULL,
	[nhanvienma] [varchar](10) NULL,
	[ngayviet] [datetime] NULL,
	[khuyenmai] [float] NULL,
	[tonggia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khachhang] FOREIGN KEY([khachhangma])
REFERENCES [dbo].[khachhang] ([ma])
GO

ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khachhang]
GO

ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_nhanvien] FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[nhanvien] ([ma])
GO

ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_nhanvien]
GO
USE [TTN_banhangsieuthi]
GO

/****** Object:  Table [dbo].[khachhang]    Script Date: 10/04/2017 7:11:44 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[khachhang](
	[ma] [varchar](10) NOT NULL,
	[mahienthi] [nvarchar](20) NULL,
	[hoten] [nvarchar](200) NULL,
	[diachi] [nvarchar](100) NULL,
	[gioitinh] [int] NULL,
	[ngaysinh] [date] NULL,
	[cmtnd] [varchar](20) NULL,
	[sdt] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO




USE [TTN_banhangsieuthi]
GO

/****** Object:  Table [dbo].[sanpham]    Script Date: 10/04/2017 7:12:26 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[sanpham](
	[ma] [varchar](10) NOT NULL,
	[soluong] [int] NULL,
	[hanghoama] [varchar](10) NULL,
	[hoadonma] [varchar](10) NULL,
	[mahienthi] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_hanghoa] FOREIGN KEY([hanghoama])
REFERENCES [dbo].[hanghoa] ([ma])
GO

ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_hanghoa]
GO

ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_hoadon] FOREIGN KEY([hoadonma])
REFERENCES [dbo].[hoadon] ([ma])
GO

ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_hoadon]
GO


