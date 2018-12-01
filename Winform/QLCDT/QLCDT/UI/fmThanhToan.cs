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

            cbMonth.SelectedIndex = cbMonth.FindStringExact(DateTime.Now.Month.ToString());
            cbYear.SelectedIndex = cbYear.FindStringExact(DateTime.Now.Year.ToString());
        }

        public void LoadThanhToan()
        {
            gvThanhToan.DataSource = ThanhToanBUS.LoadThanhToan();
        }

        private void tCalc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa toàn bộ dữ liệu hiện có và tính lại?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    FunctionsBUS.TinhHDTC(cbMonth.SelectedItem.ToString(), cbYear.SelectedItem.ToString());
                    LoadThanhToan();

                    MessageBox.Show("Đã tính!", "Thông báo!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Không thể tính! " + exc.Message, "Thông báo!");
                }
            }
        }
    }
}
