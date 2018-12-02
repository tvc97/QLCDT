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
            string cmnd_find = nhapCMND.Text;
            CuocDTEntities db = new CuocDTEntities();
            var rs_ctsd = db.hienthictsd(cmnd_find);
            GridView2.DataSource = rs_ctsd.ToList();
            GridView2.DataBind();
            var rs_hdtc = db.hienthihdtc(cmnd_find);
            GridView3.DataSource = rs_hdtc.ToList();
            GridView3.DataBind();
            var rs_hddk = db.hienthihddk(cmnd_find);
            GridView1.DataSource = rs_hddk.ToList();
            GridView1.DataBind();
        }

        protected void btn_find_tracuoc_Click(object sender, EventArgs e)
        {
            CuocDTEntities db = new CuocDTEntities();
            var sdt = nhapSDT_tracuoc.Text;
            var ngaybd = day_start.Text;
            var ngaykt = day_end.Text;
            var rs_htyc = db.hienthitheoyeucau(sdt, Convert.ToDateTime(ngaybd), Convert.ToDateTime(ngaykt));
            GridView4.DataSource = rs_htyc.ToList();
            GridView4.DataBind();
            var rs_tc = db.Tinhcuocwebform(sdt, Convert.ToDateTime(ngaybd), Convert.ToDateTime(ngaykt)).FirstOrDefault();
           /* GridView5.DataSource = rs_tc.ToList();
            GridView5.DataBind();
            Tinhcuocwebform_Result rs = rs_tc.FirstOrDefault();*/
           TextCuoc.Text = rs_tc.Tổng_Giá.Value.ToString();
            
        }
        protected void btn_display_Click(object sender, EventArgs e)
        {
           


        }

        protected void tongcuoc_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}