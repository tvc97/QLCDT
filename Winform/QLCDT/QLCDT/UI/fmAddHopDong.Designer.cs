namespace QLCDT.UI
{
    partial class fmAddHopDong
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
            this.cbSIM = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbKhachHang = new MetroFramework.Controls.MetroComboBox();
            this.tbPhiDK = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
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
            this.tableLayoutPanel1.Controls.Add(this.cbSIM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbKhachHang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPhiDK, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 139);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbSIM
            // 
            this.cbSIM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSIM.FormattingEnabled = true;
            this.cbSIM.ItemHeight = 23;
            this.cbSIM.Location = new System.Drawing.Point(134, 53);
            this.cbSIM.Margin = new System.Windows.Forms.Padding(5);
            this.cbSIM.Name = "cbSIM";
            this.cbSIM.Size = new System.Drawing.Size(424, 29);
            this.cbSIM.TabIndex = 9;
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
            // cbKhachHang
            // 
            this.cbKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.ItemHeight = 23;
            this.cbKhachHang.Location = new System.Drawing.Point(134, 9);
            this.cbKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(424, 29);
            this.cbKhachHang.TabIndex = 8;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(222, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm Đăng Ký";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fmAddHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 369);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fmAddHopDong";
            this.Text = "Thêm hợp đồng đăng ký";
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
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroComboBox cbSIM;
        private MetroFramework.Controls.MetroComboBox cbKhachHang;
        private System.Windows.Forms.NumericUpDown tbPhiDK;
    }
}