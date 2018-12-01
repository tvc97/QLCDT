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
    public partial class fmThanhToan : MetroFramework.Forms.MetroForm
    {
        public fmThanhToan()
        {
            InitializeComponent();

            LoadThanhToan();
        }

        public void LoadThanhToan()
        {
            gvThanhToan.DataSource = ThanhToanBUS.LoadThanhToan();
        }
    }
}
