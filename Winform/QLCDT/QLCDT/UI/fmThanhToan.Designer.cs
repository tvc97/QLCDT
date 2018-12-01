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
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.gvThanhToan.Location = new System.Drawing.Point(32, 194);
            this.gvThanhToan.MultiSelect = false;
            this.gvThanhToan.Name = "gvThanhToan";
            this.gvThanhToan.ReadOnly = true;
            this.gvThanhToan.RowHeadersVisible = false;
            this.gvThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvThanhToan.Size = new System.Drawing.Size(988, 340);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 97);
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
            this.tCalc.Location = new System.Drawing.Point(409, 97);
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
            // fmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 572);
            this.Controls.Add(this.tCalc);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvThanhToan);
            this.Name = "fmThanhToan";
            this.Text = "Thanh toán cước";
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvThanhToan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbMonth;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbYear;
        private MetroFramework.Controls.MetroTile tCalc;
    }
}