USE [QLCDT]
GO
ALTER TABLE [dbo].[THONGTINSIM] DROP CONSTRAINT [FK_MAKH]
GO
ALTER TABLE [dbo].[HDTC] DROP CONSTRAINT [FK_HDTC_SDT]
GO
ALTER TABLE [dbo].[HDDK] DROP CONSTRAINT [FK_HDDK_THONGTINSIM]
GO
ALTER TABLE [dbo].[CHITIETSD] DROP CONSTRAINT [FK__CHITIETSD__IDSIM__1FCDBCEB]
GO
ALTER TABLE [dbo].[HDTC] DROP CONSTRAINT [DF__HDTC__TRANGTHAI__1A14E395]
GO
ALTER TABLE [dbo].[HDTC] DROP CONSTRAINT [DF__HDTC__THANHTOAN__1920BF5C]
GO
/****** Object:  Index [UQ__KHACHHAN__F67C8D0B48C90DED]    Script Date: 11/23/2018 12:17:01 AM ******/
ALTER TABLE [dbo].[KHACHHANG] DROP CONSTRAINT [UQ__KHACHHAN__F67C8D0B48C90DED]
GO
/****** Object:  Index [unique_HDDK]    Script Date: 11/23/2018 12:17:01 AM ******/
ALTER TABLE [dbo].[HDDK] DROP CONSTRAINT [unique_HDDK]
GO
/****** Object:  Table [dbo].[THONGTINSIM]    Script Date: 11/23/2018 12:17:01 AM ******/
DROP TABLE [dbo].[THONGTINSIM]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/23/2018 12:17:01 AM ******/
DROP TABLE [dbo].[KHACHHANG]
GO
/****** Object:  Table [dbo].[HDTC]    Script Date: 11/23/2018 12:17:01 AM ******/
DROP TABLE [dbo].[HDTC]
GO
/****** Object:  Table [dbo].[HDDK]    Script Date: 11/23/2018 12:17:01 AM ******/
DROP TABLE [dbo].[HDDK]
GO
/****** Object:  Table [dbo].[GIACUOC]    Script Date: 11/23/2018 12:17:01 AM ******/
DROP TABLE [dbo].[GIACUOC]
GO
/****** Object:  Table [dbo].[CHITIETSD]    Script Date: 11/23/2018 12:17:01 AM ******/
DROP TABLE [dbo].[CHITIETSD]
GO
/****** Object:  Table [dbo].[CHITIETSD]    Script Date: 11/23/2018 12:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETSD](
	[IDSIM] [varchar](11) NOT NULL,
	[TGBD] [datetime] NOT NULL,
	[TGKT] [datetime] NOT NULL,
	[SOPHUTSD] [float] NOT NULL,
	[CUOCPHI] [decimal](19, 3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDSIM] ASC,
	[TGBD] ASC,
	[TGKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIACUOC]    Script Date: 11/23/2018 12:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIACUOC](
	[MAGC] [varchar](10) NOT NULL,
	[TGBD] [time](7) NOT NULL,
	[TGKT] [time](7) NOT NULL,
	[GIACUOC] [decimal](19, 3) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAGC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HDDK]    Script Date: 11/23/2018 12:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HDDK](
	[MAHDDK] [varchar](10) NOT NULL,
	[IDSIM] [varchar](11) NOT NULL,
	[CUOCDK] [decimal](19, 3) NOT NULL DEFAULT ((50000)),
PRIMARY KEY CLUSTERED 
(
	[MAHDDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HDTC]    Script Date: 11/23/2018 12:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HDTC](
	[MAHDTC] [varchar](10) NOT NULL,
	[IDSIM] [varchar](11) NOT NULL,
	[TONGTIEN] [decimal](19, 3) NOT NULL,
	[THANHTOAN] [bit] NOT NULL,
	[TRANGTHAI] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHDTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/23/2018 12:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [varchar](10) NOT NULL,
	[TENKH] [nvarchar](100) NOT NULL,
	[CMND] [varchar](12) NULL,
	[NGHENGHIEP] [nvarchar](50) NULL,
	[CHUCVU] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[TINHTRANG] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THONGTINSIM]    Script Date: 11/23/2018 12:17:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THONGTINSIM](
	[IDSIM] [varchar](11) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[MAKH] [varchar](10) NOT NULL,
	[TINHTRANG] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDSIM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[GIACUOC] ([MAGC], [TGBD], [TGKT], [GIACUOC]) VALUES (N'ca1', CAST(N'07:00:00' AS Time), CAST(N'23:00:00' AS Time), CAST(200.000 AS Decimal(19, 3)))
INSERT [dbo].[GIACUOC] ([MAGC], [TGBD], [TGKT], [GIACUOC]) VALUES (N'ca2', CAST(N'23:00:00' AS Time), CAST(N'07:00:00' AS Time), CAST(150.000 AS Decimal(19, 3)))
INSERT [dbo].[HDDK] ([MAHDDK], [IDSIM], [CUOCDK]) VALUES (N'dk01', N'0916860011', CAST(50000.000 AS Decimal(19, 3)))
INSERT [dbo].[HDDK] ([MAHDDK], [IDSIM], [CUOCDK]) VALUES (N'dk02', N'01689992304', CAST(50000.000 AS Decimal(19, 3)))
INSERT [dbo].[HDDK] ([MAHDDK], [IDSIM], [CUOCDK]) VALUES (N'dk03', N'01207713246', CAST(50000.000 AS Decimal(19, 3)))
INSERT [dbo].[HDDK] ([MAHDDK], [IDSIM], [CUOCDK]) VALUES (N'dk04', N'0936011253', CAST(50000.000 AS Decimal(19, 3)))
INSERT [dbo].[HDDK] ([MAHDDK], [IDSIM], [CUOCDK]) VALUES (N'dk05', N'0908774382', CAST(50000.000 AS Decimal(19, 3)))
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [CMND], [NGHENGHIEP], [CHUCVU], [DIACHI], [TINHTRANG]) VALUES (N'KH01', N'Nguyễn Văn A', N'093422825', N'Sinh Viên', N'', N'731 Trần Hưng Đạo, Q5, TPHCM', 1)
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [CMND], [NGHENGHIEP], [CHUCVU], [DIACHI], [TINHTRANG]) VALUES (N'KH02', N'Trần Ngọc Hân', N'312501499', N'Nhân Viên', N'Trưởng Phòng', N'23/5 Nguyễn Trãi, Q5, TPHCM', 1)
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [CMND], [NGHENGHIEP], [CHUCVU], [DIACHI], [TINHTRANG]) VALUES (N'KH03', N'Trần Ngọc Linh', N'029251974', N'Sinh Viên', N'', N'45 Nguyễn Cảnh Chân, Q1, TPHCM', 1)
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [CMND], [NGHENGHIEP], [CHUCVU], [DIACHI], [TINHTRANG]) VALUES (N'KH04', N'Trần Minh Long', N'025611248', N'Bác Sĩ', N'', N'50/34 Lê Đại Hành, Q10, TPHCM', 1)
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [CMND], [NGHENGHIEP], [CHUCVU], [DIACHI], [TINHTRANG]) VALUES (N'KH05', N'Lê Nhật Minh', N'021423498', N'Kỹ Sư', N'', N'34 Trương Định, Q3, TPHCM', 1)
INSERT [dbo].[THONGTINSIM] ([IDSIM], [SDT], [MAKH], [TINHTRANG]) VALUES (N'01207713246', N'01207713246', N'KH03', 1)
INSERT [dbo].[THONGTINSIM] ([IDSIM], [SDT], [MAKH], [TINHTRANG]) VALUES (N'01689992304', N'01689992304', N'KH02', 1)
INSERT [dbo].[THONGTINSIM] ([IDSIM], [SDT], [MAKH], [TINHTRANG]) VALUES (N'0908774382', N'0908774382', N'KH05', 1)
INSERT [dbo].[THONGTINSIM] ([IDSIM], [SDT], [MAKH], [TINHTRANG]) VALUES (N'0916860011', N'0916860011', N'KH01', 1)
INSERT [dbo].[THONGTINSIM] ([IDSIM], [SDT], [MAKH], [TINHTRANG]) VALUES (N'0936011253', N'0936011253', N'KH04', 1)
SET ANSI_PADDING ON

GO
/****** Object:  Index [unique_HDDK]    Script Date: 11/23/2018 12:17:02 AM ******/
ALTER TABLE [dbo].[HDDK] ADD  CONSTRAINT [unique_HDDK] UNIQUE NONCLUSTERED 
(
	[IDSIM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__KHACHHAN__F67C8D0B48C90DED]    Script Date: 11/23/2018 12:17:02 AM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD UNIQUE NONCLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HDTC] ADD  DEFAULT ((0)) FOR [THANHTOAN]
GO
ALTER TABLE [dbo].[HDTC] ADD  DEFAULT ((0)) FOR [TRANGTHAI]
GO
ALTER TABLE [dbo].[CHITIETSD]  WITH CHECK ADD FOREIGN KEY([IDSIM])
REFERENCES [dbo].[THONGTINSIM] ([IDSIM])
GO
ALTER TABLE [dbo].[HDDK]  WITH CHECK ADD  CONSTRAINT [FK_HDDK_THONGTINSIM] FOREIGN KEY([IDSIM])
REFERENCES [dbo].[THONGTINSIM] ([IDSIM])
GO
ALTER TABLE [dbo].[HDDK] CHECK CONSTRAINT [FK_HDDK_THONGTINSIM]
GO
ALTER TABLE [dbo].[HDTC]  WITH CHECK ADD  CONSTRAINT [FK_HDTC_SDT] FOREIGN KEY([IDSIM])
REFERENCES [dbo].[THONGTINSIM] ([IDSIM])
GO
ALTER TABLE [dbo].[HDTC] CHECK CONSTRAINT [FK_HDTC_SDT]
GO
ALTER TABLE [dbo].[THONGTINSIM]  WITH CHECK ADD  CONSTRAINT [FK_MAKH] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[THONGTINSIM] CHECK CONSTRAINT [FK_MAKH]
GO
