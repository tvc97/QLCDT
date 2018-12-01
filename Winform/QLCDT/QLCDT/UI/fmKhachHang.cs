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
    public partial class fmKhachHang : MetroFramework.Forms.MetroForm
    {
        protected int selectedID = -1;
        protected KhachHangBUS khBUS = new KhachHangBUS();
        public fmKhachHang()
        {
            InitializeComponent();

        }

        private void fmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        public void LoadKH()
        {
            gvKhachHang.DataSource = KhachHangBUS.LoadKH();
        }

        private void tAdd_Click(object sender, EventArgs e)
        {
            Form fAddKH = new fmAddKhachHang(LoadKH);
            fAddKH.Show();
        }

        private void gvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        khBUS.DeleteKH(selectedID);
                        fmKhachHang_Load(null, null);

                        MessageBox.Show("Đã xóa!", "Thông báo!");
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa!", "Thông báo!");
                    }
                }
            }
        }

        protected void getSelectedID()
        {
            if(gvKhachHang.SelectedRows.Count == 0)
            {
                selectedID = -1;
            } else
            {
                int rowIndex = gvKhachHang.SelectedRows[0].Index;
                selectedID = int.Parse(gvKhachHang.Rows[rowIndex].Cells[0].Value.ToString());
            }
        }

        private void tEdit_Click(object sender, EventArgs e)
        {
            getSelectedID();
            if (selectedID != -1)
            {
                int rowIndex = gvKhachHang.SelectedRows[0].Index;

                Form fEdit = new fmEditKhachHang(khBUS.GetByID(selectedID), LoadKH);
                fEdit.Show();
            }
        }
    }
}
