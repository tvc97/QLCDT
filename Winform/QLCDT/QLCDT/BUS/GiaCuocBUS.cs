using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCDT.DAO;

namespace QLCDT.BUS
{
    class GiaCuocBUS
    {
        GiaCuocDAO gcDAO = new GiaCuocDAO();

        public static List<GIACUOC> LoadGiaCuoc()
        {
            return GiaCuocDAO.LoadGiaCuoc();
        }

        public void AddGiaCuoc(GIACUOC t)
        {
            gcDAO.AddGiaCuoc(t);
        }

        public void EditGiaCuoc(GIACUOC t)
        {
            gcDAO.EditGiaCuoc(t);
        }

        public void DeleteGiaCuoc(int id)
        {
            gcDAO.DeleteGiaCuoc(id);
        }
        
        public GIACUOC GetByID(int id)
        {
            return gcDAO.GetByID(id);
        }
    }
}
