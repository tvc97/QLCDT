using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCDT.UI;

namespace QLCDT
{
    public partial class fmMain : MetroFramework.Forms.MetroForm
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Form khachHang = new fmKhachHang();
            khachHang.Show();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            Form hopDong = new fmHopDong();
            hopDong.Show();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            Form sim = new fmSim();
            sim.Show();
        }

        private void btnGoiCuoc_Click(object sender, EventArgs e)
        {
            Form goiCuoc = new fmGiaCuoc();
            goiCuoc.Show();
        }

        private void btnCuocGoi_Click(object sender, EventArgs e)
        {
            Form cuocGoi = new fmCuocGoi();
            cuocGoi.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Form thanhToan = new fmThanhToan();
            thanhToan.Show();
        }
    }
}
