using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AjaxControlToolkit;

namespace QL_CDT.DAL
{
    public class ChitietSDDAL
    {
        public DataTable LoadDB()
        {
            SqlConnection conn = ConnectionDB.getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHITIETSD", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();
            return tb;
        }

        public DataTable FindDB(string sdt_find)
        {            
            SqlConnection conn = ConnectionDB.getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHITIETSD where IDSIM="+sdt_find, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();
            return tb;
        }

        internal DataTable FindDB(object sdt_find)
        {
            throw new NotImplementedException();
        }
        public DataTable Select_date(string ngaybd, string ngaykt)
        {
            SqlConnection conn = ConnectionDB.getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHITIETSD WHERE TGKT <= '"+ngaykt+"' AND '"+ngaybd+"'<= TGBD" , conn);            
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();   
            return tb;
        }

        internal DataTable Select_date(CalendarExtender day_start, CalendarExtender day_end)
        {
            throw new NotImplementedException();
        }
        public DataTable All_sum(string idsim)
        {
            SqlConnection conn = ConnectionDB.getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select SUM(CUOCPHI* SOPHUTSD)  as TONGCUOCPHI from CHITIETSD where IDSIM = '" + idsim + "' group by IDSIM", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();
            return tb;
        }
    }
}