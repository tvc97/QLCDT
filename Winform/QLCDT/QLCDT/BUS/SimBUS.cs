using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCDT.DAO;

namespace QLCDT.BUS
{
    public class SimBUS
    {
        SimDAO simDAO = new SimDAO();

        public static List<THONGTINSIM> LoadSim()
        {
            return SimDAO.LoadTTS();
        }

        public static List<THONGTINSIM> LoadNotUsedSim()
        {
            return SimDAO.LoadNotUsedTTS();
        }

        public void AddSim(THONGTINSIM t)
        {
            simDAO.AddTTS(t);
        }

        public void EditSim(THONGTINSIM t)
        {
            simDAO.EditTTS(t);
        }

        public void DeleteSim(string id)
        {
            simDAO.DeleteTTS(id);
        }

        public THONGTINSIM GetByID(string id)
        {
            return simDAO.GetByID(id);
        }

        public THONGTINSIM GetRandom()
        {
            return simDAO.GetRandom();
        }
    }
}
