using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class TuyenbayDAL
    {

        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public TuyenbayDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllTuyenbay()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT * FROM TUYENBAY";
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

        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT * FROM TUYENBAY ORDER BY MATB DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private string TaoMaTuyenBay()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "TB000" + dt.Rows.Count;
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
            return "TB" + strSoKhong + count;
        }

        public bool InsertTuyenbay(Tuyenbay tb)
        {
            string sql = "INSERT INTO TUYENBAY(MATB, MASBDI, MASBVE) VALUES(@MATB, @MASBDI,@MASBVE)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATB", SqlDbType.VarChar).Value = TaoMaTuyenBay();
                cmd.Parameters.Add("@MASBDI", SqlDbType.NVarChar).Value = tb.masb_di;
                cmd.Parameters.Add("@MASBVE", SqlDbType.NVarChar).Value = tb.masb_den;



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
