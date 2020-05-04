using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class HangveDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public HangveDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getHangveKhadungbyMACB(string machuyenbay)
        {
            SqlConnection con = dc.GetConnect();
            //string sqlQuery = string.Format("SELECT * FROM HANGVE HV " +
            //    "INNER JOIN TINHTRANGVE T ON HV.MAHV=T.MAHV" +
            //    "INNER JOIN CHUYENBAY CB ON T.MACB=CB.MACB" +
            //    "WHERE CB.MACB='CB0001' AND HV.TINHTRANG=N'Khả dụng'", machuyenbay);

            string sql = string.Format( "SELECT * FROM HANGVE HV INNER JOIN TINHTRANGVE T ON HV.MAHV = T.MAHV INNER JOIN CHUYENBAY CB ON T.MACB = CB.MACB WHERE CB.MACB ='{0}'  AND HV.TINHTRANG = N'Khả dụng'",machuyenbay);

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }



        public DataTable getAllHangve()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT * FROM HANGVE ";
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

        public DataTable GetForDisplay()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT MAHV[Mã hạng vé], TENHV[Tên hạng vé], TINHTRANG[Tình trạng], TYLE[Tỷ lệ (%)] FROM HANGVE ";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT * FROM HANGVE ORDER BY MAHV DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMaHangVe()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "HV000" + dt.Rows.Count;
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
            return "HV" + strSoKhong + count;
        }

        private DataTable Get_Sort()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT COUNT(*) AS SL FROM HANGVE";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMaHangVe2()
        {
            DataTable dt = this.Get_Sort();
            DataRow row = dt.Rows[0];
        
     
            return (int.Parse(dt.Rows[0]["SL"].ToString()) + 1).ToString();
           
        }




        public bool InsertHangve(DTO.Hangve hv)
        {
            string sql = "INSERT INTO HANGVE(MAHV, TENHV, TYLE, TINHTRANG) VALUES(@MAHV, @TENHV, @TYLE, @TINHTRANG)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAHV", SqlDbType.VarChar).Value = TaoMaHangVe2();
                cmd.Parameters.Add("@TENHV", SqlDbType.NVarChar).Value = hv.tenhv;
                cmd.Parameters.Add("@TYLE", SqlDbType.Int).Value = hv.tyle;
                cmd.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = hv.tinhtrang;
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        //public bool UpdateHangve(DTO.Hangve hv)
        public bool UpdateHangve(string _mahv,string _tenhv, string _tinhtrang, string _tyle)
        {
            string sql = "UPDATE HANGVE SET TENHV=@TENHV,TINHTRANG=@TINHTRANG,TYLE=@TYLE WHERE MAHV=@MAHV";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAHV", SqlDbType.VarChar).Value =_mahv;
                cmd.Parameters.Add("@TENHV", SqlDbType.NVarChar).Value = _tenhv;
                cmd.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = _tinhtrang;
                cmd.Parameters.Add("@TYLE", SqlDbType.Int).Value = _tyle;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteHangve(DTO.Hangve hv )
        {
            string sql = "UPDATE HANGVE SET TINHTRANG=N'Không khả dụng' WHERE MAHV = @MAHV";

            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAHV", SqlDbType.VarChar).Value = hv.mahv;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public DataTable SearchOfMaHangVe(string str)
        {
            SqlConnection con = dc.GetConnect();

            string sqlQuery = string.Format("SELECT MAHV[Mã hạng vé], TENHV[Tên hạng vé] FROM HANGVE " +
                "WHERE MAHV LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchTLbyID(string str)
        {
            SqlConnection con = dc.GetConnect();

            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT * FROM HANGVE WHERE MAHV='{0}' ", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            return dt;
        }

        public DataTable Count_SLHV()
        {
            SqlConnection con = dc.GetConnect();

            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT COUNT(*) AS SL FROM HANGVE WHERE TINHTRANG=N'Khả dụng'");
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            return dt;
        }

        public string Get_MAVE_by_TENHV(string tenhangve)
        {
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string strQuery = string.Format("SELECT MAHV FROM HANGVE WHERE TENHV=N'{0}'", tenhangve);
            SqlDataAdapter da = new SqlDataAdapter(strQuery, con);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                DataRow row = dt.Rows[0];
                return row[0].ToString();
            }
            else
            {
                return "0";
            }
        }


    }
}
