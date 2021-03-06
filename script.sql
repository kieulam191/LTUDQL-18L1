USE [QuanLyCuaHangBanGao]
GO
/****** Object:  Table [dbo].[ChiTietGhiNo]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietGhiNo](
	[MaTheGhiNo] [char](5) NOT NULL,
	[MaKH] [char](5) NOT NULL,
	[TienNo] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheGhiNo] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuBan]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuBan](
	[MaPhieuBanHang] [char](5) NOT NULL,
	[MaGao] [char](5) NOT NULL,
	[MaKH] [char](5) NOT NULL,
	[SoLuongMua] [int] NULL,
	[GiaHienTai] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuBanHang] ASC,
	[MaGao] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [char](5) NOT NULL,
	[MaGao] [char](5) NOT NULL,
	[SoLuongNhap] [int] NULL,
	[GiaBanRa] [money] NULL,
	[MaNCC] [char](5) NULL,
	[GiaMuaVao] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaGao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gao]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gao](
	[MaGao] [char](5) NOT NULL,
	[TenSanPham] [nvarchar](30) NULL,
	[LoaiSanPham] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](5) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[Sdt] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](30) NULL,
	[CMND] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhoHang](
	[MaGao] [char](5) NOT NULL,
	[SoLuongTonKho] [int] NULL,
	[SoKiToiThieu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiGao]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiGao](
	[MaLoai] [char](5) NOT NULL,
	[TenLoai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [char](5) NOT NULL,
	[TenNCC] [nvarchar](30) NULL,
	[Sdt] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](30) NULL,
	[TinhTrang] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuBanHang]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuBanHang](
	[MaPBH] [char](5) NOT NULL,
	[NgayBAn] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhapGao]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhapGao](
	[MaPN] [char](5) NOT NULL,
	[NgayNhap] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheGhiNo]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheGhiNo](
	[MaTheGhiNo] [char](5) NOT NULL,
	[NgayNo] [date] NULL,
	[NgayTra] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheGhiNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheKhachHang]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheKhachHang](
	[MaThe] [char](5) NOT NULL,
	[MaKH] [char](5) NOT NULL,
	[NgayLap] [date] NULL,
	[SoLuongDaMua] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongKe]    Script Date: 1/8/2021 8:36:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongKe](
	[MaThongKe] [char](5) NOT NULL,
	[MaPhieuBan] [char](5) NULL,
	[MaGao] [char](5) NULL,
	[ThanhTien] [money] NULL,
	[LoiNhuan] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThongKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietPhieuBan] ([MaPhieuBanHang], [MaGao], [MaKH], [SoLuongMua], [GiaHienTai]) VALUES (N'PB001', N'MG001', N'KH001', 1, 11000.0000)
INSERT [dbo].[ChiTietPhieuBan] ([MaPhieuBanHang], [MaGao], [MaKH], [SoLuongMua], [GiaHienTai]) VALUES (N'PB002', N'MG001', N'KH001', 3, 11000.0000)
INSERT [dbo].[ChiTietPhieuBan] ([MaPhieuBanHang], [MaGao], [MaKH], [SoLuongMua], [GiaHienTai]) VALUES (N'PB003', N'MG001', N'KH002', 1, 11000.0000)
INSERT [dbo].[ChiTietPhieuBan] ([MaPhieuBanHang], [MaGao], [MaKH], [SoLuongMua], [GiaHienTai]) VALUES (N'PB004', N'MG001', N'KH002', 1, 11000.0000)
INSERT [dbo].[ChiTietPhieuBan] ([MaPhieuBanHang], [MaGao], [MaKH], [SoLuongMua], [GiaHienTai]) VALUES (N'PB005', N'MG001', N'KH002', 1, 11000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaGao], [SoLuongNhap], [GiaBanRa], [MaNCC], [GiaMuaVao]) VALUES (N'PN001', N'MG001', 100, 11000.0000, N'NC001', 1000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaGao], [SoLuongNhap], [GiaBanRa], [MaNCC], [GiaMuaVao]) VALUES (N'PN002', N'MG002', 100, 12000.0000, N'NC002', 2000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaGao], [SoLuongNhap], [GiaBanRa], [MaNCC], [GiaMuaVao]) VALUES (N'PN003', N'MG002', 100, 11000.0000, N'NC001', 1000000.0000)
INSERT [dbo].[Gao] ([MaGao], [TenSanPham], [LoaiSanPham]) VALUES (N'MG001', N'Gạo Tài Nguyên', N'LG001')
INSERT [dbo].[Gao] ([MaGao], [TenSanPham], [LoaiSanPham]) VALUES (N'MG002', N'Gạo Nàng Thơm', N'LG002')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Sdt], [DiaChi], [CMND]) VALUES (N'KH001', N'Nguyễn Văn A', N'123456789', N'Quan 5', N'1234567   ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Sdt], [DiaChi], [CMND]) VALUES (N'KH002', N'Nguyễn Văn B', N'123456781', N'Quận 3', N'1234568   ')
INSERT [dbo].[LoaiGao] ([MaLoai], [TenLoai]) VALUES (N'LG001', N'Gạo A')
INSERT [dbo].[LoaiGao] ([MaLoai], [TenLoai]) VALUES (N'LG002', N'Gạo B')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Sdt], [DiaChi], [TinhTrang]) VALUES (N'NC001', N'Nhà cung cấp A', N'123456789', N'Quận 3 TPHCM', N'HOẠT ĐỘNG')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [Sdt], [DiaChi], [TinhTrang]) VALUES (N'NC002', N'Nhà cung cấp B', N'123987654', N'Tân Bình', N'HOẠT ĐỘNG')
INSERT [dbo].[PhieuBanHang] ([MaPBH], [NgayBAn]) VALUES (N'PB001', CAST(0xD2420B00 AS Date))
INSERT [dbo].[PhieuBanHang] ([MaPBH], [NgayBAn]) VALUES (N'PB002', CAST(0xD2420B00 AS Date))
INSERT [dbo].[PhieuBanHang] ([MaPBH], [NgayBAn]) VALUES (N'PB003', CAST(0xD2420B00 AS Date))
INSERT [dbo].[PhieuBanHang] ([MaPBH], [NgayBAn]) VALUES (N'PB004', CAST(0xD2420B00 AS Date))
INSERT [dbo].[PhieuBanHang] ([MaPBH], [NgayBAn]) VALUES (N'PB005', CAST(0xD2420B00 AS Date))
INSERT [dbo].[PhieuNhapGao] ([MaPN], [NgayNhap]) VALUES (N'PN001', CAST(0xFE410B00 AS Date))
INSERT [dbo].[PhieuNhapGao] ([MaPN], [NgayNhap]) VALUES (N'PN002', CAST(0x58420B00 AS Date))
INSERT [dbo].[PhieuNhapGao] ([MaPN], [NgayNhap]) VALUES (N'PN003', CAST(0xD2420B00 AS Date))
INSERT [dbo].[TheKhachHang] ([MaThe], [MaKH], [NgayLap], [SoLuongDaMua]) VALUES (N'MT001', N'KH001', CAST(0xFE410B00 AS Date), 9)
INSERT [dbo].[TheKhachHang] ([MaThe], [MaKH], [NgayLap], [SoLuongDaMua]) VALUES (N'MT002', N'KH002', CAST(0x1E420B00 AS Date), 13)
ALTER TABLE [dbo].[ChiTietGhiNo]  WITH CHECK ADD  CONSTRAINT [FK_CTGN_TGN] FOREIGN KEY([MaTheGhiNo])
REFERENCES [dbo].[TheGhiNo] ([MaTheGhiNo])
GO
ALTER TABLE [dbo].[ChiTietGhiNo] CHECK CONSTRAINT [FK_CTGN_TGN]
GO
ALTER TABLE [dbo].[ChiTietGhiNo]  WITH CHECK ADD  CONSTRAINT [FK_CTGN_TKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ChiTietGhiNo] CHECK CONSTRAINT [FK_CTGN_TKH]
GO
ALTER TABLE [dbo].[ChiTietPhieuBan]  WITH CHECK ADD  CONSTRAINT [FK_CTPB_G] FOREIGN KEY([MaGao])
REFERENCES [dbo].[Gao] ([MaGao])
GO
ALTER TABLE [dbo].[ChiTietPhieuBan] CHECK CONSTRAINT [FK_CTPB_G]
GO
ALTER TABLE [dbo].[ChiTietPhieuBan]  WITH CHECK ADD  CONSTRAINT [FK_CTPB_PBH] FOREIGN KEY([MaPhieuBanHang])
REFERENCES [dbo].[PhieuBanHang] ([MaPBH])
GO
ALTER TABLE [dbo].[ChiTietPhieuBan] CHECK CONSTRAINT [FK_CTPB_PBH]
GO
ALTER TABLE [dbo].[ChiTietPhieuBan]  WITH CHECK ADD  CONSTRAINT [FK_CTPB_TKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ChiTietPhieuBan] CHECK CONSTRAINT [FK_CTPB_TKH]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_G] FOREIGN KEY([MaGao])
REFERENCES [dbo].[Gao] ([MaGao])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_G]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_NCC]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_PN] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhapGao] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_PN]
GO
ALTER TABLE [dbo].[Gao]  WITH CHECK ADD  CONSTRAINT [FK_G_LG] FOREIGN KEY([LoaiSanPham])
REFERENCES [dbo].[LoaiGao] ([MaLoai])
GO
ALTER TABLE [dbo].[Gao] CHECK CONSTRAINT [FK_G_LG]
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [FK_KH_GAO] FOREIGN KEY([MaGao])
REFERENCES [dbo].[Gao] ([MaGao])
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [FK_KH_GAO]
GO
ALTER TABLE [dbo].[TheKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_TKH_KH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[TheKhachHang] CHECK CONSTRAINT [FK_TKH_KH]
GO
ALTER TABLE [dbo].[ThongKe]  WITH CHECK ADD  CONSTRAINT [FK_TK_G] FOREIGN KEY([MaGao])
REFERENCES [dbo].[Gao] ([MaGao])
GO
ALTER TABLE [dbo].[ThongKe] CHECK CONSTRAINT [FK_TK_G]
GO
ALTER TABLE [dbo].[ThongKe]  WITH CHECK ADD  CONSTRAINT [FK_TK_PB] FOREIGN KEY([MaPhieuBan])
REFERENCES [dbo].[PhieuBanHang] ([MaPBH])
GO
ALTER TABLE [dbo].[ThongKe] CHECK CONSTRAINT [FK_TK_PB]
GO
