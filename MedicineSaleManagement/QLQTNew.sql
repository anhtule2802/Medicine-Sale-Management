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
create table NCC
(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(50) not null,
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


create table DonThuoc
(
	MaDonThuoc varchar(10) primary key,
	MaBacSi varchar(10) references BacSi(MaBacSi),
	MaBenhNhan varchar(10) references BenhNhan(MaBenhNhan),
	NgayKe Date not null,
	MoTaBenh nvarchar(50) not null,
)

create table CTDonThuoc
(
	MaDonThuoc varchar(10) references DonThuoc(MaDonThuoc),
	MaThuoc varchar(10) references Thuoc(MaThuoc),
	SoLuong int not null,
	DVT varchar(10) not null,
	GhiChu nvarchar(100),
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
create table QuanLy
(
	MaNQL varchar(10) Primary Key,
	TenNQL varchar(30),
)
create table TaiKhoan
(
	Username varchar(16) Primary Key,
	Pass varchar(16),
	LoaiTK varchar(4),
	MaNhanVien varchar(10) References NhanVien(MaNhanVien),
	MaBacSi varchar(10) References bacSi(MaBacSi),	
	MaNQL varchar(10) references QuanLy(MaNQL),
)



set dateformat dmy
insert into LoaiThuoc values('1', 'Ho')
insert into LoaiThuoc values('2', 'Cam')
insert into LoaiThuoc values('3', 'Giam dau')
insert into LoaiThuoc values('4', 'Ha sot')
insert into LoaiThuoc values('5', 'Tang huyet ap')
insert into LoaiThuoc values('6', 'An than')
insert into LoaiThuoc values('7', 'Chong non')

insert into Thuoc values('1', '1', 'Eugica', 'Dung truong hop ho', 1)
insert into Thuoc values('2', '2', 'Cold & flu', 'Dung truong hop cam', 1)
insert into Thuoc values('3', '2', 'Panadol', 'Dung truong hop cam cum', 1)
insert into Thuoc values('4', '3', 'Paracetamol', 'Dung de giam dau', 1)
insert into Thuoc values('5', '3', 'Meloxicam', 'Dung de giam dau', 1)
insert into Thuoc values('6', '4', 'Nimesulid', 'Dung de ha sot', 1)
insert into Thuoc values('7', '5', 'Amlodipin', 'Dung truong hop tang huyet ap', 1)
insert into Thuoc values('8', '6', 'Lexomil', 'Dung de an than', 1)
insert into Thuoc values('9', '7', 'Domperidon', 'Dung de chong non', 1)
insert into Thuoc values('10', '7', 'Dimenhydrinat', 'Dung de chong non', 1)

insert into NCC values('1', 'NCCA')
insert into NCC values('2', 'NCCB')
insert into NCC values('3', 'NCCC')
insert into NCC values('4', 'NCCD')

insert into LoThuoc values('1', '1', '1', 'Hop', '10/10/2010', '09/03/2018', 50, 30000, 1)
insert into LoThuoc values('2', '2', '1', 'Hop', '05/05/2010', '10/10/2018', 30, 20000, 1)
insert into LoThuoc values('3', '3', '2', 'Hop', '05/09/2010', '10/12/2018', 10, 15000, 1)
insert into LoThuoc values('4', '2', '3', 'Lo', '10/28/2016', '04/28/2020', 25, 50000, 1)
insert into LoThuoc values('5', '2', '4', 'Hop', '09/28/2017', '03/28/2022', 40, 20000, 1)
insert into LoThuoc values('6', '8', '4', 'Lo', '02/28/2017', '08/28/2021', 30, 30000, 1)
insert into LoThuoc values('7', '7', '4', 'Lo', '05/06/2018', '11/06/2024', 20, 25000, 1)
insert into LoThuoc values('8', '5', '3', 'Hop', '12/24/2017', '06/24/2022', 20, 20000, 1)
insert into LoThuoc values('9', '9', '2', 'Hop', '03/10/2016', '09/10/2022', 40, 10000, 1)
insert into LoThuoc values('10', '6', '2', 'Lo', '10/30/2015', '04/30/2020', 30, 40000, 1)
insert into LoThuoc values('11', '4', '3', 'Hop', '10/26/2017', '04/26/2022', 10, 50000, 1)
insert into LoThuoc values('12', '10', '1', 'Hop', '11/11/2016', '05/11/2021', 40, 20000, 1)


insert into BacSi values('1', 'Nguyen Van A', 'Da Khoa', 'nam', '0123456789', 'TP HCM', 'A@gmail.com')
insert into BacSi values('2', 'Nguyen Thi B', 'Nha Khoa', 'nu', '0123456789', 'Long An', 'B@gmail.com')
insert into BacSi values('3', 'Nguyen Thi C', 'Chinh Hinh', 'nu', '0123456789', 'Long An', 'C@gmail.com')
insert into BacSi values('4', 'Le Van D', 'Than Kinh', 'nam', '0378667650', 'Long An', 'D@gmail.com')
insert into BacSi values('5', 'Pham Thi E', 'Tim Mach', 'nu', '0345009879', 'Long An', 'E@gmail.com')

insert into BenhNhan values('1', 'BN A', 1998, 'Nam', '0123456789', 'Long An')
insert into BenhNhan values('2', 'BN B', 2000, 'Nu', '0123456789', 'TP HCM')
insert into BenhNhan values('3', 'BN C', 2001, 'Nam', '0123456789', 'TP HCM')
insert into BenhNhan values('4', 'BN D', 2002, 'Nam', '0333456657', 'Đà Lạt')
insert into BenhNhan values('5', 'BN E', 2000, 'Nu', '0321098556', 'Đồng Nai')
insert into BenhNhan values('6', 'BN F', 2000, 'Nu', '0321098556', 'Đồng Tháp')
insert into BenhNhan values('7', 'BN G', 2003, 'Nu', '0321098556', 'Nha Trang')
insert into BenhNhan values('8', 'BN H', 2004, 'Nu', '0321098556', 'Vũng Tàu')

insert into DonThuoc values('1', '1', '1', '04/05/2005', 'Bi Cam')
insert into DonThuoc values('2', '2', '1', '04/05/2005', 'Bi Sau Rang')
insert into DonThuoc values('3', '2', '3', '04/12/2006', 'Tram Rang')
insert into DonThuoc values('4', '3', '2', '12/12/2006', 'Trat khop')
insert into DonThuoc values('5', '3', '3', '10/20/2006', 'Gay tay')
insert into DonThuoc values('6', '4', '4', '04/01/2006', 'Tram cam')
insert into DonThuoc values('7', '4', '5', '02/10/2007', 'Roi loan than kinh')
insert into DonThuoc values('8', '5', '6', '08/03/2010', 'Tang huyet ap')
insert into DonThuoc values('9', '1', '7', '04/10/2012', 'Sot cao')
insert into DonThuoc values('10', '1', '8', '03/22/2015', 'Ho')

insert into CTDonThuoc values('1', '1', 20, 'hop','')
insert into CTDonThuoc values('1', '2', 20, 'hop','')
insert into CTDonThuoc values('2', '1', 2, 'hop','')
insert into CTDonThuoc values('3', '1', 10, 'hop','')
insert into CTDonThuoc values('4', '4', 1, 'hop','')
insert into CTDonThuoc values('5', '4', 1, 'hop','')
insert into CTDonThuoc values('6', '8', 2, 'lo','')
insert into CTDonThuoc values('7', '8', 5, 'lo','')
insert into CTDonThuoc values('8', '7', 2, 'lo','')
insert into CTDonThuoc values('9', '6', 3, 'lo','')
insert into CTDonThuoc values('10', '1', 2, 'hop','')

insert into NhanVien values ('1', 'NVA', 'Nam', '0123456789', 'TPHCM', 'NVA@gmail.com', 1)
insert into NhanVien values ('2', 'NVB', 'Nu', '0123456789', 'Hà Nội', 'NVB@gamil.com', 1)
insert into NhanVien values ('3', 'NVC', 'Nam', '0123456789', 'Đà Nẵng', 'NVCgmail.com', 1)
insert into NhanVien values ('4', 'NVD', 'Nu', '0123456789', 'Hải Phòng', 'NVD@gmail.com', 1)
insert into NhanVien values ('5', 'NVE', 'Nam', '0123456789', 'Cần Thơ', 'NVE@gmail.com', 1)
insert into NhanVien values ('6', 'NVF', 'Nam', '0123456789', 'Vũng Tàu', 'NVF@gmail.com', 1)
insert into NhanVien values ('7', 'NVG', 'Nu', '0123456789', 'Cần Giờ', 'NVG@gmail.com', 1)
insert into NhanVien values ('8', 'NVH', 'Nu', '0123456789', 'An Giang', 'NVH@gmail.com', 1)
insert into NhanVien values ('9', 'NVI', 'Nu', '0123456789', 'Bình Thuận', 'NVI@gmail.com', 1)
insert into NhanVien values ('10', 'NVK', 'Nam', '0123456789', 'Tiền Giang', 'NVK@gmail.com', 1)

insert into QuanLy values('1','Le Anh Tu')
insert into QuanLy values('2','Thanh Tung')
insert into QuanLy values('3','Tuan Kiet')

insert into NVBanThuoc values('1', '05/06/2018', 'Sáng')
insert into NVBanThuoc values('3', '06/07/2018', 'Chiều')
insert into NVBanThuoc values('4', '07/08/2018', 'Tối')
insert into NVBanThuoc values('6', '07/08/2018', 'Chiều')
insert into NVBanThuoc values('9', '28/08/2018', 'Tối')

insert into NVThongKe values ('2', '05/05/2015')
insert into NVThongKe values ('5', '02/03/2018')
insert into NVThongKe values('7', '07/08/2018')
insert into NVThongKe values('8', '20/08/2018')
insert into NVThongKe values('10', '07/08/2018')

insert into TaiKhoan values('bsa','bsa123','BS','1','1','1')
insert into TaiKhoan values('nva','nva123','NVBH','1','1','1')
insert into TaiKhoan values('nvb','nvb123','NVTK','2','1','1')
insert into TaiKhoan values('qltung','qltung123','QL','1','2','1')

--go
--create trigger SetTinhTrang1 on LoThuoc
--for update
--as 
--	if exists(select * from inserted i join deleted d on i.MaLoThuoc = d.MaLoThuoc)
--		begin
--			update LoThuoc
--			set TrangThai = 0
--			from LoThuoc lt join inserted i on lt.MaLoThuoc = i.MaLoThuoc
--			where lt.SoLuong = 0 and lt.TrangThai = 1
--		end


--select * from [LoThuoc]inserted
--select * from [LoThuoc]deleted