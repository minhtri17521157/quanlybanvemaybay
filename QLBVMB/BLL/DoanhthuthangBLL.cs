using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class DoanhthuthangBLL
    {


        DAL.DoanhthuthangDAL dal = new DAL.DoanhthuthangDAL();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO.Doanhthuthang dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO.Doanhthuthang dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO.Doanhthuthang dto)
        {
            return dal.Delete(dto);
        }
        public DataTable GetOfNam(string strNam)
        {
            return dal.GetOfNam(strNam);
        }
        public DataTable Get_report_by__Year(string strNam)
        {

            return dal.Get_report_by__Year(strNam);
        }

        
    }
}
