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
    public partial class fmHopDong : MetroFramework.Forms.MetroForm
    {
        protected int selectedID = -1;
        public HopDongDangKyBUS hddkBUS = new HopDongDangKyBUS();

        public fmHopDong()
        {
            InitializeComponent();

            LoadHDDK();
        }

        public void LoadHDDK()
        {
            string keyword = tbKeyword.Text;

            gvHDDK.DataSource = HopDongDangKyBUS.LoadHDDK().Where(x =>
                keyword.Length == 0 ||
                x.KHACHHANG.ToString().Contains(keyword) ||
                x.IDSIM.Contains(keyword) ||
                x.NgayBD.Contains(keyword) ||
                x.NgayKT.Contains(keyword)
            ).ToList();
        }

        private void tAdd_Click(object sender, EventArgs e)
        {
            Form fAddHopDong = new fmAddHopDong(LoadHDDK);
            fAddHopDong.Show();
        }

        protected void getSelectedID()
        {
            if (gvHDDK.SelectedRows.Count == 0)
            {
                selectedID = -1;
            }
            else
            {
                int rowIndex = gvHDDK.SelectedRows[0].Index;
                selectedID = int.Parse(gvHDDK.Rows[rowIndex].Cells[0].Value.ToString());
            }
        }

        private void tEdit_Click(object sender, EventArgs e)
        {
            getSelectedID();

            if (selectedID != -1)
            {
                int rowIndex = gvHDDK.SelectedRows[0].Index;
                Form fEdit = new fmEditHopDong(hddkBUS.GetByID(selectedID), LoadHDDK);
                fEdit.Show();
            }
        }

        private void tDelete_Click(object sender, EventArgs e)
        {
            getSelectedID();
            if (selectedID != -1)
            {
                if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        hddkBUS.DeleteHDDK(selectedID);
                        LoadHDDK();

                        MessageBox.Show("Đã xóa!", "Thông báo!");
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa!", "Thông báo!");
                    }
                }
            }
        }

        private void tbKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            LoadHDDK();
        }
    }
}
