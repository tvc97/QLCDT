using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCDT.BUS;

namespace QLCDT.UI
{
    public partial class fmAddCuocGoi : MetroFramework.Forms.MetroForm
    {
        protected Action callback;
        public fmAddCuocGoi(Action callback)
        {
            InitializeComponent();

            this.callback = callback;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] t = tbData.Text.Split('\n');
            ChiTietSuDungBUS bus = new ChiTietSuDungBUS();

            try
            {
                foreach (string s in t)
                {
                    string[] parts = s.Trim().Split('\t');
                    CHITIETSD ctsd = new CHITIETSD();
                    ctsd.IDSIM = parts[0];
                    ctsd.TGBD = DateTime.Parse(parts[1]);
                    ctsd.TGKT = DateTime.Parse(parts[2]);
                    ctsd.SOPHUTSD = FunctionsBUS.SoPhut(parts[1], parts[2]);
                    ctsd.CUOCPHI = FunctionsBUS.TinhCuoc(parts[1], parts[2]);

                    bus.AddCTSD(ctsd);
                }

                if (callback != null) callback();
                MessageBox.Show("Thêm danh sách cuộc gọi thành công", "Thông báo!");
            }
            catch
            {
                MessageBox.Show("Không thêm được", "Thông báo!");

            }
        }

        private void btnAutoGen_Click(object sender, EventArgs e)
        {
            SimBUS bus = new SimBUS();
            string t = "", lastSim = "", curSim = "";
            DateTime anchor = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            Random rd = new Random();
            for (int i = 0; i < 100; i++)
            {
                curSim = bus.GetRandom().IDSIM;
                if(curSim == lastSim) { i--; continue; }
                t += curSim + "\t";
                DateTime start = anchor.AddSeconds(rd.Next(2500000));
                DateTime end = start.AddSeconds(rd.Next(2000));
                t += start.ToString() + "\t";
                t += end.ToString() + "\r\n";
                lastSim = curSim;
            }

            tbData.Text = t.Trim();
        }
    }
}
