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
    public partial class fmSim : MetroFramework.Forms.MetroForm
    {
        protected string selectedID = "";

        public fmSim()
        {
            InitializeComponent();

            LoadTTS();
        }

        public void LoadTTS()
        {
            string keyword = tbKeyword.Text;

            gvSim.DataSource = SimBUS.LoadSim().Where(x => 
                keyword.Length == 0 ||
                x.IDSIM.Contains(keyword)
            ).ToList();
        }

        private void tAdd_Click(object sender, EventArgs e)
        {
            Form fAddSim = new fmAddSim(LoadTTS);
            fAddSim.Show();
        }

        private void tDelete_Click(object sender, EventArgs e)
        {
            getSelectedID();
            if (selectedID != "")
            {
                if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        SimBUS simBus = new SimBUS();
                        simBus.DeleteSim(selectedID);
                        LoadTTS();

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
            if (gvSim.SelectedRows.Count == 0)
            {
                selectedID = "";
            }
            else
            {
                int rowIndex = gvSim.SelectedRows[0].Index;
                selectedID = gvSim.Rows[rowIndex].Cells[0].Value.ToString();
            }
        }

        private void tbKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            LoadTTS();
        }
    }
}
