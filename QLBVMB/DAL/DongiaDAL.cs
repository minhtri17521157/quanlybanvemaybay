using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class DongiaDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public DongiaDAL()
        {
            dc = new DataConnection();
        }

        public DataTable Get()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT* FROM DONGIA";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetForDisplay()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT DONGIA[Đơn giá] FROM DONGIA";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();

            string sqlQuery = "SELECT * FROM DONGIA ORDER BY MADG DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private string TaoMaDG()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "DG000" + dt.Rows.Count;
            DataRow row = dt.Rows[0];
            string maTuyenBay = row[0].ToString().Substring(2);
            int count = int.Parse(maTuyenBay) + 1;
            int temp = count;
            string strSoKhong = "";
            int dem = 0;
            while (temp > 0)
            {
                temp /= 10;
                dem++;
            }
            for (int i = 0; i < 4 - dem; i++)
            {
                strSoKhong += "0";
            }
            return "DG" + strSoKhong + count;
        }

        public bool InsertDongia(DTO.Dongia dg)
        {
            string sql = "INSERT INTO DONGIA(MADG, MATB, MAHV, DONGIA) VALUES(@MADG, @MATB,@MAHV,@DONGIA)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MADG", SqlDbType.VarChar).Value = TaoMaDG();
                //cmd.Parameters.Add("@MATB", SqlDbType.VarChar).Value = dg.matb;
                //cmd.Parameters.Add("@MAHV", SqlDbType.VarChar).Value = dg.mahv;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Decimal).Value = dg.dongia;
                


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateDongia(DTO.Dongia dg)
        {
            string sql = "UPDATE DONGIA SET MATB=@MATB, MAHV=@MAHV, DONGIA=@DONGIA WHERE MADG=@MADG";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MADG", SqlDbType.VarChar).Value = dg.madg;
               // cmd.Parameters.Add("@MATB", SqlDbType.VarChar).Value = dg.matb;
                //cmd.Parameters.Add("@MAHV", SqlDbType.VarChar).Value = dg.mahv;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Decimal).Value = dg.dongia;



                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteDongia(DTO.Dongia dg)
        {
            string sql = "DELETE DONGIA WHERE MADG = @MADG";

            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MADG", SqlDbType.VarChar).Value = dg.madg;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public DataTable SearchDGbymaDG(string str)
        {
            SqlConnection con = dc.GetConnect();

            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT * FROM DONGIA WHERE MADG='{0}' ", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            return dt;
        }

    }
}
