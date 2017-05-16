insert into tblDangNhap(TaiKhoan,MatKhau) values ('admin','admin')

insert into tblDichVu(IDDichVu,TenDichVu,Gia) values(1,'An Uong',10000)
insert into tblDichVu(IDDichVu,TenDichVu,Gia) values(2,'Giat Do',15000)
insert into tblDichVu(IDDichVu,TenDichVu,Gia) values(3,'Don Dep',20000)

insert into tblKhachHang(IDKhachHang,TenKhachHang,SoCMND,SDT) values(1,'Nguyen Van A',438714521,0948039614)
insert into tblKhachHang(IDKhachHang,TenKhachHang,SoCMND,SDT) values(2,'Nguyen Van B',438713497,0948039241)
insert into tblKhachHang(IDKhachHang,TenKhachHang,SoCMND,SDT) values(3,'Nguyen Van C',438754146,0948039313)
insert into tblKhachHang(IDKhachHang,TenKhachHang,SoCMND,SDT) values(4,'Nguyen Van D',436513476,0948039864)
insert into tblKhachHang(IDKhachHang,TenKhachHang,SoCMND,SDT) values(5,'Nguyen Van E',436513124,0948039856)

insert into tblKhachHang(IDKhachHang,TenKhachHang,GioiTinh,DiaChi,SoCMND,SDT) values(5,'Nguyen Van E',436513124,0948039856)

insert into tblNoiThat(IDNoiThat,TenNoiThat) values(1,'Ti vi')
insert into tblNoiThat(IDNoiThat,TenNoiThat) values(2,'Tu lanh')
insert into tblNoiThat(IDNoiThat,TenNoiThat) values(3,'Dieu hoa')
insert into tblNoiThat(IDNoiThat,TenNoiThat) values(4,'May giat')
insert into tblNoiThat(IDNoiThat,TenNoiThat) values(5,'Binh nong lanh')

insert into tblLoaiPhong(IDLoaiPhong,TenLoaiPhong,Gia) values(1,'Phong don',10000)
insert into tblLoaiPhong(IDLoaiPhong,TenLoaiPhong,Gia) values(2,'Phong doi',20000)
insert into tblLoaiPhong(IDLoaiPhong,TenLoaiPhong,Gia) values(3,'Phong vip',30000)

insert into tblPhong(IDPhong,PhongSo,IDLoaiPhong) values(1,1,1)
insert into tblPhong(IDPhong,PhongSo,IDLoaiPhong) values(2,2,2)
insert into tblPhong(IDPhong,PhongSo,IDLoaiPhong) values(3,3,1)
insert into tblPhong(IDPhong,PhongSo,IDLoaiPhong) values(4,4,3)
insert into tblPhong(IDPhong,PhongSo,IDLoaiPhong) values(5,5,1)

insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(1,1,3)
insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(2,2,2)
insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(3,3,3)
insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(1,4,1)
insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(2,5,3)
insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(3,1,1)
insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(1,2,2)
insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(2,3,3)
insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(3,4,2)

insert into tblDatPhong(IDHoaDon,IDKhachHang,NgayDatPhong) values(1,1,'2017/09/15')
insert into tblDatPhong(IDHoaDon,IDKhachHang,NgayDatPhong) values(2,2,'2017/01/27')
insert into tblDatPhong(IDHoaDon,IDKhachHang,NgayDatPhong) values(3,3,'2017/05/14')
insert into tblDatPhong(IDHoaDon,IDKhachHang,NgayDatPhong) values(4,4,'2017/02/20')
insert into tblDatPhong(IDHoaDon,IDKhachHang,NgayDatPhong) values(5,5,'2017/08/07')

insert into tblDatPhong_Phong(IDHoaDon,IDPhong,SoGio) values (1,1,12)
insert into tblDatPhong_Phong(IDHoaDon,IDPhong,SoGio) values (2,2,48)
insert into tblDatPhong_Phong(IDHoaDon,IDPhong,SoGio) values (3,3,24)

insert into tblDatPhong_Phong_DichVu(IDHoaDon,IDPhong,IDDichVu) values(1,1,1)
insert into tblDatPhong_Phong_DichVu(IDHoaDon,IDPhong,IDDichVu) values(2,2,2)
insert into tblDatPhong_Phong_DichVu(IDHoaDon,IDPhong,IDDichVu) values(3,3,3)