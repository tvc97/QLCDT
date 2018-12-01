using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCDT.DAO;

namespace QLCDT.BUS
{
    class FunctionsBUS
    {
        public static double SoPhut(string from, string to)
        {
            return FunctionsDAO.SoPhut(from, to);
        }

        public static decimal TinhCuoc(string from, string to)
        {
            return FunctionsDAO.TinhCuoc(from, to);
        }

        public static void TinhHDTC(string thang, string nam)
        {
            FunctionsDAO.TinhHDTC(thang, nam);
        }
    }
}
