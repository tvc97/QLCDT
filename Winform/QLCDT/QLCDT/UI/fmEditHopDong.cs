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
    public partial class fmEditHopDong : MetroFramework.Forms.MetroForm
    {
        protected HDDK hd;
        protected Action callback;

        public fmEditHopDong(HDDK hd, Action callback)
        {
            InitializeComponent();

            lblKhachHang.Text = hd.KHACHHANG.TENKH;
            lblSIM.Text = hd.IDSIM;
            tbPhiDK.Value = hd.CUOCDK;

            this.hd = hd;
            this.callback = callback;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            hd.CUOCDK = tbPhiDK.Value;

            HopDongDangKyBUS bus = new HopDongDangKyBUS();
            try
            {
                bus.EditHDDK(hd);
                if (this.callback != null) callback();
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo!");
            }
            catch
            {
                MessageBox.Show("Không sửa được!", "Thông báo!");
            }

        }
    }
}
