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

    }
}