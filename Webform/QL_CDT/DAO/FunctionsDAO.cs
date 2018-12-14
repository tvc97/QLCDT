using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CDT.DAO
{
    class FunctionsDAO
    {
        public static double SoPhut(string from, string to)
        {
            using (QL_CDTEntities DContext = new QL_CDTEntities())
            {
                return DContext.Database.SqlQuery<double>("SELECT dbo.SOPHUT(@p0, @p1)", from, to).FirstOrDefault();
            }
        }

        public static decimal TinhCuoc(string from, string to)
        {
            using (QL_CDTEntities DContext = new QL_CDTEntities())
            {
                return DContext.Database.SqlQuery<decimal>("SELECT dbo.TINHCUOC(@p0, @p1)", from, to).FirstOrDefault();
            }
        }

        public static void TinhHDTC(string thang, string nam)
        {
            using (QL_CDTEntities DContext = new QL_CDTEntities())
            {
                DContext.TINH_HDTC(int.Parse(thang), int.Parse(nam));
            }
        }
    }
}
