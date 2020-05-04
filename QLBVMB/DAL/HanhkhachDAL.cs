using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class HanhkhachDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public HanhkhachDAL()
        {
            dc = new DataConnection();
        }

        public DataTable GetForDisplay()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT MAHK[Mã khách hàng], TENHK[Tên khách hàng], " +
                "CMND[CMND], SDT[Số điện thoại] FROM HANHKHACH";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getAllHanhkhach()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT * FROM HANHKHACH";
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
            string sqlQuery = "SELECT * FROM HANHKHACH ORDER BY MAHK DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMaKhachHang()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "HK000" + dt.Rows.Count;
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
            return "HK" + strSoKhong + count;
        }

        public bool InsertHanhkhach(DTO.Hanhkhach hk)
        {
            string sql = "INSERT INTO HANHKHACH(MAHK, TENHK, CMND, SDT) VALUES(@MAHK, @TENHK,@CMND,@SDT)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = TaoMaKhachHang();
                cmd.Parameters.Add("@TENHK", SqlDbType.NVarChar).Value = hk.tenhk;
                cmd.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = hk.cmnd;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = hk.sdt;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateHanhkhach(DTO.Hanhkhach hk)
        {
            string sql = "UPDATE HANHKHACH SET TENHK=@TENHK, CMND=@CMND, SDT=@SDT WHERE MAHK=@MAHK";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = hk.mahk;
                cmd.Parameters.Add("@TENHK", SqlDbType.NVarChar).Value = hk.tenhk;
                cmd.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = hk.tenhk;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = hk.tenhk;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteHanhkhach(DTO.Hanhkhach hk)
        {
            string sql = "DELETE HANHKHACH WHERE MAHK = @MAHK";

            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = hk.mahk;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public DataTable GetOfCMND(string CMND)
        {
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT * FROM HANHKHACH WHERE CMND='{0}'", CMND);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchOfMaKhachHang(string str)
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = string.Format("SELECT MAHK[Mã hành khách, TENKHACHHANG[Tên hành khách], " +
                "CMND[CMND], SDT[Số điện thoại] FROM HANHKHACH " +
                "WHERE MAHK LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable FindMAHK(string CMND)
        {
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT MAHK FROM HANHKHACH WHERE CMND='{0}'", CMND);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            return dt;
        }


    }
}
