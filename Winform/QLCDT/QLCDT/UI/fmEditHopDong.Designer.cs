namespace QLCDT.UI
{
    partial class fmEditHopDong
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbPhiDK = new System.Windows.Forms.NumericUpDown();
            this.lblKhachHang = new MetroFramework.Controls.MetroLabel();
            this.lblSIM = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiDK)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.24109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.75891F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPhiDK, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblKhachHang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSIM, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 139);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(7, 92);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(118, 43);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Phí đăng ký";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(7, 48);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 43);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "SIM";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(7, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 43);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Khách hàng";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPhiDK
            // 
            this.tbPhiDK.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbPhiDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhiDK.Location = new System.Drawing.Point(134, 100);
            this.tbPhiDK.Margin = new System.Windows.Forms.Padding(5, 8, 8, 8);
            this.tbPhiDK.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tbPhiDK.Name = "tbPhiDK";
            this.tbPhiDK.Size = new System.Drawing.Size(120, 22);
            this.tbPhiDK.TabIndex = 10;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKhachHang.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKhachHang.Location = new System.Drawing.Point(132, 4);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(428, 43);
            this.lblKhachHang.TabIndex = 11;
            this.lblKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSIM
            // 
            this.lblSIM.AutoSize = true;
            this.lblSIM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSIM.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSIM.Location = new System.Drawing.Point(132, 48);
            this.lblSIM.Name = "lblSIM";
            this.lblSIM.Size = new System.Drawing.Size(428, 43);
            this.lblSIM.TabIndex = 12;
            this.lblSIM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(222, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 48);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập Nhật Đăng Ký";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // fmEditHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 357);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fmEditHopDong";
            this.Text = "Sửa hợp đồng đăng ký";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown tbPhiDK;
        private MetroFramework.Controls.MetroLabel lblKhachHang;
        private MetroFramework.Controls.MetroLabel lblSIM;
        private MetroFramework.Controls.MetroButton btnUpdate;
    }
}