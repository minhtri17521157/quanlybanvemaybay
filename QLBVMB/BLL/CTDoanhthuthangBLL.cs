using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class CTDoanhthuthangBLL
    {



        DAL.CTDoanhthuthangDAL dal = new DAL.CTDoanhthuthangDAL();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO.CTDoanhthuthang dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO.CTDoanhthuthang dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO.CTDoanhthuthang dto)
        {
            return dal.Delete(dto);
        }
        public DataTable GetOfThangNam(string strThang, string strNam)
        {
            return dal.GetOfThangNam(strThang, strNam);
        }

        public DataTable Get_by_MON_and_Year(string strThang, string strNam)
        {
            return dal.Get_by_MON_and_Year(strThang, strNam);
        }


    }
}
