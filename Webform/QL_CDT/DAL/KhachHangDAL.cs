using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QL_CDT.DAL
{
    public class KhachHangDAL
    {
        public DataTable LoadDB()
        {
            SqlConnection conn = ConnectionDB.getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();
            return tb;
        }
        public DataTable FindDB(string sdt_find)
        {
            SqlConnection conn = ConnectionDB.getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TENKH, CMND,NGHENGHIEP,CHUCVU,DIACHI FROM KHACHHANG join THONGTINSIM ON CMND='" + sdt_find + "'", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();
            return tb;
        }

    }
}