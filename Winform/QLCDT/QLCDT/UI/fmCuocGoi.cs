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
            string keyword = tbKeyword.Text;

            gvCuocGoi.DataSource = ChiTietSuDungBUS.LoadCTSD().Where(x =>
                keyword.Length == 0 ||
                x.IDSIM.Contains(keyword) ||
                x.TGBD.ToString().Contains(keyword) ||
                x.TGKT.ToString().Contains(keyword)
            ).ToList();
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

        private void tDelMulti_Click(object sender, EventArgs e)
        {
            if(gvCuocGoi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn cuộc gọi muốn xóa", "Thông báo");
                return;
            }

            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    ChiTietSuDungBUS bus = new ChiTietSuDungBUS();

                    foreach(DataGridViewRow row in gvCuocGoi.SelectedRows)
                    {
                        bus.DeleteCTSD(int.Parse(gvCuocGoi.Rows[row.Index].Cells[0].Value.ToString()));
                    }

                    LoadCuocGoi();

                    MessageBox.Show("Đã xóa!", "Thông báo!");
                }
                catch
                {
                    MessageBox.Show("Không thể xóa!", "Thông báo!");
                }
            }
        }

        private void tbKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            LoadCuocGoi();
        }
    }
}
