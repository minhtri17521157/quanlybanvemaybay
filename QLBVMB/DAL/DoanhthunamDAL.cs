using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class DoanhthunamDAL
    {


        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public DoanhthunamDAL()
        {
            dc = new DataConnection();
        }


        public DataTable Get()
        {
            SqlConnection _con = dc.GetConnect();
            string sqlQuery = "SELECT* FROM DOANHTHUNAM";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string Get_doanhthu_NAM(string _nam)
        {
            
            SqlConnection _con = dc.GetConnect();
            string sqlQuery = string.Format("SELECT DOANHTHU FROM DOANHTHUNAM WHERE NAM='{0}'",_nam);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            else
                return "0";

        }

        public bool Add(DTO.Doanhthunam dto)
        {
            SqlConnection _con = dc.GetConnect();
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO DOANHTHUNAM(NAM, DOANHTHU) VALUES('{0}', '{1}')", dto.nam, dto.doanhthu);
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
        public bool Update(DTO.Doanhthunam dto)
        {
            SqlConnection _con = dc.GetConnect();
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE DOANHTHUNAM SET DOANHTHU='{0}' WHERE NAM='{1}')", dto.doanhthu, dto.nam);
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
        public bool Delete(DTO.Doanhthunam dto)
        {
            SqlConnection _con = dc.GetConnect();
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM DOANHTHUNAM WHERE NAM='{0}'", dto.nam);
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
        public DataTable GetOfNam(string str)
        {
            SqlConnection _con = dc.GetConnect();
            string sqlQuery = string.Format("SELECT* FROM DOANHTHUNAM WHERE NAM='{0}'", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
