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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(globalParemeter.connectionString);
        }
        public DataTable checkLog(string user, string pass)
        {
            string sql = "select * from tblDangNhap where TaiKhoan= '" + user + "'and MatKhau = '" + pass + "'";

            return sqlCommand.doSQLCommand(sql);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtTaiKhoan.TextLength == 0 || this.txtMatKhau.TextLength == 0)
            {
                MessageBox.Show("Vui long dien tai khoan va mat khau");
            }
            else

            {
                DataTable dt = new DataTable();
                dt = checkLog(this.txtTaiKhoan.Text, this.txtMatKhau.Text);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dang nhap khong thanh cong");
                    this.txtTaiKhoan.Clear();
                    this.txtMatKhau.Clear();
                    this.txtTaiKhoan.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
