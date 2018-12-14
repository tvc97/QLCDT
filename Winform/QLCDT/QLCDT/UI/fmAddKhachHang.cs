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
    public partial class fmAddKhachHang : MetroFramework.Forms.MetroForm
    {
        Action callback;
        public fmAddKhachHang(Action callback)
        {
            InitializeComponent();

            this.callback = callback;
        }

        public int tryParse(string t)
        {
            while (t.Length > 0 && !('0' <= t[0] && t[0] <= '9')) t = t.Substring(1);
            int rs = 0;
            int.TryParse(t, out rs);
            return rs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KhachHangBUS bus = new KhachHangBUS();
            KHACHHANG kh = new KHACHHANG();

            kh.TENKH = tbTen.Text;
            kh.CMND = tbCMND.Text;
            kh.NGHENGHIEP = tbNgheNghiep.Text;
            kh.CHUCVU = tbChucVu.Text;
            kh.DIACHI = tbDiaChi.Text;
            kh.EMAIL = tbEmail.Text;
            kh.TINHTRANG = true;

            if(!bus.validate(kh))
            {
                MessageBox.Show("Dữ liệu khách hàng không đúng", "Thông báo!");
                return;
            }

            try
            {
                bus.AddKH(kh);
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
