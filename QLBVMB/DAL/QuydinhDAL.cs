using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class QuydinhDAL
    {

        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public QuydinhDAL()
        {
            dc = new DataConnection();
        }

        public DataTable GetAllQuydinh()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT * FROM THAMSO";
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

        public void Get_Infor(DTO.Quydinh qd)
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT * FROM THAMSO";
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
            DataRow row = dt.Rows[0];
            qd.tgbaytoithieu = int.Parse(row["TGBAYTOITHIEU"].ToString());
            qd.sosbtrunggiantoida = int.Parse(row["SOSBTRUNGGIANTOIDA"].ToString());
            qd.tgdungtoithieu = int.Parse(row["TGDUNGTOITHIEU"].ToString());
            qd.tgdungtoida = int.Parse(row["TGDUNGTOIDA"].ToString());
            qd.tgchamnhatdatve = int.Parse(row["TGCHAMNHATDATVE"].ToString());
            qd.tgchamnhathuyve = int.Parse(row["TGCHAMNHATHUYVE"].ToString());
            qd.slhangve = int.Parse(row["SLHANGVE"].ToString());
            qd.slsanbaytoida = int.Parse(row["SLSANBAYTOIDA"].ToString());

        }


        public string Get_So_Sanbay_TG_toida()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT SOSBTRUNGGIANTOIDA FROM THAMSO";
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

            return (dt.Rows[0][0]).ToString();

        }




        public bool UpdateQuydinh(DTO.Quydinh qd)
        {
            string sql = "UPDATE THAMSO SET TGBAYTOITHIEU=@TGBAYTOITHIEU, SOSBTRUNGGIANTOIDA=@SOSBTRUNGGIANTOIDA, TGDUNGTOITHIEU=@TGDUNGTOITHIEU, TGDUNGTOIDA=@TGDUNGTOIDA, TGCHAMNHATDATVE=@TGCHAMNHATDATVE, TGCHAMNHATHUYVE=@TGCHAMNHATHUYVE";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TGBAYTOITHIEU", SqlDbType.Int).Value = qd.tgbaytoithieu;
                cmd.Parameters.Add("@SOSBTRUNGGIANTOIDA", SqlDbType.Int).Value = qd.sosbtrunggiantoida;
                cmd.Parameters.Add("@TGDUNGTOITHIEU", SqlDbType.Int).Value = qd.tgdungtoithieu;
                cmd.Parameters.Add("@TGDUNGTOIDA", SqlDbType.Int).Value = qd.tgdungtoida;
                cmd.Parameters.Add("@TGCHAMNHATDATVE", SqlDbType.Int).Value = qd.tgchamnhatdatve;
                cmd.Parameters.Add("@TGCHAMNHATHUYVE", SqlDbType.Int).Value = qd.tgchamnhathuyve;
                //cmd.Parameters.Add("@SLHANGVE", SqlDbType.Int).Value = qd.slhangve;
                //cmd.Parameters.Add("@SLSANBAYTOIDA", SqlDbType.Int).Value = qd.slsanbaytoida;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateSanBayTD(DTO.Quydinh qd)
        {
            string sql = "UPDATE THAMSO SET SLSANBAYTOIDA=@SLSANBAYTOIDA ";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
               
                cmd.Parameters.Add("@SLSANBAYTOIDA", SqlDbType.Int).Value = qd.slsanbaytoida;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool Update_SL_HangveHienTai(DTO.Quydinh qd)
        {
            string sql = "UPDATE THAMSO SET SLHANGVE=@SLHANGVE ";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@SLHANGVE", SqlDbType.Int).Value = qd.slhangve;

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
