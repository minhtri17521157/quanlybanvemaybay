using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class CTDoanhthuthangDAL
    {

        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public CTDoanhthuthangDAL()
        {
            dc = new DataConnection();
        }



        public DataTable Get()
        {
            SqlConnection _con = dc.GetConnect();
            //string sqlQuery = "SELECT* FROM CTDOANHTHUTHANG";
            string sql = "SELECT ROW_NUMBER() OVER (ORDER BY MACHUYENBAY) AS [STT], MACHUYENBAY[Chuyến bay],SOVEBANDUOC[Số vé bán được],DOANHTHU[Doanh thu (VNĐ)] FROM CTDOANHTHUTHANG";
            SqlDataAdapter da = new SqlDataAdapter(sql, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable Get_by_MON_and_Year(string strThang,string strNam )
        {
             SqlConnection _con = dc.GetConnect();
            //string sql = string.Format("SELECT ROW_NUMBER() OVER (ORDER BY tbl.[Chuyến bay]) AS [STT],tbl.* " +
            //   "FROM (SELECT DISTINCT  CT.MACHUYENBAY[Chuyến bay],COUNT(V.MAVE)[Số vé bán được],CT.DOANHTHU[Doanh thu (VNĐ)]  " +
            //   "FROM CTDOANHTHUTHANG CT, VECHUYENBAY V where CT.MACHUYENBAY=V.MACB and MONTH(V.NGAYGD)='{0}' AND YEAR(V.NGAYGD)='{1}' AND V.LOAIVE=N'Vé mua') tbl", strThang, strNam);

            string sql = string.Format("SELECT ROW_NUMBER() OVER (ORDER BY tbl.[Chuyến bay]) AS [STT],tbl.* " +
                "FROM (SELECT DISTINCT  CT.MACHUYENBAY[Chuyến bay],CT.SOVEBANDUOC[Số vé bán được],CT.DOANHTHU[Doanh thu (VNĐ)]  " +
                "FROM CTDOANHTHUTHANG CT, VECHUYENBAY V where CT.MACHUYENBAY=V.MACB and MONTH(V.NGAYGD)='{0}' AND YEAR(V.NGAYGD)='{1}' AND V.LOAIVE=N'Vé mua') tbl", strThang, strNam);

            SqlDataAdapter da = new SqlDataAdapter(sql, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




        public bool Add(DTO.CTDoanhthuthang dto)
        {
            SqlConnection _con = dc.GetConnect();
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO CTDOANHTHUTHANG(THANG, MACHUYENBAY, SOVEBANDUOC, DOANHTHU) VALUES('{0}', '{1}', '{2}', '{3}')", dto.thang, dto.machuyenbay, dto.sovebanduoc, dto.doanhthu);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }

        public bool Update(DTO.CTDoanhthuthang dto)
        {
            SqlConnection _con = dc.GetConnect();
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE CTDOANHTHUTHANG SET SOVEBANDUOC='{0}', DOANHTHU='{1}' WHERE THANG='{2}' MACHUYENBAY='{3}')", dto.sovebanduoc, dto.doanhthu, dto.thang, dto.machuyenbay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public bool Delete(DTO.CTDoanhthuthang dto)
        {
            SqlConnection _con = dc.GetConnect();
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM CTDOANHTHUTHANG WHERE THANG='{0}' AND MACHUYENBAY='{1}'", dto.thang, dto.machuyenbay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public DataTable GetOfThangNam(string strThang, string strNam)
        {
            SqlConnection _con = dc.GetConnect();
            string sqlQuery = string.Format("SELECT* FROM CTDOANHTHUTHANG WHERE THANG='{0}' AND NAM='{1}'", strThang, strNam);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
