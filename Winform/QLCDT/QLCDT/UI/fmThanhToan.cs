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

            cbMonth.SelectedIndex = cbMonth.FindStringExact(DateTime.Now.Month.ToString());
            cbYear.SelectedIndex = cbYear.FindStringExact(DateTime.Now.Year.ToString());

            cbFMonth.SelectedIndex = cbMonth.FindStringExact(DateTime.Now.Month.ToString());
            cbFYear.SelectedIndex = cbYear.FindStringExact(DateTime.Now.Year.ToString());

            LoadThanhToan();
        }

        public void LoadThanhToan()
        {
            List<HDTC> dts;
            if (cbFMonth.SelectedItem != null && cbFYear.SelectedItem != null)
                dts = ThanhToanBUS.LoadThanhToan().Where(x =>
                    x.THANG.ToString() == cbFMonth.SelectedItem.ToString() &&
                    x.NAM.ToString() == cbFYear.SelectedItem.ToString()
                ).ToList();
            else
                dts = ThanhToanBUS.LoadThanhToan();

            string keyword = tbKeyword.Text;

            gvThanhToan.DataSource = dts.Where(x =>
                keyword.Length == 0 ||
                x.KHACHHANG.ToString().Contains(keyword) ||
                x.IDSIM.Contains(keyword) ||
                x.ThanhToan.Contains(keyword)
            ).ToList();
        }

        private void tCalc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa toàn bộ dữ liệu tháng đã chọn và tính lại?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
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

        private void cbFMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThanhToan();
        }

        private void cbFYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThanhToan();
        }

        private void tbKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            LoadThanhToan();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(gvThanhToan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng muốn cập nhật trạng thái thanh toán", "Thông báo!");
                return;
            }

            if (MessageBox.Show("Xác nhận cập nhật trạng thái thanh toán?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    ThanhToanBUS bus = new ThanhToanBUS();

                    foreach (DataGridViewRow row in gvThanhToan.SelectedRows)
                    {
                        HDTC hd = bus.GetByID(int.Parse(gvThanhToan.Rows[row.Index].Cells[0].Value.ToString()));

                        hd.THANHTOAN = true;

                        bus.EditThanhToan(hd);
                    }

                    LoadThanhToan();

                    MessageBox.Show("Đã cập nhật!", "Thông báo!");
                }
                catch
                {
                    MessageBox.Show("Không thể cập nhật!", "Thông báo!");
                }
            }
        }
    }
}
