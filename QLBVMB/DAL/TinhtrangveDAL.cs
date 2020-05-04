using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class TinhtrangveDAL
    {

        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public TinhtrangveDAL()
        {
            dc = new DataConnection();
        }

        public DataTable Get()
        {
            SqlConnection con = dc.GetConnect();

            string sqlQuery = "SELECT* FROM TINHTRANGVE";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetForDisplayOfMaChuyenBay(string str)
        {
            SqlConnection con = dc.GetConnect();

            string sqlQuery = string.Format("SELECT H.TENHV[Tên hạng vé], T.SLGHE[Số ghế], T.SLGHETRONG[Số ghế trống], T.SLGHEDAT[Số ghế đặt]" +
                "FROM TINHTRANGVE T INNER JOIN HANGVE H ON T.MAHV=H.MAHV WHERE T.MACB='{0}'", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();

            string sqlQuery = "SELECT * FROM TINHTRANGVE ORDER BY MATTVE DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private string TaoMaTtve()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "TT000" + dt.Rows.Count;
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
            return "TT" + strSoKhong + count;
        }




        private DataTable Get_Sort()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT COUNT(*) AS SL FROM TINHTRANGVE";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMa_TTV()
        {
            DataTable dt = this.Get_Sort();
            DataRow row = dt.Rows[0];


            return "MTTV" + (int.Parse(dt.Rows[0]["SL"].ToString()) + 1).ToString();

        }



        ///dayyyyyyyyyyyyyyyyyyyyyyyy
        public bool InsertTinhtrangve(DTO.Tinhtrangve ttv)
        {
            string sql = "INSERT INTO TINHTRANGVE(MATTVE, MACB, MAHV, SLGHE, SLGHETRONG, SLGHEDAT) VALUES(@MATTVE, @MACB,@MAHV,@SLGHE,@SLGHETRONG,@SLGHEDAT)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATTVE", SqlDbType.VarChar).Value = TaoMa_TTV();
                cmd.Parameters.Add("@MACB", SqlDbType.VarChar).Value = ttv.macb;
                cmd.Parameters.Add("@MAHV", SqlDbType.VarChar).Value = ttv.mahv;
                cmd.Parameters.Add("@SLGHE", SqlDbType.Int).Value = ttv.slghe;
                cmd.Parameters.Add("@SLGHETRONG", SqlDbType.Int).Value = ttv.slghetrong;
                cmd.Parameters.Add("@SLGHEDAT", SqlDbType.Int).Value = ttv.slghedat;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public bool UpdateTinhtrangve(DTO.Tinhtrangve ttv)
        {
            string sql = "UPDATE TINHTRANGVE SET MACB=@MACB, MAHV=@MAHV, SLGHE=@SLGHE, SLGHETRONG=@SLGHETRONG, SLGHEDAT=@SLGHEDAT WHERE MATTVE=@MATTVE";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATTVE", SqlDbType.VarChar).Value = ttv.mattve;
                cmd.Parameters.Add("@MACB", SqlDbType.VarChar).Value = ttv.macb;
                cmd.Parameters.Add("@MAHV", SqlDbType.VarChar).Value = ttv.mahv;
                cmd.Parameters.Add("@SLGHE", SqlDbType.Int).Value = ttv.slghe;
                cmd.Parameters.Add("@SLGHETRONG", SqlDbType.Int).Value = ttv.slghetrong;
                cmd.Parameters.Add("@SLGHEDAT", SqlDbType.Int).Value = ttv.slghedat;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteTinhtrangve(DTO.Tinhtrangve ttv)
        {
            string sql = "DELETE TINHTRANGVE WHERE MATTVE = @MATTVE";

            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATTVE", SqlDbType.VarChar).Value = ttv.mattve;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        ///
        public DataTable GetOfMaChuyenBay(string maChuyenBay)
        {
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string strQuery = string.Format("SELECT* FROM TINHTRANGVE T INNER JOIN HANGVE H " +
                "ON T.MAHV=H.MAHV WHERE T.MACB='{0}'", maChuyenBay);
            SqlDataAdapter da = new SqlDataAdapter(strQuery, con);
            da.Fill(dt);
            return dt;
        }
        public string GetSoGheTrongOfMaChuyenBayAndMaHangVe(string maChuyenBay, string maHangVe)
        {
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string strQuery = string.Format("SELECT SLGHETRONG FROM TINHTRANGVE WHERE MACB='{0}' " +
                "AND MAHV='{1}'", maChuyenBay, maHangVe);
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

        public string Get_SL_GHE_by_MACB(string maChuyenBay)
        {
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string strQuery = string.Format("SELECT SUM(SLGHE) FROM TINHTRANGVE WHERE MACB='{0}'", maChuyenBay);
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
