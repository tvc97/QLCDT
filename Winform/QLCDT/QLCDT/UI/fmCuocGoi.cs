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
    public partial class fmCuocGoi : MetroFramework.Forms.MetroForm
    {
        public fmCuocGoi()
        {
            InitializeComponent();

            LoadCuocGoi();
        }

        public void LoadCuocGoi()
        {
            gvCuocGoi.DataSource = ChiTietSuDungBUS.LoadCTSD();
        }

        private void tAdd_Click(object sender, EventArgs e)
        {
            Form fmAdd = new fmAddCuocGoi(LoadCuocGoi);
            fmAdd.Show();
        }

        private void tDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    ChiTietSuDungBUS bus = new ChiTietSuDungBUS();
                    bus.CleanAll();
                    LoadCuocGoi();

                    MessageBox.Show("Đã xóa!", "Thông báo!");
                }
                catch
                {
                    MessageBox.Show("Không thể xóa!", "Thông báo!");
                }
            }
        }
    }
}
