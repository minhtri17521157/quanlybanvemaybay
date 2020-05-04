using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class DongiaBLL
    {

        DAL.DongiaDAL dal = new DAL.DongiaDAL();

        public DataTable Get()
        {
            return dal.Get();
        }
        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }
        public bool Add(DTO.Dongia dto)
        {
            return dal.InsertDongia(dto);
        }
        public bool Update(DTO.Dongia dto)
        {
            return dal.UpdateDongia(dto);
        }
        public bool Delete(DTO.Dongia dto)
        {
            return dal.DeleteDongia(dto);
        }
        public DataTable SearchDGbymaDG(string str)
        {
            return dal.SearchDGbymaDG(str);
        }

    }
}
