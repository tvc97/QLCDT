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
    public partial class fmAddSim : MetroFramework.Forms.MetroForm
    {
        Action callback;

        public fmAddSim(Action callback)
        {
            InitializeComponent();

            this.callback = callback;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            THONGTINSIM tts = new THONGTINSIM();
            tts.IDSIM = tbIDSIM.Text;
            tts.SDT = tbIDSIM.Text;
            tts.TINHTRANG = true;

            SimBUS bus = new SimBUS();
            try
            {
                if (tts.IDSIM.Length == 0) throw new Exception("");
                bus.AddSim(tts);
                if (callback != null) callback();

                MessageBox.Show("Thêm SIM thành công", "Thông báo!");
            }
            catch
            {
                MessageBox.Show("Không thêm được", "Thông báo!");
            }
        }
    }
}
