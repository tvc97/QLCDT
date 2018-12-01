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
    public partial class fmEditKhachHang : MetroFramework.Forms.MetroForm
    {
        protected KHACHHANG kh;
        protected Action callback;
        public fmEditKhachHang(KHACHHANG kh, Action callback)
        {
            InitializeComponent();

            this.kh = kh;
            this.callback = callback;

            tbTen.Text = kh.TENKH;
            tbCMND.Text = kh.CMND;
            tbNgheNghiep.Text = kh.NGHENGHIEP;
            tbChucVu.Text = kh.CHUCVU;
            tbDiaChi.Text = kh.DIACHI;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            kh.TENKH = tbTen.Text;
            kh.CMND = tbCMND.Text;
            kh.NGHENGHIEP = tbNgheNghiep.Text;
            kh.CHUCVU = tbChucVu.Text;
            kh.DIACHI = tbDiaChi.Text;

            KhachHangBUS bus = new KhachHangBUS();
            try
            {
                bus.EditKH(kh);
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
