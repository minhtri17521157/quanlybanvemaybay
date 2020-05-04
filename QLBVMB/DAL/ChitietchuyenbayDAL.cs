using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class ChitietchuyenbayDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public ChitietchuyenbayDAL()
        {
            dc = new DataConnection();
        }

        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT* FROM CTCHUYENBAY ORDER BY MACTCB DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMaCTChuyenBay()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "CT000" + dt.Rows.Count;
            DataRow row = dt.Rows[0];
            string maCTChuyenBay = row[0].ToString().Substring(2);
            int count = int.Parse(maCTChuyenBay) + 1;
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
            return "CT" + strSoKhong + count;
        }


        private DataTable Get_Sort()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT COUNT(*) AS SL FROM CTCHUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMa_CT_CB()
        {
            DataTable dt = this.Get_Sort();
            DataRow row = dt.Rows[0];


            return "CT"+(int.Parse(dt.Rows[0]["SL"].ToString()) + 1).ToString();

        }




        public bool InsertCTChuyenBay(DTO.Chitietchuyenbay CTCB)
        {
            string sql = "INSERT INTO CTCHUYENBAY(MACTCB, MACB, MASANBAYTG,THOIGIANDUNG,GHICHU) VALUES(@MACTCB, @MACB, @MASANBAYTG,@THOIGIANDUNG,@GHICHU)";
            //string sql2 = "INSERT INTO CTCHUYENBAY(MACTCB, MACB, MASANBAYTG,THOIGIANDUNG,GHICHU) VALUES('MACTCB0003', 'CB0009', 'SB0006',16,'khong')";

            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MACTCB", SqlDbType.VarChar).Value = TaoMa_CT_CB();
                cmd.Parameters.Add("@MACB", SqlDbType.VarChar).Value = CTCB.macb;
                cmd.Parameters.Add("@MASANBAYTG", SqlDbType.VarChar).Value = CTCB.masbtg;
                cmd.Parameters.Add("@THOIGIANDUNG", SqlDbType.Float).Value = CTCB.thoigiandung;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = CTCB.ghichu;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
