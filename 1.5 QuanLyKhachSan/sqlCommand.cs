using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._5_QuanLyKhachSan
{
    class sqlCommand
    {
        public static void NonSQLCommand(string sql)
        {
            try
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(sql);
            }
            finally
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Close();
            }
        }

        public static DataTable doSQLCommand(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataAdapter com = new SqlDataAdapter(command);
                com.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(sql);
            }
            finally
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Close();
            }
            return dt;
        }
    }
}
