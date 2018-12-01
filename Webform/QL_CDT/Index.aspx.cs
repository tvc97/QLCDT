using QL_CDT.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QL_CDT
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load()
        {
            
        }
        
        public void LoadKH()
        {
            
        }
        public void LoadChitietSD()
        {
            
        }

        protected void btn_find_Click(object sender, EventArgs e)
        {
            var sdt = TextBox1.Text;
            CuocDTEntities1 db = new CuocDTEntities1();
            var result_kh = from s in db.THONGTINSIMs
                            join sa in db.HDDKs
                            on s.IDSIM equals sa.IDSIM
                            where s.SDT == sdt
                            select s;
            GridView2.DataSource = result_kh.ToList();
            GridView2.DataBind();
           
        }
        protected void btn_find_tracuoc_Click(object sender, EventArgs e)
        {
            //var sdt = TextBox1.Text;
            //var nbd = day_start.Text;
            //var nkt = day_end.Text;
            //CuocDTEntities1 db = new CuocDTEntities1();
            //var rs_sp1 = db.TinhCuoc(sdt,Convert.ToDateTime(ngaybd), Convert.ToDateTime(ngaykt));
            //GridView2.DataSource = rs_sp1.ToList();
            //GridView2.DataBind();


            var sdt = TextBox2.Text;
            ChitietSDDAL tb = new ChitietSDDAL();
            DataTable dbtb = new DataTable();
            dbtb = tb.FindDB(sdt);
            tb_KhachHang.DataSource = dbtb;
            tb_KhachHang.DataBind();

            DataTable db_sum = new DataTable();
            db_sum = tb.All_sum(sdt);
            id_tonggiacuoc.Text = db_sum.Rows[0][0].ToString();
        }

        protected void btn_display_Click(object sender, EventArgs e)
        {
            var sdt = TextBox1.Text;
            var nbd = day_start.Text;
            var nkt = day_end.Text;
            CuocDTEntities1 db = new CuocDTEntities1();
            var rs_sp = db.hienthi(sdt, Convert.ToDateTime(ngaybd), Convert.ToDateTime(ngaykt));
            GridView2.DataSource = rs_sp.ToList();
            GridView2.DataBind();


            //    string tgbd = "2018-05-01";
            //    string tgkt = "2018-07-30";
            //    ChitietSDDAL tb = new ChitietSDDAL();
            //    DataTable dbtb = new DataTable();
            //    dbtb = tb.Select_date(tgbd, tgkt);
            //    tb_KhachHang.DataSource = dbtb;
            //    tb_KhachHang.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}