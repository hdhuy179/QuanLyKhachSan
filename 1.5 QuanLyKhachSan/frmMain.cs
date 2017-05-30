using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._5_QuanLyKhachSan
{
    public partial class frmMain : Form
    {
        private int action = 0;
        public frmMain()
        {
            InitializeComponent();
        }
        public void getData(string select)
        {
            string sql = "";
            try
            {
                if (action == 1)
                {
                    sql = @"select IDPhong,PhongSo,TenLoaiPhong 
                                from tblPhong p left join tblLoaiPhong lp on p.IDLoaiPhong = lp.IDLoaiPhong where IDPhong=IDPhong";

                    sql = sql + select;

                    dgvThongTin.Columns.Clear();
                    dgvThongTin.AutoGenerateColumns = false;

                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDPhong";
                    column.HeaderText = "Mã Phòng";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "PhongSo";
                    column.HeaderText = "Phòng Số";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenLoaiPhong";
                    column.HeaderText = "Loại Phòng";
                    dgvThongTin.Columns.Add(column);
                }
                else if (action == 2)
                {
                    sql = @"select TenLoaiPhong,nt.IDNoiThat,TenNoiThat,lpnt.SoLuong 
                                from (tblLoaiPhong lp left join tblLoaiPhong_NoiThat lpnt on lp.IDLoaiPhong=lpnt.IDLoaiPhong)
                                    left join tblNoiThat nt on lpnt.IDNoiThat=nt.IDNoiThat
                                        where lp.IDLoaiPhong=lp.IDLoaiPhong";

                    sql = sql + select;

                    dgvThongTin.Columns.Clear();
                    dgvThongTin.AutoGenerateColumns = false;

                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenLoaiPhong";
                    column.HeaderText = "Loại Phòng";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDNoiThat";
                    column.HeaderText = "Mã Nội Thất";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenNoiThat";
                    column.HeaderText = "Tên Nội Thất";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "SoLuong";
                    column.HeaderText = "Số Lượng";
                    dgvThongTin.Columns.Add(column);
                }
                else if (action == 3)
                {
                    sql = @"select * from tblKhachHang where IDKhachHang=IDKhachHang";

                    sql = sql + select;

                    dgvThongTin.Columns.Clear();
                    dgvThongTin.AutoGenerateColumns = false;

                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDKhachHang";
                    column.HeaderText = "Mã Khách Hàng";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenKhachHang";
                    column.HeaderText = "Tên Khách Hàng";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "GioiTinh";
                    column.HeaderText = "Giới Tính";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "DiaChi";
                    column.HeaderText = "Địa Chỉ";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "NgaySinh";
                    column.HeaderText = "Ngày Sinh";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "SoCMND";
                    column.HeaderText = "Số CMND";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "SDT";
                    column.HeaderText = "Số ĐT";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "Email";
                    column.HeaderText = "Email";
                    dgvThongTin.Columns.Add(column);
                }
                else if (action == 4)
                {
                    sql = @"select dp.IDHoaDon,kh.IDKhachHang,TenKhachHang,SoCMND,p.IDPhong,p.PhongSo,dp.NgayDatPhong,SoGio 
                                from tblDatPhong dp left join tblDatPhong_Phong dpp on dp.IDHoaDon=dpp.IDHoaDon 
                                    left join tblKhachHang kh on dp.IDKhachHang = kh.IDKhachHang 
                                        left join tblPhong p on p.IDPhong = dpp.IDPhong
                                            where dp.IDHoaDon=dp.IDHoaDon";

                    sql = sql + select;

                    dgvThongTin.Columns.Clear();
                    dgvThongTin.AutoGenerateColumns = false;

                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDHoaDon";
                    column.HeaderText = "Mã Hóa Đơn";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDKhachHang";
                    column.HeaderText = "Mã Khách Hàng";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenKhachHang";
                    column.HeaderText = "Tên Khách Hàng";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "SoCMND";
                    column.HeaderText = "Số CMND";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDPhong";
                    column.HeaderText = "Mã Phòng";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "PhongSo";
                    column.HeaderText = "Phòng Số";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "NgayDatPhong";
                    column.HeaderText = "Ngày Đặt Phòng";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "SoGio";
                    column.HeaderText = "Số Giờ";
                    dgvThongTin.Columns.Add(column);
                }
                else if (action == 5)
                {
                    sql = @"select dp.IDHoaDon,kh.IDKhachHang,TenKhachHang,SoCMND,p.IDPhong,p.PhongSo,dv.IDDichVu,TenDichVu 
	                            from tblDatPhong dp left join tblDatPhong_Phong dpp on dp.IDHoaDon=dpp.IDHoaDon 
		                            left join tblDatPhong_Phong_DichVu dppdv on dpp.IDHoaDon = dppdv.IDHoaDon
			                            left join tblKhachHang kh on kh.IDKhachHang = dp.IDKhachHang
				                            left join tblPhong p on p.IDPhong = dpp.IDPhong
					                            left join tblDichVu dv on dppdv.IDDichVu = dv.IDDichVu
                                                    where dp.IDHoaDon= dp.IDHoaDon";

                    sql = sql + select;

                    dgvThongTin.Columns.Clear();
                    dgvThongTin.AutoGenerateColumns = false;

                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDHoaDon";
                    column.HeaderText = "Mã Hóa Đơn";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDKhachHang";
                    column.HeaderText = "Mã Khách Hàng";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenKhachHang";
                    column.HeaderText = "Tên Khách Hàng";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "SoCMND";
                    column.HeaderText = "Số CMND";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDPhong";
                    column.HeaderText = "Mã Phòng";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "PhongSo";
                    column.HeaderText = "Phòng Số";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "IDDichVu";
                    column.HeaderText = "Mã Dịch Vụ";
                    dgvThongTin.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenDichVu";
                    column.HeaderText = "Tên Dịch Vụ";
                    dgvThongTin.Columns.Add(column);
                }
                DataTable dt = sqlCommand.doSQLCommand(sql);
                dgvThongTin.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu");
                MessageBox.Show(sql);
            }
            finally
            {
                SqlConnection con = new SqlConnection();
                con.Close();
            }
        }
        private void btnPhong_Click(object sender, EventArgs e)
        {
            action = 1;
            InitializeComponent_Phong();
            getData("");
            try
            {

                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();

                string sql = "select IDLoaiPhong,TenLoaiPhong from tblLoaiPhong";
                DataTable dt = sqlCommand.doSQLCommand(sql);

                cbbLoaiPhong_Phong.DataSource = dt;
                cbbLoaiPhong_Phong.DisplayMember = dt.Columns["TenLoaiPhong"].ToString();
                cbbLoaiPhong_Phong.ValueMember = dt.Columns["IDLoaiPhong"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu");
            }
            finally
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Close();
            }
        }

        private void btnNoiThat_Click(object sender, EventArgs e)
        {
            action = 2;
            InitializeComponent_NoiThat();
            getData("");
            string sql = "select IDLoaiPhong,TenLoaiPhong from tblLoaiPhong";
            DataTable dt = sqlCommand.doSQLCommand(sql);
            cbbLoaiPhong_NoiThat.DataSource = dt;
            cbbLoaiPhong_NoiThat.DisplayMember = dt.Columns["TenLoaiPhong"].ToString();
            cbbLoaiPhong_NoiThat.ValueMember = dt.Columns["IDLoaiPhong"].ToString();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            action = 3;
            InitializeComponent_Khachhang();
            getData("");
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            action = 4;
            InitializeComponent_ThuePhong();
            getData("");
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            action = 5;
            InitializeComponent_DichVu();
            getData("");
            string sql = "select IDDichVu,TenDichVu from tblDichVu";
            DataTable dt = sqlCommand.doSQLCommand(sql);
            cbbMaDichVu_DichVu.DataSource = dt;
            cbbMaDichVu_DichVu.DisplayMember = dt.Columns["TenDichVu"].ToString();
            cbbMaDichVu_DichVu.ValueMember = dt.Columns["IDDichVu"].ToString();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            btnPhong_Click(this, e);
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (action == 1)
            {
                txtMaPhong_Phong.Text = dgvThongTin.CurrentRow.Cells[0].Value.ToString();
                txtPhongSo_Phong.Text = dgvThongTin.CurrentRow.Cells[1].Value.ToString();
                cbbLoaiPhong_Phong.Text = dgvThongTin.CurrentRow.Cells[2].Value.ToString();
            }
            else if (action == 2)
            {
                cbbLoaiPhong_NoiThat.Text = dgvThongTin.CurrentRow.Cells[0].Value.ToString();
                txtMaNoiThat_NoiThat.Text = dgvThongTin.CurrentRow.Cells[1].Value.ToString();
                txtTenNoiThat_NoiThat.Text = dgvThongTin.CurrentRow.Cells[2].Value.ToString();
                txtSoLuongNoiThat_NoiThat.Text = dgvThongTin.CurrentRow.Cells[3].Value.ToString();
            }
            else if (action == 3)
            {
                txtMaKhachHang_KhachHang.Text = dgvThongTin.CurrentRow.Cells[0].Value.ToString();
                txtTenKhachHang_KhachHang.Text = dgvThongTin.CurrentRow.Cells[1].Value.ToString();
                string gt = dgvThongTin.CurrentRow.Cells[2].Value.ToString();
                if (gt == "Nam") rbtnNam.Checked = true;
                else if (gt == "Nu") rbtnNu.Checked = true;
                txtDiaChi_KhachHang.Text = dgvThongTin.CurrentRow.Cells[3].Value.ToString();
                dtpNgaySinh_KhachHang.Text = dgvThongTin.CurrentRow.Cells[4].Value.ToString();
                txtSoCMND_KhachHang.Text = dgvThongTin.CurrentRow.Cells[5].Value.ToString();
                txtSDT_KhachHang.Text = dgvThongTin.CurrentRow.Cells[6].Value.ToString();
                txtEmail_KhachHang.Text = dgvThongTin.CurrentRow.Cells[7].Value.ToString();
            }
            else if (action == 4)
            {
                txtMaHoaDon_ThuePhong.Text = dgvThongTin.CurrentRow.Cells[0].Value.ToString();
                txtMaKhachHang_ThuePhong.Text = dgvThongTin.CurrentRow.Cells[1].Value.ToString();
                txtMaPhong_ThuePhong.Text = dgvThongTin.CurrentRow.Cells[4].Value.ToString();
                dtpDatPhong_ThuePhong.Text = dgvThongTin.CurrentRow.Cells[6].Value.ToString();
                txtSoGio_ThuePhong.Text = dgvThongTin.CurrentRow.Cells[7].Value.ToString();
            }
            else if (action == 5)
            {
                txtMaHoaDon_DichVu.Text = dgvThongTin.CurrentRow.Cells[0].Value.ToString();
                txtMaPhong_DichVu.Text = dgvThongTin.CurrentRow.Cells[4].Value.ToString();
                cbbMaDichVu_DichVu.Text = dgvThongTin.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            actionThem act = new actionThem();
            act.action_Them(action,this);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            actionSua act = new actionSua();
            act.action_Sua(action, this);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            actionXoa act = new actionXoa();
            act.action_Xoa(action, this);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            actionTimKiem act = new actionTimKiem();
            act.action_TimKiem(action, this);
        }

        private void nhaPhatTrienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaPhatTrien frm = new frmNhaPhatTrien();
            frm.ShowDialog();
        }
    }
}
