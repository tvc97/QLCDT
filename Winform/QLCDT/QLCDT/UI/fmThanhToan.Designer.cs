namespace QLCDT.UI
{
    partial class fmThanhToan
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
            this.gvThanhToan = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbMonth = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbYear = new MetroFramework.Controls.MetroComboBox();
            this.tCalc = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbFMonth = new MetroFramework.Controls.MetroComboBox();
            this.cbFYear = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbKeyword = new MetroFramework.Controls.MetroTextBox();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvThanhToan
            // 
            this.gvThanhToan.AllowUserToAddRows = false;
            this.gvThanhToan.AllowUserToDeleteRows = false;
            this.gvThanhToan.AllowUserToResizeRows = false;
            this.gvThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvThanhToan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThanhToan.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvThanhToan.Location = new System.Drawing.Point(32, 261);
            this.gvThanhToan.Name = "gvThanhToan";
            this.gvThanhToan.ReadOnly = true;
            this.gvThanhToan.RowHeadersVisible = false;
            this.gvThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvThanhToan.Size = new System.Drawing.Size(1139, 458);
            this.gvThanhToan.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.45614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.54386F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbMonth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbYear, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(725, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 71);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 35);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tháng";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbMonth
            // 
            this.cbMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.ItemHeight = 23;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(113, 3);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(226, 29);
            this.cbMonth.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 36);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Năm";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbYear
            // 
            this.cbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.ItemHeight = 23;
            this.cbYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.cbYear.Location = new System.Drawing.Point(113, 38);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(226, 29);
            this.cbYear.TabIndex = 3;
            // 
            // tCalc
            // 
            this.tCalc.Location = new System.Drawing.Point(1073, 96);
            this.tCalc.Name = "tCalc";
            this.tCalc.Size = new System.Drawing.Size(98, 71);
            this.tCalc.TabIndex = 8;
            this.tCalc.Text = "Tính tiền";
            this.tCalc.TileImage = global::QLCDT.Properties.Resources.invoice;
            this.tCalc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tCalc.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tCalc.UseTileImage = true;
            this.tCalc.Click += new System.EventHandler(this.tCalc_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.63265F));
            this.tableLayoutPanel2.Controls.Add(this.cbFYear, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbFMonth, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel5, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(204, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 67);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(83, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Dữ liệu tháng:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel4.Location = new System.Drawing.Point(3, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 33);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Tháng";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel5.Location = new System.Drawing.Point(3, 33);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 34);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Năm";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbFMonth
            // 
            this.cbFMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFMonth.FormattingEnabled = true;
            this.cbFMonth.ItemHeight = 23;
            this.cbFMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbFMonth.Location = new System.Drawing.Point(56, 3);
            this.cbFMonth.Name = "cbFMonth";
            this.cbFMonth.Size = new System.Drawing.Size(233, 29);
            this.cbFMonth.TabIndex = 2;
            this.cbFMonth.SelectedIndexChanged += new System.EventHandler(this.cbFMonth_SelectedIndexChanged);
            // 
            // cbFYear
            // 
            this.cbFYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFYear.FormattingEnabled = true;
            this.cbFYear.ItemHeight = 23;
            this.cbFYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.cbFYear.Location = new System.Drawing.Point(56, 36);
            this.cbFYear.Name = "cbFYear";
            this.cbFYear.Size = new System.Drawing.Size(233, 29);
            this.cbFYear.TabIndex = 3;
            this.cbFYear.SelectedIndexChanged += new System.EventHandler(this.cbFYear_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(55, 207);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(130, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Từ khóa tìm kiếm:";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(217, 203);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(276, 23);
            this.tbKeyword.TabIndex = 11;
            this.tbKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbKeyword_KeyUp);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(996, 189);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(175, 37);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Xác nhận thanh toán";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // fmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 742);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tCalc);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvThanhToan);
            this.Name = "fmThanhToan";
            this.Text = "Thanh toán cước";
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvThanhToan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbMonth;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbYear;
        private MetroFramework.Controls.MetroTile tCalc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroComboBox cbFYear;
        private MetroFramework.Controls.MetroComboBox cbFMonth;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbKeyword;
        private MetroFramework.Controls.MetroButton btnConfirm;
    }
}