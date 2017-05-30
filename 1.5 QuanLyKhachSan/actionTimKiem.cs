using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_QuanLyKhachSan
{
    class actionTimKiem
    {
        public void action_TimKiem(int action, frmMain frm)
        {
            string sql = "";
            if (action == 1)
            {
                if (frm.txtMaPhong_Phong.Text != "") sql += " and IDPhong = " + frm.txtMaPhong_Phong.Text;
                if (frm.txtPhongSo_Phong.Text != "") sql += " and PhongSo = " + frm.txtPhongSo_Phong.Text;
                if (frm.cbLoaiPhong_Phong.Checked == true) sql += " and lp.IDLoaiPhong = " + frm.cbbLoaiPhong_Phong.SelectedValue.ToString();
            }
            else if (action == 2)
            {
                if (frm.txtMaNoiThat_NoiThat.Text != "") sql += " and nt.IDNoiThat = " + frm.txtMaNoiThat_NoiThat.Text;
                if (frm.txtTenNoiThat_NoiThat.Text != "") sql += " and TenNoiThat = '" + frm.txtTenNoiThat_NoiThat.Text + "'";
                if (frm.cbLoaiPhong_NoiThat.Checked == true) sql += " and lp.IDLoaiPhong = " + frm.cbbLoaiPhong_NoiThat.SelectedValue.ToString();
                if (frm.txtSoLuongNoiThat_NoiThat.Text != "") sql += " and lpnt.SoLuong = '" + frm.txtSoLuongNoiThat_NoiThat.Text + "'";
            }
            else if (action == 3)
            {
                if (frm.txtMaKhachHang_KhachHang.Text != "") sql += " and IDKhachHang = " + frm.txtMaKhachHang_KhachHang.Text;
                if (frm.txtTenKhachHang_KhachHang.Text != "") sql += " and TenKhachHang = '" + frm.txtTenKhachHang_KhachHang.Text + "'";
                if (frm.txtSoCMND_KhachHang.Text != "") sql += " and SoCMND = '" + frm.txtSoCMND_KhachHang.Text + "'";
                if (frm.txtDiaChi_KhachHang.Text != "") sql += " and DiaChi = '" + frm.txtDiaChi_KhachHang.Text + "'";
                if (frm.cbGioiTinh_KhachHang.Checked == true)
                {
                    if (frm.rbtnNam.Checked == true) sql += " and GioiTinh = 'Nam'";
                    else if (frm.rbtnNu.Checked == true) sql += " and GioiTinh = 'Nu'";
                }
                if (frm.txtEmail_KhachHang.Text != "") sql += " and Email = '" + frm.txtEmail_KhachHang.Text + "'";
                if (frm.txtSDT_KhachHang.Text != "") sql += " and SDT = '" + frm.txtSDT_KhachHang.Text + "'";
                if (frm.cbNgaySinh_KhachHang.Checked == true) sql += "and NgaySinh = '" + frm.dtpNgaySinh_KhachHang.Value.ToString("yyyy/MM/dd") + "'";
            }
            else if (action == 4)
            {
                if (frm.txtMaHoaDon_ThuePhong.Text != "") sql += " and dp.IDHoaDon = " + frm.txtMaHoaDon_ThuePhong.Text;
                if (frm.txtMaKhachHang_ThuePhong.Text != "") sql += " and kh.IDKhachHang = " + frm.txtMaKhachHang_ThuePhong.Text;
                if (frm.txtMaPhong_ThuePhong.Text != "") sql += " and p.IDPhong = " + frm.txtMaPhong_ThuePhong.Text;
                if (frm.txtSoGio_ThuePhong.Text != "") sql += " and SoGio = " + frm.txtSoGio_ThuePhong.Text;
                if (frm.cbNgayDatPhong_ThuePhong.Checked == true) sql += " and dp.NgayDatPhong = '" + frm.dtpDatPhong_ThuePhong.Value.ToString("yyyy/MM/dd") + "'";
            }
            else if (action == 5)
            {
                if (frm.txtMaHoaDon_DichVu.Text != "") sql += " and dp.IDHoaDon = " + frm.txtMaHoaDon_DichVu.Text;
                if (frm.txtMaPhong_DichVu.Text != "") sql += " and p.IDPhong = " + frm.txtMaPhong_DichVu.Text;
                if (frm.cbMaDichVu.Checked == true) sql += " and dv.IDDichVu = " + frm.cbbMaDichVu_DichVu.SelectedValue.ToString();
            }
            frm.getData(sql);
        }
    }
}
