using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB
{
    class SanbayDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public SanbayDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllSanbay()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            //string sql = "SELECT * FROM SANBAY";
            string sql = "SELECT MASB[Mã sân bay], TENSANBAY[Tên sân bay], TINHTRANG[Tình trạng] FROM SANBAY";
            //B2: Tạo một kết nối đến Sql
            SqlConnection con = dc.GetConnect();
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql,con);
            //B4: Mở kết nối
            con.Open();
            //B5: Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: Đóng kết nối
            con.Close();
            return dt;
        }

        public DataTable getallSanbay_hoatdong()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT MASB[Mã sân bay], TENSANBAY[Tên sân bay],TINHTRANG[Tình trạng] FROM SANBAY WHERE TINHTRANG=N'Hoạt động'";
            //B2: Tạo một kết nối đến Sql
            SqlConnection con = dc.GetConnect();
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4: Mở kết nối
            con.Open();
            //B5: Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: Đóng kết nối
            con.Close();
            return dt;
        }




        public bool InsertSanbay(Sanbay sb)
        {
            string sql = "INSERT INTO SANBAY(MASB, TENSANBAY,TINHTRANG) VALUES(@MASB, @TENSB,@TINHTRANG)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASB", SqlDbType.VarChar).Value = TaoMaSanBay();
                cmd.Parameters.Add("@TENSB", SqlDbType.NVarChar).Value = sb.tensb;
                cmd.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = sb.tinhtrang;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateSanbay(Sanbay sb)
        {
            string sql = "UPDATE SANBAY SET TENSANBAY=@TENSANBAY, MASB=@MASB, TINHTRANG=@TINHTRANG WHERE MASB=@MASB";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENSANBAY", SqlDbType.NVarChar).Value = sb.tensb;
                cmd.Parameters.Add("@MASB", SqlDbType.VarChar).Value = sb.masb;
                cmd.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = sb.tinhtrang;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteSanbay(Sanbay sb)
        {
            string sql = "UPDATE SANBAY SET TINHTRANG=N'Không hoạt động' WHERE MASB = @MASB";
            //string sql = "INSERT INTO FOOD(NAME, IDCATEGORY, PRICE) VALUES(@NAME, @IDCATEGORY, @PRICE)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASB", SqlDbType.VarChar).Value = sb.masb;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        //--------------------------------
        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT MASB, TENSANBAY FROM SANBAY ORDER BY MASB DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMaSanBay()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "SB000" + dt.Rows.Count;
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
            return "SB" + strSoKhong + count;
        }


        public DataTable GetSL_SB_Hoat_Dong()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT COUNT(*) AS SL FROM SANBAY WHERE TINHTRANG=N'Hoạt động'";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
