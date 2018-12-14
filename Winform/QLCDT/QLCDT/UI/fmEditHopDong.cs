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

            metroLabel6.Text = hd.KHACHHANG.TENKH;
            lblSIM.Text = hd.IDSIM;
            tbPhiDK.Value = hd.CUOCDK;

            dNgayBD.Value = hd.NGAYBD;
            dNgayKT.Value = hd.NGAYKT;

            this.hd = hd;
            this.callback = callback;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HopDongDangKyBUS bus = new HopDongDangKyBUS();

            hd.CUOCDK = tbPhiDK.Value;
            hd.NGAYBD = dNgayBD.Value;
            hd.NGAYKT = dNgayKT.Value;

            if (bus.checkExists(hd.IDSIM, hd.ID, dNgayBD.Value, dNgayKT.Value))
            {
                MessageBox.Show("Đã tồn tại hợp đồng đăng ký SIM này trong thời gian chọn!", "Thông báo!");
                return;
            }

            if (dNgayBD.Value > dNgayKT.Value)
            {
                MessageBox.Show("Hạn hợp đổng phải sau ngày bắt đầu!", "Thông báo!");
                return;
            }

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
