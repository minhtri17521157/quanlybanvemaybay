using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class VechuyenbayDAL
    {


        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public VechuyenbayDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllVechuyenbay()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT * FROM VECHUYENBAY";
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
            string sqlQuery = "SELECT V.MAVE[Mã vé], K.TENHK[Tên hành khách], " +
                "K.CMND[CMND], V.MACB[Mã chuyến bay], H.TENHV[Tên hạng vé], " +
                "V.GIA[Giá tiền], V.NGAYGD[Ngày giờ giao dịch], V.NGAYHUY[Ngày hủy], " +
                "V.LOAIVE[Loại vé] FROM VECHUYENBAY V INNER JOIN HANHKHACH K " +
                "ON V.MAHK=K.MAHK INNER JOIN HANGVE H ON V.MAHV=H.MAHV";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();

            string sqlQuery = "SELECT * FROM VECHUYENBAY ORDER BY MAVE DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private string TaoMaVe()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "VE000" + dt.Rows.Count;
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
            return "VE" + strSoKhong + count;
        }

        public bool InsertVechuyenbay(DTO.Vechuyenbay vcb)
        {
            string sql = "INSERT INTO VECHUYENBAY(MAVE, MACB, MAHV, MAHK, GIA, NGAYGD, LOAIVE) VALUES(@MAVE, @MACB,@MAHV,@MAHK,@GIA,@NGAYGD,@LOAIVE)";
        

            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAVE", SqlDbType.VarChar).Value = TaoMaVe();
                cmd.Parameters.Add("@MACB", SqlDbType.VarChar).Value = vcb.macb;
                cmd.Parameters.Add("@MAHV", SqlDbType.VarChar).Value = vcb.mahv;
                cmd.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = vcb.mahk;
                cmd.Parameters.Add("@GIA", SqlDbType.Decimal).Value = vcb.gia;
                cmd.Parameters.Add("@NGAYGD", SqlDbType.DateTime).Value = vcb.ngaygd;
                cmd.Parameters.Add("@LOAIVE", SqlDbType.NVarChar).Value = vcb.loaive;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public bool UpdateVechuyenbay(DTO.Vechuyenbay vcb)
        {
            string sql = "UPDATE VECHUYENBAY SET MACB=@MACB, MAHV=@MAHV, MAHK=@MAHK, GIA=@GIA, NGAYGD=@NGAYGD, LOAIVE=@LOAIVE WHERE MAVE=@MAVE";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAVE", SqlDbType.VarChar).Value = vcb.mave;
                cmd.Parameters.Add("@MACB", SqlDbType.VarChar).Value = vcb.macb;
                cmd.Parameters.Add("@MAHV", SqlDbType.VarChar).Value = vcb.mahv;
                cmd.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = vcb.mahv;
                cmd.Parameters.Add("@GIA", SqlDbType.Decimal).Value = vcb.gia;
                cmd.Parameters.Add("@NGAYGD", SqlDbType.Date).Value = vcb.ngaygd;
                cmd.Parameters.Add("@LOAIVE", SqlDbType.NVarChar).Value = vcb.mahv;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteVechuyenbay(DTO.Vechuyenbay vcb)
        {
            string sql = "DELETE VECHUYENBAY WHERE MAVE = @MAVE";

            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAVE", SqlDbType.VarChar).Value = vcb.mave;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public DataTable FindVebyMAVE(string mv)
        {
            //*note 
            // like là trả về tất cả kết quả gần đúng, = là trả về chính xác 


            // string sql = "SELECT * FROM VECHUYENBAY WHERE MAVE =  mv + "%'";     // tìm kiếm theo tên và loại

            string sql = string.Format("SELECT V.MAVE[Mã vé],V.LOAIVE[Loại vé],HK.TENHK[Tên hành khách], V.MACB[Mã chuyến bay], SB1.TENSANBAY[Sân bay đi],SB2.TENSANBAY[Sân bay đến],HV.TENHV[Hạng vé],V.GIA[Giá (VNĐ)]  FROM VECHUYENBAY V JOIN CHUYENBAY CB ON CB.MACB=V.MACB JOIN TUYENBAY TB ON CB.MATB=TB.MATB JOIN SANBAY SB1 ON TB.MASBDI=SB1.MASB JOIN SANBAY SB2 ON TB.MASBDEN=SB2.MASB JOIN HANGVE HV ON V.MAHV=HV.MAHV JOIN HANHKHACH HK ON V.MAHK=HK.MAHK WHERE V.MAVE like N'%{0}%'", mv);

            //string sql = "SELECT * FROM FOOD WHERE PRICE like N'%" + fd + "%'";
            //string sql = "SELECT * FROM FOOD WHERE PRICE = " + int.Parse(fd);          //tìm kiếm theo giá

            SqlConnection con = dc.GetConnect();
            //B3: khởi tạo đối tượng của lớp sql data adapter
            da = new SqlDataAdapter(sql, con);
            //B4: mở kết nối
            con.Open();
            //B5: đổ dữ liệu từ sql data adapter vào data table
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: đóng kết nối
            con.Close();
            return dt;
        }


        public DataTable FindMAVE(string maHK, string maCB, string maHV)
        {

            //string sql = string.Format("SELECT * FROM VECHUYENBAY WHERE MAVE ='{0}' ", mv);

            string sql = string.Format("SELECT MAVE FROM VECHUYENBAY V INNER JOIN HANHKHACH HK ON V.MAHK = HK.MAHK WHERE HK.MAHK = '{0}' AND V.MACB = '{1}' AND V.MAHV = '{2}'", maHK, maCB, maHV);

            SqlConnection con = dc.GetConnect();
            //B3: khởi tạo đối tượng của lớp sql data adapter
            da = new SqlDataAdapter(sql, con);
            //B4: mở kết nối
            con.Open();
            //B5: đổ dữ liệu từ sql data adapter vào data table
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: đóng kết nối
            con.Close();
            return dt;
        }

        public DataTable FindChitietVE(string MAVE)
        {

            //string sql = string.Format("SELECT * FROM VECHUYENBAY WHERE MAVE ='{0}' ", mv);

            string sql = string.Format("SELECT HK.TENHK,HK.CMND,HK.SDT, V.MAVE,V.NGAYGD,V.MACB, T.MATB, SB1.TENSANBAY[TENSBDI], " +
                "SB2.TENSANBAY[TENSBDEN], C.NGAYGIO, V.NGAYHUY ,C.THOIGIANBAY,V.LOAIVE, HV.TENHV, V.GIA " +
                "FROM HANHKHACH HK INNER JOIN VECHUYENBAY V ON HK.MAHK = V.MAHK " +
                "INNER JOIN CHUYENBAY C ON V.MACB = C.MACB INNER JOIN TUYENBAY T ON C.MATB = T.MATB " +
                "INNER JOIN SANBAY SB1 ON T.MASBDI = SB1.MASB INNER JOIN SANBAY SB2 ON T.MASBDEN = SB2.MASB " +
                "INNER JOIN HANGVE HV ON V.MAHV = HV.MAHV WHERE V.MAVE = '{0}'", MAVE);

            SqlConnection con = dc.GetConnect();
            //B3: khởi tạo đối tượng của lớp sql data adapter
            da = new SqlDataAdapter(sql, con);
            //B4: mở kết nối
            con.Open();
            //B5: đổ dữ liệu từ sql data adapter vào data table
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: đóng kết nối
            con.Close();
            return dt;
        }

        public bool HuyVE(string mave)
        {
            DateTime ng = DateTime.Now;

            string sql = "UPDATE VECHUYENBAY SET LOAIVE=N'Vé đã hủy', NGAYHUY=@NGAYHUY WHERE MAVE = @MAVE";



            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAVE", SqlDbType.VarChar).Value = mave;
                cmd.Parameters.Add("@NGAYHUY", SqlDbType.DateTime).Value = ng;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool ThanhtoanVE(string mave)
        {
            DateTime ng = DateTime.Now;

            string sql = "UPDATE VECHUYENBAY SET LOAIVE=N'Vé mua', NGAYGD=@NGAYGD, NGAYHUY=null WHERE MAVE = @MAVE";
           



            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAVE", SqlDbType.VarChar).Value = mave;
                cmd.Parameters.Add("@NGAYGD", SqlDbType.DateTime).Value = ng;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public string Get_SLVE_MUA_by_MACB(string maChuyenBay)
        {
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string strQuery = string.Format("SELECT COUNT(*) FROM VECHUYENBAY WHERE MACB='{0}' AND LOAIVE=N'Vé mua'", maChuyenBay);
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


        public string Get_SLVE_MUA_by_MACB_MONTH(string maChuyenBay, string mon)
        {
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string strQuery = string.Format("SELECT COUNT(*) FROM VECHUYENBAY WHERE MACB='{0}' AND LOAIVE=N'Vé mua' AND MONTH(NGAYGD)={1}", maChuyenBay, mon);
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
