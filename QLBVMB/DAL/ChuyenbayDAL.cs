using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class ChuyenbayDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public ChuyenbayDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllSanbay()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT * FROM CHUYENBAY";
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
            string sqlQuery = "SELECT* FROM CHUYENBAY ORDER BY MACB DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMaChuyenBay()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "CB000" + dt.Rows.Count;
            DataRow row = dt.Rows[0];
            string maChuyenBay = row[0].ToString().Substring(2);
            int count = int.Parse(maChuyenBay) + 1;
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
            return "CB" + strSoKhong + count;
        }


        public DataTable GetOfMaChuyenBay(string maChuyenBay)
        {
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT C.MACB, T.MATB, " +
                "C.NGAYGIO, C.THOIGIANBAY, S1.TENSANBAY[TENSBDI], S2.TENSANBAY[TENSBDEN] " +
                "FROM CHUYENBAY C INNER JOIN TUYENBAY T " +
                "ON C.MATB=T.MATB INNER JOIN SANBAY S1 ON T.MASBDI=S1.MASB " +
                "INNER JOIN SANBAY S2 ON T.MASBDEN = S2.MASB WHERE MACB='{0}'", maChuyenBay);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            return dt;
        }
        public DateTime GetDateTimeOfMaChuyenBay(string str)
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = string.Format("SELECT NGAYGIO FROM CHUYENBAY WHERE MACB='{0}'", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return Convert.ToDateTime(dt.Rows[0].ToString());
        }


        public bool InsertChuyenbay(DTO.Chuyenbay cb)
        {
            string sql = "INSERT INTO CHUYENBAY(MACB, MATB, NGAYGIO,THOIGIANBAY,MADG) VALUES(@MACB, @MATB,@NGAYGIO,@THOIGIANBAY,@MADG)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MACB", SqlDbType.VarChar).Value = TaoMaChuyenBay();
                cmd.Parameters.Add("@MATB", SqlDbType.VarChar).Value = cb.matb;
                cmd.Parameters.Add("@NGAYGIO", SqlDbType.DateTime).Value = cb.ngaygio;
                cmd.Parameters.Add("@THOIGIANBAY", SqlDbType.Float).Value = cb.thoigianbay;
                //cmd.Parameters.Add("@SLGHEHANG1", SqlDbType.Int).Value = cb.slghehang1;
                //cmd.Parameters.Add("@SLGHEHANG2", SqlDbType.Int).Value = cb.slghehang2;
                cmd.Parameters.Add("@MADG", SqlDbType.VarChar).Value = cb.madg;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }



       


        public bool UpdateChuyenbay(DTO.Chuyenbay cb)
        {
            string sql = "UPDATE CHUYENBAY SET MATB=@MATB, MATB=@MATB, NGAYGIO=@NGAYGIO, THOIGIANBAY=@THOIGIANBAY, SLGHEHANG1=@SLGHEHANG1, SLGHEHANG2=@SLGHEHANG2, MADG=@MADG WHERE MACB=@MACB";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MACB", SqlDbType.VarChar).Value = cb.macb;
                cmd.Parameters.Add("@MATB", SqlDbType.VarChar).Value = cb.matb;
                cmd.Parameters.Add("@NGAYGIO", SqlDbType.DateTime).Value = cb.ngaygio;
                cmd.Parameters.Add("@THOIGIANBAY", SqlDbType.Float).Value = cb.thoigianbay;
                //cmd.Parameters.Add("@SLGHEHANG1", SqlDbType.Int).Value = cb.slghehang1;
                //cmd.Parameters.Add("@SLGHEHANG2", SqlDbType.Int).Value = cb.slghehang2;
                cmd.Parameters.Add("@MADG", SqlDbType.Int).Value = cb.madg;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteChuyenbay(string str)
        {
            string sql = "DELETE CHUYENBAY WHERE MACB = @MACB";

            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MACB", SqlDbType.VarChar).Value = str;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }



        public DataTable Search(string maSanBayDi, string maSanBayDen, DateTime thoiGian,DateTime thoiGian2, string tmp)
        {


            string sqlQuery = string.Format("Set dateformat dmy SELECT C.MACB[Mã chuyến bay], " +
                "C.MATB[Mã tuyến bay], C.NGAYGIO[Thời gian KH], C.THOIGIANBAY[Thời gian bay (phút)], HV.TENHV[Tên hạng vé], TV.SLGHETRONG[Số lượng ghế trống],TV.SLGHEDAT[Số lượng ghế đặt] " +
              " FROM CHUYENBAY C INNER JOIN TUYENBAY T " +
                "ON C.MATB=T.MATB INNER JOIN TINHTRANGVE TV ON C.MACB=TV.MACB INNER JOIN HANGVE HV ON TV.MAHV=HV.MAHV WHERE T.MASBDI = '{0}' " +
                "AND T.MASBDEN ='{1}' AND C.NGAYGIO BETWEEN('{2}') AND ('{3}')", maSanBayDi, maSanBayDen, thoiGian, thoiGian2); //


            
            // string sqlQuery = "Set dateformat dmy SELECT C.MACB[Mã chuyến bay],C.MATB[Mã tuyến bay],C.NGAYGIO[Thời gian KH], C.THOIGIANBAY[Thời gian bay(phút)], HV.TENHV ,TV.SLGHETRONG[Số lượng ghế trống],TV.SLGHEDAT[Sl ghedat] FROM CHUYENBAY C INNER JOIN TUYENBAY T ON C.MATB = T.MATB INNER JOIN TINHTRANGVE TV ON C.MACB = TV.MACB INNER JOIN HANGVE HV ON TV.MAHV = HV.MAHV WHERE T.MASBDI = 'SB0001' AND T.MASBDEN = 'SB0002' AND C.NGAYGIO BETWEEN('1/1/2018') AND('1/1/2019') ";


            SqlConnection con = dc.GetConnect();
            //B3: khởi tạo đối tượng của lớp sql data adapter
            da = new SqlDataAdapter(sqlQuery, con);
            //B4: mở kết nối
            con.Open();
            //B5: đổ dữ liệu từ sql data adapter vào data table
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: đóng kết nối
            con.Close();
            return dt;
        }

        public DataTable GetToDisplay()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT MACB[Mã chuyến bay], MATB[Mã tuyến bay], " +
                "THOIGIAN[Thời gian khởi hành], " +
                "THOIGIANBAY[Thời gian bay] FROM CHUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchOfMaChuyenBay(string str)
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = string.Format("SELECT MACB[Mã chuyến bay], MATB[Mã tuyến bay], " +
                "THOIGIAN[Thời gian khởi hành], " +
                "THOIGIANBAY[Thời gian bay] FROM CHUYENBAY WHERE MACB LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchDGbyMACB(string str)
        {
            SqlConnection con = dc.GetConnect();

            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT MADG FROM CHUYENBAY WHERE MACB='{0}' ", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            return dt;
        }

    }
}
