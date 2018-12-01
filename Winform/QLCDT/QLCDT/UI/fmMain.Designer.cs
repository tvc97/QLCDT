namespace QLCDT
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKhachHang = new MetroFramework.Controls.MetroButton();
            this.btnHopDong = new MetroFramework.Controls.MetroButton();
            this.btnSim = new MetroFramework.Controls.MetroButton();
            this.btnGoiCuoc = new MetroFramework.Controls.MetroButton();
            this.btnCuocGoi = new MetroFramework.Controls.MetroButton();
            this.btnThanhToan = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(28, 127);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(223, 53);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Quản lý khách hàng";
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Location = new System.Drawing.Point(285, 127);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(223, 53);
            this.btnHopDong.TabIndex = 1;
            this.btnHopDong.Text = "Quản lý hợp đồng đăng ký";
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(28, 209);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(223, 53);
            this.btnSim.TabIndex = 1;
            this.btnSim.Text = "Quản lý sim";
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnGoiCuoc
            // 
            this.btnGoiCuoc.Location = new System.Drawing.Point(285, 209);
            this.btnGoiCuoc.Name = "btnGoiCuoc";
            this.btnGoiCuoc.Size = new System.Drawing.Size(223, 53);
            this.btnGoiCuoc.TabIndex = 1;
            this.btnGoiCuoc.Text = "Quản lý giá cước";
            this.btnGoiCuoc.Click += new System.EventHandler(this.btnGoiCuoc_Click);
            // 
            // btnCuocGoi
            // 
            this.btnCuocGoi.Location = new System.Drawing.Point(28, 294);
            this.btnCuocGoi.Name = "btnCuocGoi";
            this.btnCuocGoi.Size = new System.Drawing.Size(223, 53);
            this.btnCuocGoi.TabIndex = 1;
            this.btnCuocGoi.Text = "Quản lý cuộc gọi";
            this.btnCuocGoi.Click += new System.EventHandler(this.btnCuocGoi_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(285, 294);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(223, 53);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Quản lý thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(543, 395);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnCuocGoi);
            this.Controls.Add(this.btnGoiCuoc);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.btnKhachHang);
            this.Name = "fmMain";
            this.Text = "Quản lý cước điện thoại";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnKhachHang;
        private MetroFramework.Controls.MetroButton btnHopDong;
        private MetroFramework.Controls.MetroButton btnSim;
        private MetroFramework.Controls.MetroButton btnGoiCuoc;
        private MetroFramework.Controls.MetroButton btnCuocGoi;
        private MetroFramework.Controls.MetroButton btnThanhToan;
    }
}