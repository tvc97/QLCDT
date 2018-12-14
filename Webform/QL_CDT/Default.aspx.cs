using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QL_CDT.BUS;

namespace QL_CDT
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DateTime now = DateTime.Now;

                for(int i = 1; i <= 12; i++)
                {
                    ListItem li = new ListItem(i.ToString(), i.ToString());
                    if (i == now.Month) li.Selected = true;
                    ddlThang.Items.Add(li);
                }

                for (int i = 2017; i <= 2019; i++)
                {
                    ListItem li = new ListItem(i.ToString(), i.ToString());
                    if (i == now.Year) li.Selected = true;
                    ddlNam.Items.Add(li);
                }

            }
            divError.Visible = false;
            generalInfo.Visible = false;
            divCTSD.Visible = false;
            divHDDK.Visible = false;
            divHDTC.Visible = false;
            divFooter.Visible = false;
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            QL_CDTEntities db = new QL_CDTEntities();

            var tkh = from kh in db.KHACHHANGs
                    where kh.CMND == tbCMND.Text
                    select kh;

            if(tkh.Count() == 0)
            {
                divError.Visible = true;
                lblError.Text = "Không tìm thấy khách hàng có CMND vừa nhập, vui lòng kiểm tra lại!";

                gvCTSD.DataBind();
            } else
            {
                generalInfo.Visible = true;
                KHACHHANG currentKH = tkh.First();
                lblName.Text = currentKH.TENKH;

                int month = int.Parse(ddlThang.SelectedValue);
                int year = int.Parse(ddlNam.SelectedValue);

                DateTime start = new DateTime(year, month, 1);
                DateTime end = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                var t = from ctsd in db.CHITIETSDs
                        join hddk in db.HDDKs on ctsd.IDSIM equals hddk.IDSIM
                        join kh in db.KHACHHANGs on hddk.IDKH equals kh.ID
                        where hddk.NGAYKT >= start && hddk.NGAYBD <= end && kh.CMND == tbCMND.Text && ctsd.TGBD.Month == month && ctsd.TGBD.Year == year
                        orderby ctsd.TGBD ascending
                        select new
                        {
                            kh.TENKH,
                            ctsd.IDSIM,
                            ctsd.TGBD,
                            ctsd.TGKT,
                            ctsd.SOPHUTSD,
                            ctsd.CUOCPHI
                        };

                if (t.Count() == 0)
                {
                    divError.Visible = true;
                    lblError.Text = "Không có cuộc gọi nào trong tháng!";
                } else
                {
                    divFooter.Visible = true;
                    divCTSD.Visible = true;
                    double totalMinute = 0;
                    decimal totalMoney = 0;
                    foreach(var ct in t)
                    {
                        if(ct.SOPHUTSD.HasValue)
                            totalMinute += ct.SOPHUTSD.Value;
                        if(ct.CUOCPHI.HasValue)
                            totalMoney += ct.CUOCPHI.Value;
                    }

                    lblSoPhut.Text = totalMinute.ToString();
                    lblSoTien.Text = string.Format("{0:#,##0}", totalMoney);
                }


                gvCTSD.DataSource = t.ToList();
                gvCTSD.DataBind();

                var t2 = from hddk in db.HDDKs
                         where hddk.IDKH == currentKH.ID
                        select new
                        {
                            hddk.IDSIM,
                            hddk.NGAYBD,
                            hddk.NGAYKT,
                            hddk.CUOCDK
                        };

                if(t2.Count() != 0)
                {
                    divHDDK.Visible = true;
                }

                gvHDDK.DataSource = t2.ToList();
                gvHDDK.DataBind();


                var t3 = from hdtc in db.HDTCs
                         where hdtc.IDKH == currentKH.ID
                         select new
                         {
                             hdtc.IDSIM,
                             hdtc.THANG,
                             hdtc.NAM,
                             hdtc.TONGTIEN,
                             hdtc.THANHTOAN
                         };

                if (t3.Count() != 0)
                {
                    divHDTC.Visible = true;
                }
                gvHDTC.DataSource = t3.ToList();
                gvHDTC.DataBind();
            }
        }
    }
}