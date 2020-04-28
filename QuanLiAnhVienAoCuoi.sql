Create Database QuanLiAnhVienAoCuoi
On
(	Name = QL_AVAC_data,
	Filename='D:\sql\qly_AVAC.mdf',
	size = 5,
	Maxsize = 10,
	filegrowth = 2
)
Log on
(	Name = ql_AVAC_log,
	Filename='D:\sql\qly_AVAC.ldf',
	size = 5mb,
	Filegrowth = 2mb
)
create table tblSanPham
(
    MaSP nvarchar(10)primary key not null,
	TenSP nvarchar(50),
	Anhminhhoa nvarchar(300),
	MaMau nvarchar(10) not null,
	ManoiSX nvarchar(10),
	Soluong int,
	Dongianhap int,
	Dongiathue int,
	MaLoaiSP nvarchar(10) not null
)
Create table tblHoaDonNhap
(	MaHDN nvarchar(30)primary key not null,
	NgayNhap datetime,
	MaNV nvarchar(10) not null,
	MaNCC nvarchar(10) not null,
	Tongtien int
)
create table tblChitietHDN
(
    MaHDN nvarchar(30)not null,
	MaSP varchar(10)not null,
	SoLuong int,
	DonGia int,
	Thanhtien int,
	constraint PK_tblChitietHDN primary key (MaHDN, MaSP)
)
create table tblHopdong
(
    MaHD nvarchar(10)primary key not null,
	MaKHach nvarchar(10)not null,
	MaNV nvarchar(10)not null,
	NgayHD datetime,
	Khuyenmai int,
	TamUng int
)
create table tblChitietHDong
(
    MaHD varchar(10)not null,
	MaSP varchar(10)not null,
	SoLuong int,
	NgayThue date,
	ChuaTra int,
	constraint PK_tblChitietHDong primary key (MaHD, MaSP)
)
create table tblThanhtoanHD
(
    MaThanhtoan nvarchar(10)primary key not null,
	MaHD nvarchar(10) not null,
	MaNV nvarchar(10) not null,
	Ngaythanhtoan date,
	Tongtien int,
	SotienThanhtoan int
)
create table tblNhaCungCap
(
    MaNCC nvarchar(10)primary key not null,
	TenNCC nvarchar(50),
	DiaChi nvarchar(50),
	DienThoai int
)
create table tblNhanVien
(	MaNV varchar(10)primary key not null,
	TenNV nvarchar(50),
	DiaChi nvarchar(50),
	DienThoaiCD int,
	DienThoaiDD int,
	MaCM varchar(10)not null
)
create table tblKhachHang
(	MaKHach nvarchar(10)primary key not null,
	TenKhach nvarchar(50),
	SoCMTND int,
	DiaChi nvarchar(50),
	DienThoaiKhach int
)
create table tblMau
(	MaMau varchar(10)primary key not null,
	TenMau nvarchar(50)
)
create table tblNoiSanXuat
(	ManoiSX varchar(10)primary key not null,
	TennoiSX nvarchar(50)
)
create table tblLoaiSP
(	MaLoaiSP varchar(10)primary key not null,
	TenLoaiSP nvarchar(50)
)

delete from tblChitietHDong;
drop table tblHopdong;

insert into tblSanPham(MaSP, TenSP, Anhminhhoa, MaMau, ManoiSX, Soluong, Dongianhap, Dongiathue, MaLoaiSP) values ('SP01', 'Ao cuoi', '', 'Mau trang', 'NSX01', 10, 20000000, 5000000, 'LSP01')
insert into tblSanPham(MaSP, TenSP, Anhminhhoa, MaMau, ManoiSX, Soluong, Dongianhap, Dongiathue, MaLoaiSP) values ('SP02', 'Vest', '', 'Mau den', 'NSX02', 30, 3000000, 500000, 'LSP02')
insert into tblHoaDonNhap(MaHDN, NgayNhap, MaNV, MaNCC, Tongtien) values ('HDN01', '3/2/2020', 'NV01', 'NCC01', 5000000)
insert into tblHoaDonNhap(MaHDN, NgayNhap, MaNV, MaNCC, Tongtien) values ('HDN02', '5/7/2020', 'NV02', 'NCC02', 10000000)
insert into tblHoaDonNhap(MaHDN, NgayNhap, MaNV, MaNCC, Tongtien) values ('HDN03', '3/5/2020', 'NV03', 'NCC03', 3000000)
insert into tblHoaDonNhap(MaHDN, NgayNhap, MaNV, MaNCC, Tongtien) values ('HDN04', '6/2/2020', 'NV04', 'NCC04', 6000000)
insert into tblHoaDonNhap(MaHDN, NgayNhap, MaNV, MaNCC, Tongtien) values ('HDN05', '6/2/2020', 'NV05', 'NCC05', 8000000)
insert into tblHopdong(MaHD, MaKHach, MaNV, NgayHD, Khuyenmai, TamUng) values ('HD01', 'KH01', 'NV01', '2/1/2020', '50000', 500000)
insert into tblHopdong(MaHD, MaKHach, MaNV, NgayHD, Khuyenmai, TamUng) values ('HD02', 'KH02', 'NV02', '2/2/2020', '100000', 1000000)
insert into tblThanhtoanHD(MaThanhtoan, MaHD, MaNV, Ngaythanhtoan, Tongtien, SotienThanhtoan) values ('TT01', 'HD01', 'NV01', '3/3/2020', 6000000, '' )
insert into tblThanhtoanHD(MaThanhtoan, MaHD, MaNV, Ngaythanhtoan, Tongtien, SotienThanhtoan) values ('TT02', 'HD02', 'NV02', '3/4/2020', 50000000, '' )
insert into tblChitietHDN(MaHDN, MaSP, SoLuong, DonGia, Thanhtien)
values('HDN01','SP01', 2,20000000,'')
insert into tblChitietHDN(MaHDN, MaSP, SoLuong, DonGia, Thanhtien)
values('HDN02','SP02', 5,3000000,'')
insert into tblNhaCungCap(MaNCC, TenNCC, DiaChi, DienThoai)
values('NCC01', 'Đai li Viêt Hưng', 'Thanh Xuan', '0123297456')
insert into tblNhaCungCap(MaNCC, TenNCC, DiaChi, DienThoai)
values('NCC02', 'Đai li Lan Anh', 'Nguyen Ngoc Nai', '0962272292')
insert into tblNhanVien(MaNV, TenNV, DiaChi, DienThoaiCD, DienThoaiDD, MaCM)values('NV01', 'Ha Thi Mai Anh', 'Nguyen Ngoc Nai', '0123456789','0961274494', 'V1')
insert into tblNhanVien(MaNV, TenNV, DiaChi, DienThoaiCD, DienThoaiDD, MaCM)values('NV02', 'Tran Thi ngoc', 'Dinh Cong', '0373123456','0973463959', 'V2')
insert into tblKhachHang(MaKHach, TenKhach, SoCMTND, DiaChi, DienThoaiKhach)values('KH01', 'Nguyen Van A', '03450067', 'Ba Dinh', '0963464878' )
insert into tblKhachHang(MaKHach, TenKhach, SoCMTND, DiaChi, DienThoaiKhach)values('KH02', 'Nguyen Van B', '03450068', 'Dong Da', '0963255595')
insert into tblLoaiSP(MaLoaiSP, TenLoaiSP)
values('LSP01','Loai 1')
insert into tblLoaiSP(MaLoaiSP, TenLoaiSP)
values('LSP02','Loai 2')
insert  into tblNoiSanXuat(ManoiSX, TennoiSX)
values('NSX01','Viet Phuong')
insert  into tblNoiSanXuat(MaNoiSX, TenNoiSX)
values('NSX02','Viet Phuong')
insert  into tblMau(MaMau, TenMau)
values('Mau01','Trang')
insert  into tblMau(MaMau, TenMau)
values('Mau02','Den')
insert into tblChitietHDong(MaHD,MaSP,SoLuong,NgayThue,ChuaTra) values('HD01','SP01',5,'10/02/2020','1')
insert into tblChitietHDong(MaHD,MaSP,SoLuong,NgayThue,ChuaTra) values('HD02','SP02',20,'05/07/2019','0')
insert into tblChitietHDong(MaHD,MaSP,SoLuong,NgayThue,ChuaTra) values('HD03','SP03',15,'12/12/2019','1')
insert into tblChitietHDong(MaHD,MaSP,SoLuong,NgayThue,ChuaTra) values('HD04','SP04',25,'11/11/2019','0')
 
 Select*from tblChitietHDong