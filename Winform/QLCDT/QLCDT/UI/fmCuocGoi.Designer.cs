namespace QLCDT.UI
{
    partial class fmCuocGoi
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
            this.tAdd = new MetroFramework.Controls.MetroTile();
            this.gvCuocGoi = new System.Windows.Forms.DataGridView();
            this.tDelete = new MetroFramework.Controls.MetroTile();
            this.tDelMulti = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbKeyword = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuocGoi)).BeginInit();
            this.SuspendLayout();
            // 
            // tAdd
            // 
            this.tAdd.Location = new System.Drawing.Point(33, 82);
            this.tAdd.Name = "tAdd";
            this.tAdd.Size = new System.Drawing.Size(101, 83);
            this.tAdd.TabIndex = 4;
            this.tAdd.Text = "Thêm";
            this.tAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tAdd.TileImage = global::QLCDT.Properties.Resources.add1;
            this.tAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tAdd.UseTileImage = true;
            this.tAdd.Click += new System.EventHandler(this.tAdd_Click);
            // 
            // gvCuocGoi
            // 
            this.gvCuocGoi.AllowUserToAddRows = false;
            this.gvCuocGoi.AllowUserToDeleteRows = false;
            this.gvCuocGoi.AllowUserToResizeRows = false;
            this.gvCuocGoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCuocGoi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvCuocGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCuocGoi.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvCuocGoi.Location = new System.Drawing.Point(33, 205);
            this.gvCuocGoi.Name = "gvCuocGoi";
            this.gvCuocGoi.ReadOnly = true;
            this.gvCuocGoi.RowHeadersVisible = false;
            this.gvCuocGoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCuocGoi.Size = new System.Drawing.Size(822, 299);
            this.gvCuocGoi.TabIndex = 6;
            // 
            // tDelete
            // 
            this.tDelete.Location = new System.Drawing.Point(288, 82);
            this.tDelete.Name = "tDelete";
            this.tDelete.Size = new System.Drawing.Size(101, 83);
            this.tDelete.TabIndex = 7;
            this.tDelete.Text = "Xóa toàn bộ";
            this.tDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tDelete.TileImage = global::QLCDT.Properties.Resources.delete1;
            this.tDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tDelete.UseTileImage = true;
            this.tDelete.Click += new System.EventHandler(this.tDelete_Click);
            // 
            // tDelMulti
            // 
            this.tDelMulti.Location = new System.Drawing.Point(160, 82);
            this.tDelMulti.Name = "tDelMulti";
            this.tDelMulti.Size = new System.Drawing.Size(101, 83);
            this.tDelMulti.TabIndex = 7;
            this.tDelMulti.Text = "Xóa";
            this.tDelMulti.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tDelMulti.TileImage = global::QLCDT.Properties.Resources.delete1;
            this.tDelMulti.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tDelMulti.UseTileImage = true;
            this.tDelMulti.Click += new System.EventHandler(this.tDelMulti_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(465, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Từ khóa tìm kiếm:";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(601, 142);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(254, 23);
            this.tbKeyword.TabIndex = 8;
            this.tbKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbKeyword_KeyUp);
            // 
            // fmCuocGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 527);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.tDelMulti);
            this.Controls.Add(this.tDelete);
            this.Controls.Add(this.gvCuocGoi);
            this.Controls.Add(this.tAdd);
            this.Name = "fmCuocGoi";
            this.Text = "Danh sách cuộc gọi";
            ((System.ComponentModel.ISupportInitialize)(this.gvCuocGoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile tAdd;
        private System.Windows.Forms.DataGridView gvCuocGoi;
        private MetroFramework.Controls.MetroTile tDelete;
        private MetroFramework.Controls.MetroTile tDelMulti;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbKeyword;
    }
}