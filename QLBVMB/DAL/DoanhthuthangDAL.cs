using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class DoanhthuthangDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public DoanhthuthangDAL()
        {
            dc = new DataConnection();
        }

        public DataTable Get()
        {
            SqlConnection _con = dc.GetConnect();
            string sqlQuery = "SELECT* FROM DOANHTHUTHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




        public DataTable Get_report_by__Year( string strNam)
        {

            SqlConnection _con = dc.GetConnect();

            string sql = string.Format("SELECT ROW_NUMBER() OVER (ORDER BY tbl.[Tháng]) AS [STT],tbl.* " +
                "FROM (SELECT DISTINCT THANG[Tháng], SOCHUYENBAY[Số chuyến bay], DOANHTHU[Doanh thu (VNĐ)] " +
                "FROM DOANHTHUTHANG WHERE NAM='{0}') tbl", strNam);

            SqlDataAdapter da = new SqlDataAdapter(sql, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public bool Add(DTO.Doanhthuthang dto)
        {
            SqlConnection _con = dc.GetConnect();
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO DOANHTHUTHANG(THANG, NAM, SOCHUYENBAY, DOANHTHU) VALUES('{0}', '{1}', '{2}', '{3}')", dto.thang, dto.nam, dto.sochuyenbay, dto.doanhthu);
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
        public bool Update(DTO.Doanhthuthang dto)
        {
            SqlConnection _con = dc.GetConnect();
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE DOANHTHUTHANG SET SOCHUYENBAY='{0}', DOANHTHU='{1}' WHERE THANG='{2}' AND NAM='{3}')", dto.sochuyenbay, dto.doanhthu, dto.thang, dto.nam);
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
        public bool Delete(DTO.Doanhthuthang dto)
        {
            SqlConnection _con = dc.GetConnect();
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM DOANHTHUTHANG WHERE THANG='{0}' AND NAM='{1}'", dto.thang, dto.nam);
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
        public DataTable GetOfNam(string strNam)
        {
            SqlConnection _con = dc.GetConnect();
            string sqlQuery = string.Format("SELECT* FROM DOANHTHUTHANG WHERE NAM='{0}'", strNam);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
