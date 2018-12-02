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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHITIETSD WHERE IDSIM='"+ sdt_find+"'", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();
            return tb;
        }


        public DataTable Select_date(string ngaybd, string ngaykt, string idsim)
        {
            SqlConnection conn = ConnectionDB.getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHITIETSD WHERE TGKT <= '"+ngaykt+"' AND '"+ngaybd+"'<= TGBD AND IDSIM='"+idsim+"'" , conn);            
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();   
            return tb;
        }

        public DataTable All_sum(string idsim)
        {
            SqlConnection conn = ConnectionDB.getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select SUM (CUOCPHI)  as TONGCUOCPHI from CHITIETSD where IDSIM = '"+ idsim + "'", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();
            return tb;
        }
        public DataTable Display_sum(string ngaybd, string ngaykt, string idsim)
        {
            SqlConnection conn = ConnectionDB.getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(CUOCPHI)  as TONGCUOCPHI from CHITIETSD where IDSIM='"+idsim+"' AND  TGBD >= '"+ ngaybd + "' AND TGKT <= '"+ ngaykt + "'", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();
            return tb;
        }
    }
}