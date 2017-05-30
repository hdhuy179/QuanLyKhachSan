using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._5_QuanLyKhachSan
{
    class actionThem
    {
        public void action_Them(int action,frmMain frm)
        {
            string sql = "";
            if (action == 1)
            {
                sql = "insert into tblPhong(IDPhong,PhongSo,IDLoaiPhong) values(" + frm.txtMaPhong_Phong.Text + "," + frm.txtPhongSo_Phong.Text + "," + frm.cbbLoaiPhong_Phong.SelectedValue.ToString() + ")";
            }
            else if (action == 2)
            {
                sql = "select * from tblNoiThat where IDNoiThat = " + frm.txtMaNoiThat_NoiThat.Text;
                DataTable dt = sqlCommand.doSQLCommand(sql);
                if (dt.Rows.Count == 1)
                {
                    sql = "insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(" + frm.cbbLoaiPhong_NoiThat.SelectedValue.ToString() + "," + frm.txtMaNoiThat_NoiThat.Text + "," + frm.txtSoLuongNoiThat_NoiThat.Text + ")";
                    sqlCommand.NonSQLCommand(sql);
                }
                else
                {
                    DialogResult hoi;
                    hoi = MessageBox.Show("Nội thất này không tồn tại. Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hoi == DialogResult.Yes)
                    {
                        sql = "insert into tblNoiThat(IDNoiThat,TenNoiThat) values(" + frm.txtMaNoiThat_NoiThat.Text + ",'" + frm.txtTenNoiThat_NoiThat.Text + "')\n"
                            + "insert into tblLoaiPhong_NoiThat(IDLoaiPhong,IDNoiThat,SoLuong) values(" + frm.cbbLoaiPhong_NoiThat.SelectedValue.ToString() + "," + frm.txtMaNoiThat_NoiThat.Text + "," + frm.txtSoLuongNoiThat_NoiThat.Text + ")";
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (action == 3)
            {
                string GioiTinh = "null";
                if (frm.rbtnNam.Checked == true) GioiTinh = "Nam";
                else if (frm.rbtnNu.Checked == true) GioiTinh = "Nu";
                sql = "insert into tblKhachHang(IDKhachHang,TenKhachHang,GioiTinh,DiaChi,NgaySinh,SoCMND,SDT,Email) values(" + frm.txtMaKhachHang_KhachHang.Text + ",'" + frm.txtTenKhachHang_KhachHang.Text + "','" + GioiTinh + "','" + frm.txtDiaChi_KhachHang.Text + "','" + frm.dtpNgaySinh_KhachHang.Value.ToString("yyyy/MM/dd") + "'," + frm.txtSoCMND_KhachHang.Text + "," + frm.txtSDT_KhachHang.Text + ",'" + frm.txtEmail_KhachHang.Text + "')";
            }
            else if (action == 4)
            {
                sql = "select * from tblDatPhong where IDHoaDon = " + frm.txtMaHoaDon_ThuePhong.Text;
                DataTable dt = sqlCommand.doSQLCommand(sql);
                if (dt.Rows.Count == 1)
                {
                    sql = "insert into tblDatPhong_Phong(IDHoaDon, IDPhong, SoGio) values(" + frm.txtMaHoaDon_ThuePhong.Text + ", " + frm.txtMaPhong_ThuePhong.Text + ", " + frm.txtSoGio_ThuePhong.Text + ")";
                }
                else
                {
                    sql = "insert into tblDatPhong(IDHoaDon,IDKhachHang,NgayDatPhong) values(" + frm.txtMaHoaDon_ThuePhong.Text + "," + frm.txtMaKhachHang_ThuePhong.Text + ",'" + frm.dtpDatPhong_ThuePhong.Value.ToString("yyyy/MM/dd") + "')\n"
                    + "insert into tblDatPhong_Phong(IDHoaDon, IDPhong, SoGio) values(" + frm.txtMaHoaDon_ThuePhong.Text + ", " + frm.txtMaPhong_ThuePhong.Text + ", " + frm.txtSoGio_ThuePhong.Text + ")";

                }
            }
            else if (action == 5)
            {
                sql = "insert into tblDatPhong_Phong_DichVu(IDHoaDon,IDPhong,IDDichVu) values(" + frm.txtMaHoaDon_DichVu.Text + "," + frm.txtMaPhong_DichVu.Text + "," + frm.cbbMaDichVu_DichVu.SelectedValue.ToString() + ")";
            }
            sqlCommand.NonSQLCommand(sql);
            frm.getData("");
        }
    }
}
