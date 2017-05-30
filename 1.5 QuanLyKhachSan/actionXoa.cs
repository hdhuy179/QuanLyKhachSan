using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_QuanLyKhachSan
{
    class actionXoa
    {
        public void action_Xoa(int action, frmMain frm)
        {
            string sql = "";
            if (action == 1)
            {
                sql = "select * from tblDatPhong_Phong where IDPhong = " + frm.txtMaPhong_Phong.Text;
                DataTable dt = sqlCommand.doSQLCommand(sql);
                if (dt.Rows.Count >= 1)
                {
                    sql = "delete tblDatPhong_Phong where IDPhong = " + frm.txtMaPhong_Phong.Text +
                        "\ndelete tblPhong where IDPhong = " + frm.txtMaPhong_Phong.Text;
                }
                else
                {
                    sql = "delete tblPhong where IDPhong = " + frm.txtMaPhong_Phong.Text;
                }
            }
            else if (action == 2)
            {
                sql = "delete tblLoaiPhong_NoiThat where IDLoaiPhong = " + frm.cbbLoaiPhong_NoiThat.SelectedValue.ToString() +
                    "and IDNoiThat = " + frm.txtMaNoiThat_NoiThat.Text;
            }
            else if (action == 3)
            {
                sql = "delete tblKhachHang where IDKhachHang = " + frm.txtMaKhachHang_KhachHang.Text;
            }
            else if (action == 4)
            {
                sql = "select * from tblDatPhong_Phong where IDHoaDon = " + frm.txtMaHoaDon_ThuePhong.Text;
                DataTable dt = sqlCommand.doSQLCommand(sql);
                if (dt.Rows.Count == 1)
                {
                    sql = "delete tblDatPhong_Phong where IDHoaDon = " + frm.txtMaHoaDon_ThuePhong.Text +
                        " and IDPhong = " + frm.txtMaPhong_ThuePhong.Text +
                        "\ndelete tblDatPhong where IDHoaDon = " + frm.txtMaHoaDon_ThuePhong.Text;
                }
                else if (dt.Rows.Count > 1)
                {
                    sql = "delete tblDatPhong_Phong where IDHoaDon = " + frm.txtMaHoaDon_ThuePhong.Text +
                        " and IDPhong = " + frm.txtMaPhong_ThuePhong.Text;
                }
            }
            else if (action == 5)
            {
                sql = "delete tblDatPhong_Phong_DichVu where IDHoaDon = " + frm.txtMaHoaDon_DichVu.Text +
                    " and IDPhong = " + frm.txtMaPhong_DichVu.Text +
                    " and IDDichVu = " + frm.cbbMaDichVu_DichVu.SelectedValue.ToString();
            }
            sqlCommand.NonSQLCommand(sql);
            frm.getData("");
        }
    }
}
