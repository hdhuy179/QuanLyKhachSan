using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._5_QuanLyKhachSan
{
    class actionSua
    {
        public void action_Sua(int action,frmMain frm)
        {
            string sql = "";
            if (action == 1)
            {
                sql = "update tblPhong set " +
                            "PhongSo =" + frm.txtPhongSo_Phong.Text +
                            ",IDLoaiPhong =" + frm.cbbLoaiPhong_Phong.SelectedValue.ToString() +
                            "where IDPhong = " + frm.txtMaPhong_Phong.Text;
            }
            else if (action == 2)
            {      
                MessageBox.Show("Không thể sửa nội thất trong phòng. Hãy xóa và thêm đối tượng mới");
            }
            else if (action == 3)
            {  
                string GioiTinh = "null";
                if (frm.rbtnNam.Checked == true) GioiTinh = "Nam";
                else if (frm.rbtnNu.Checked == true) GioiTinh = "Nu";
                sql = "update tblKhachHang set" +
                        "TenKhachHang = '" + frm.txtTenKhachHang_KhachHang.Text +
                        "',GioiTinh = '" + GioiTinh +
                        "',DiaChi = '" + frm.txtDiaChi_KhachHang.Text +
                        "',NgaySinh = '" + frm.dtpNgaySinh_KhachHang.Value.ToString("yyyy/MM/dd") +
                        "',SoCMND = " + frm.txtSoCMND_KhachHang.Text +
                        ",SDT = '" + frm.txtSDT_KhachHang.Text +
                        "',Email = '" + frm.txtEmail_KhachHang.Text +
                        "' where IDKhachHang = " + frm.txtMaKhachHang_KhachHang.Text;
            }
            else if (action == 4)
            {
                sql = "update tblDatPhong set " +
                        "IDKhachHang = " + frm.txtMaKhachHang_ThuePhong.Text +
                        ",NgayDatPhong = '" + frm.dtpDatPhong_ThuePhong.Value.ToString("yyyy/MM/dd") +
                        "' where IDHoaDon = " + frm.txtMaHoaDon_ThuePhong.Text
                    + "\n update tblDatPhong_Phong set" +
                    "   SoGio =" + frm.txtSoGio_ThuePhong.Text +
                    " where IDHoaDon = " + frm.txtMaHoaDon_ThuePhong.Text +
                    " and IDPhong = " + frm.txtMaPhong_ThuePhong.Text;

            }
            else if (action == 5)
            {
                MessageBox.Show("Không thể sửa dịch vu trong phòng. Hãy xóa và thêm đối tượng mới");
            }
            sqlCommand.NonSQLCommand(sql);
            frm.getData("");
        }
    }
}
