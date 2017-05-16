create database QuanLyKhachSan
go

use QuanLyKhachSan
go

create table tblDangNhap(
TaiKhoan char(100),
MatKhau varchar(100),
primary key (TaiKhoan)
)
create table tblDichVu(
IDDichVu int,
TenDichVu nvarchar(100),
Gia int,
primary key (IDDichVu)
)
create table tblKhachHang(
IDKhachHang int,
TenKhachHang nvarchar(200),
GioiTinh nvarchar(3),
DiaChi nvarchar(200),
NgaySinh date,
SoCMND int,
SDT varchar(30),
Email varchar(200)
primary key (IDKhachHang)
)
create table tblNoiThat(
IDNoiThat int,
TenNoiThat nvarchar(100),
primary key (IDNoiThat)
)
create table tblLoaiPhong(
IDLoaiPhong int,
TenLoaiPhong nvarchar(50),
Gia int,
primary key (IDLoaiPhong)
)

create table tblPhong(
IDPhong int,
PhongSo nvarchar(20),
IDLoaiPhong int,
primary key (IDPhong),
foreign key(IDLoaiPhong) references tblLoaiPhong(IDLoaiPhong)
)
create table tblLoaiPhong_NoiThat(
IDLoaiPhong int,
IDNoiThat int,
SoLuong int,
primary key (IDLoaiPhong,IDNoiThat),
foreign key(IDLoaiPhong) references tblLoaiPhong(IDLoaiPhong),
foreign key(IDNoiThat) references tblNoiThat(IDNoiThat)
)

create table tblDatPhong(
IDHoaDon int,
NgayDatPhong date,
IDKhachHang int,
primary key (IDHoaDon),
foreign key(IDKhachHang) references tblKhachHang(IDKhachHang)
)
create table tblDatPhong_Phong(
IDHoaDon int,
IDPhong int,
SoGio int,
primary key (IDHoaDon,IDPhong),
foreign key(IDHoaDon) references tblDatPhong(IDHoaDon),
foreign key(IDPhong) references tblPhong(IDPhong),
)

create table tblDatPhong_Phong_DichVu(
IDHoaDon int,
IDPhong int,
IDDichVu int,
primary key (IDHoaDon,IDPhong,IDDichVu),
foreign key(IDHoaDon,IDPhong) references tblDatPhong_Phong(IDHoaDon,IDPhong),
foreign key(IDDichVu) references tblDichVu(IDDichVu)
)
