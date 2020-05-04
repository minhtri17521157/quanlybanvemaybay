using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class ChitietchuyenbayBLL
    {
        DAL.ChitietchuyenbayDAL dal = new DAL.ChitietchuyenbayDAL();

        public bool InsertCTChuyenBay(DTO.Chitietchuyenbay dto)
        {
            return dal.InsertCTChuyenBay(dto);
        }


    }
}
