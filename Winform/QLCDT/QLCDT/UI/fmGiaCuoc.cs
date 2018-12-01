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
    public partial class fmGiaCuoc : MetroFramework.Forms.MetroForm
    {
        public fmGiaCuoc()
        {
            InitializeComponent();

            LoadGiaCuoc();
        }

        public void LoadGiaCuoc()
        {
            gvGiaCuoc.DataSource = GiaCuocBUS.LoadGiaCuoc();
        }

        private void tDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
