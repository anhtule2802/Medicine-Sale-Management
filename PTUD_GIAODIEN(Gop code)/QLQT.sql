create database QLQT
use QLQT
create table LoaiThuoc
(
	MaLoaiThuoc varchar(10) primary key,
	TenLoaiThuoc nvarchar(30) not null
)
create table Thuoc
(
	MaThuoc varchar(10) primary key,
	MaLoaiThuoc varchar(10) references LoaiThuoc(MaLoaiThuoc),
	TenThuoc nvarchar(50) not null,
	MoTa nvarchar(50),
	TrangThai int not null
)
create table LoThuoc
(
	MaLoThuoc varchar(10) primary key,
	MaThuoc varchar(10) references Thuoc(MaThuoc),
	MaNCC varchar(10) references NCC(MaNCC),
	DVT nvarchar(10) not null,
	NgayNhap Date not null,
	NgayHetHan Date not null,
	SoLuong int not null,
	DonGia money not null,
	TrangThai int not null
)
create table NCC
(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(50) not null,
)
create table HoaDon
(
	MaHoaDon varchar(10) primary key,
	MaNhanVien varchar(10) references NVBanThuoc(MaNhanVien),
	MaDonThuoc varchar(10) references DonThuoc(MaDonThuoc),
	MaBenhNhan varchar(10) references BenhNhan(MaBenhNhan),
	TongTien money not null,
	NgayLapHD date not null
)

create table CTHoaDon
(
	MaHoaDon varchar(10) references HoaDon(MaHoaDon),
	MaLoThuoc varchar (10) references LoThuoc(MaLoThuoc),
	DVT nvarchar(10) not null,
	SoLuong int not null,
	GiaBan money not null,
	primary key(MaHoaDon, MaLoThuoc)
)

create table BacSi
(
	MaBacSi varchar(10) primary key,
	TenBacSi nvarchar(50) not null,
	Khoa nvarchar(50) not null,
	GioiTinh nvarchar(5) not null,
	SDT varchar(12) not null,
	DiaChi nvarchar(50) not null,
	Email varchar(50) not null
)
create table BenhNhan
(
	MaBenhNhan varchar(10) primary key,
	TenBenhNhan nvarchar(50) not null,
	NamSinh int not null,
	GioiTinh nvarchar(5) not null,
	SDT varchar(12) not null,
	DiaChi nvarchar(50) not null,
)
create table DonThuoc
(
	MaDonThuoc varchar(10) primary key,
	MaBacSi varchar(10) references BacSi(MaBacSi),
	MaBenhNhan varchar(10) references BenhNhan(MaBenhNhan),
	NgayKe Date not null,
	MoTaBenh nvarchar(50) not null,
	GhiChu nvarchar(100),
)

create table CTDonThuoc
(
	MaDonThuoc varchar(10) references DonThuoc(MaDonThuoc),
	MaThuoc varchar(10) references Thuoc(MaThuoc),
	SoLuong int not null,
	DVT varchar(10) not null,
	primary key(MaDonThuoc, MaThuoc)
)
create table NhanVien
(
	MaNhanVien varchar(10) primary key,
	TenNhanVien nvarchar(50) not null,
	GioiTinh nvarchar(5) not null,
	SDT varchar(12) not null,
	DiaChi nvarchar(50) not null,
	Email varchar(30) not null,
	TinhTrang int not null
)
create table NVBanThuoc
(
	MaNhanVien varchar(10) references NhanVien(MaNhanVien),
	NgayLamViec Date not null,
	CaLamViec nvarchar(10) not null,
	primary key(MaNhanVien)
)
create table NVThongKe
(
	MaNhanVien varchar(10) references NhanVien(MaNhanVien),
	NgayLamViec Date not null,
	primary key(MaNhanVien)
)



set dateformat dmy
insert into LoaiThuoc values('1', 'Ho')
insert into LoaiThuoc values('2', 'Cam')
insert into Thuoc values('1', '1', 'Eugica', 'Dung truong hop ho', 1)
insert into Thuoc values('2', '2', 'Cold & flu', 'Dung truong hop cam', 1)
insert into Thuoc values('3', '2', 'Panadol', 'Dung truong hop cam cum', 1)
insert into NCC values('1', 'NCCA')
insert into NCC values('2', 'NCCB')
insert into LoThuoc values('1', '1', '1', 'Hop', '10/10/2010', '09/03/2018', 50, 30000, 1)
insert into LoThuoc values('2', '2', '1', 'Hop', '05/05/2010', '10/10/2018', 30, 20000, 1)
insert into LoThuoc values('3', '3', '2', 'Hop', '05/09/2010', '10/12/2018', 10, 15000, 1)


insert into BacSi values('1', 'Nguyen Van A', 'Da Khoa', 'nam', '0123456789', 'Ho Chi Minh', 'A@gmail.com')
insert into BacSi values('2', 'Nguyen Thi B', 'Nha Khoa', 'nu', '0123456789', 'Ha Noi', 'B@gmail.com')
insert into BacSi values('3', 'Nguyen Thi C', 'Chinh Hinh', 'nu', '0123456789', 'Da Nang', 'C@gmail.com')

insert into BenhNhan values('1', 'BN A', 1998, 'nam', '0123456789', 'Long An')
insert into BenhNhan values('2', 'BN B', 1989, 'nu', '0123456789', 'Thu Duc')
insert into BenhNhan values('3', 'BN C', 2011, 'nam', '0123456789', 'TP HCM')

insert into DonThuoc values('HD001', '1', '1', '04/05/1989', 'Bi Cam', 'Uong thuong xuyen')
insert into DonThuoc values('HD002', '2', '1', '04/05/1989', 'Bi Sau Rang', 'Uong thuong xuyen')
insert into DonThuoc values('HD003', '2', '3', '04/12/1989', 'Tram Rang', 'Uong thuong xuyen')

insert into CTDonThuoc values('HD001', '1', 20, 'hop')
insert into CTDonThuoc values('HD001', '2', 20, 'hop')
insert into CTDonThuoc values('HD002', '1', 2, 'hop')
insert into CTDonThuoc values('HD003', '3', 20, 'hop')

insert into NhanVien values ('1', 'NVA', 'nam', '0123456789', 'TP HCM', 'NVA@gmail.com', 1)
insert into NhanVien values ('2', 'NVB', 'nu', '0123456789', 'Ha Noi', 'NVB@gamil.com', 1)
insert into NhanVien values ('3', 'NVC', 'nam', '0123456789', 'Da Nang', 'NVCgmail.com', 1)
insert into NhanVien values ('4', 'NVD', 'nu', '0123456789', 'Hai Phong', 'NVD@gmail.com', 1)
insert into NhanVien values ('5', 'NVE', 'nam', '0123456789', 'Can Tho', 'NVE@gmail.com', 1)


insert into NVBanThuoc values('1', '05/06/2018', 'Sang')
insert into NVBanThuoc values('3', '06/07/2018', 'Chieu')
insert into NVBanThuoc values('4', '07/08/2018', 'Toi')

insert into NVThongKe values ('2', '05/05/2015')
insert into NVThongKe values ('5', '02/03/2018')