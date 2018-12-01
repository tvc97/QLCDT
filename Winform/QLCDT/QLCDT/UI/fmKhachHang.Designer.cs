namespace QLCDT.UI
{
    partial class fmKhachHang
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
            this.tEdit = new MetroFramework.Controls.MetroTile();
            this.tDelete = new MetroFramework.Controls.MetroTile();
            this.gvKhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tAdd
            // 
            this.tAdd.Location = new System.Drawing.Point(33, 82);
            this.tAdd.Name = "tAdd";
            this.tAdd.Size = new System.Drawing.Size(101, 83);
            this.tAdd.TabIndex = 0;
            this.tAdd.Text = "Thêm";
            this.tAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tAdd.TileImage = global::QLCDT.Properties.Resources.add1;
            this.tAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tAdd.UseTileImage = true;
            this.tAdd.Click += new System.EventHandler(this.tAdd_Click);
            // 
            // tEdit
            // 
            this.tEdit.Location = new System.Drawing.Point(156, 82);
            this.tEdit.Name = "tEdit";
            this.tEdit.Size = new System.Drawing.Size(101, 83);
            this.tEdit.TabIndex = 0;
            this.tEdit.Text = "Sửa";
            this.tEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tEdit.TileImage = global::QLCDT.Properties.Resources.edit1;
            this.tEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tEdit.UseTileImage = true;
            this.tEdit.Click += new System.EventHandler(this.tEdit_Click);
            // 
            // tDelete
            // 
            this.tDelete.Location = new System.Drawing.Point(282, 82);
            this.tDelete.Name = "tDelete";
            this.tDelete.Size = new System.Drawing.Size(101, 83);
            this.tDelete.TabIndex = 0;
            this.tDelete.Text = "Xóa";
            this.tDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tDelete.TileImage = global::QLCDT.Properties.Resources.delete1;
            this.tDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tDelete.UseTileImage = true;
            this.tDelete.Click += new System.EventHandler(this.tDelete_Click);
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.AllowUserToAddRows = false;
            this.gvKhachHang.AllowUserToDeleteRows = false;
            this.gvKhachHang.AllowUserToResizeRows = false;
            this.gvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKhachHang.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvKhachHang.Location = new System.Drawing.Point(33, 191);
            this.gvKhachHang.MultiSelect = false;
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.ReadOnly = true;
            this.gvKhachHang.RowHeadersVisible = false;
            this.gvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvKhachHang.Size = new System.Drawing.Size(1194, 363);
            this.gvKhachHang.TabIndex = 1;
            this.gvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKhachHang_CellClick);
            // 
            // fmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 568);
            this.Controls.Add(this.gvKhachHang);
            this.Controls.Add(this.tDelete);
            this.Controls.Add(this.tEdit);
            this.Controls.Add(this.tAdd);
            this.Name = "fmKhachHang";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.fmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tAdd;
        private MetroFramework.Controls.MetroTile tEdit;
        private MetroFramework.Controls.MetroTile tDelete;
        private System.Windows.Forms.DataGridView gvKhachHang;
    }
}