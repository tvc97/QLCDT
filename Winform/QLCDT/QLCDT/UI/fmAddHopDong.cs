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
    public partial class fmAddHopDong : MetroFramework.Forms.MetroForm
    {
        Action callback;
        public fmAddHopDong(Action callback)
        {
            InitializeComponent();

            this.callback = callback;
            LoadData();
        }

        public void LoadData()
        {
            cbKhachHang.DataSource = KhachHangBUS.LoadKH();
            cbKhachHang.DisplayMember = "TENKH";
            cbKhachHang.ValueMember = "ID";

            cbSIM.DataSource = SimBUS.LoadNotUsedSim();
            cbSIM.DisplayMember = "IDSIM";
            cbSIM.ValueMember = "IDSIM";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HopDongDangKyBUS bus = new HopDongDangKyBUS();
            HDDK hd = new HDDK();

            try
            {
                hd.IDSIM = cbSIM.SelectedValue.ToString();
                hd.IDKH = int.Parse(cbKhachHang.SelectedValue.ToString());

                bus.AddHDDK(hd);
                if (callback != null) callback();

                MessageBox.Show("Thêm khách hàng thành công", "Thông báo!");
            }
            catch
            {
                MessageBox.Show("Không thêm được", "Thông báo!");
            }
        }
    }
}
