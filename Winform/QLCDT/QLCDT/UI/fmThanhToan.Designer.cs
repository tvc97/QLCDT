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
            this.tDelete = new MetroFramework.Controls.MetroTile();
            this.tEdit = new MetroFramework.Controls.MetroTile();
            this.tAdd = new MetroFramework.Controls.MetroTile();
            this.gvThanhToan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // tDelete
            // 
            this.tDelete.Location = new System.Drawing.Point(281, 77);
            this.tDelete.Name = "tDelete";
            this.tDelete.Size = new System.Drawing.Size(101, 83);
            this.tDelete.TabIndex = 2;
            this.tDelete.Text = "Xóa";
            this.tDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tDelete.TileImage = global::QLCDT.Properties.Resources.delete1;
            this.tDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tDelete.UseTileImage = true;
            // 
            // tEdit
            // 
            this.tEdit.Location = new System.Drawing.Point(155, 77);
            this.tEdit.Name = "tEdit";
            this.tEdit.Size = new System.Drawing.Size(101, 83);
            this.tEdit.TabIndex = 3;
            this.tEdit.Text = "Sửa";
            this.tEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tEdit.TileImage = global::QLCDT.Properties.Resources.edit1;
            this.tEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tEdit.UseTileImage = true;
            // 
            // tAdd
            // 
            this.tAdd.Location = new System.Drawing.Point(32, 77);
            this.tAdd.Name = "tAdd";
            this.tAdd.Size = new System.Drawing.Size(101, 83);
            this.tAdd.TabIndex = 4;
            this.tAdd.Text = "Thêm";
            this.tAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tAdd.TileImage = global::QLCDT.Properties.Resources.add1;
            this.tAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tAdd.UseTileImage = true;
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
            // fmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 572);
            this.Controls.Add(this.gvThanhToan);
            this.Controls.Add(this.tDelete);
            this.Controls.Add(this.tEdit);
            this.Controls.Add(this.tAdd);
            this.Name = "fmThanhToan";
            this.Text = "Thanh toán cước";
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile tDelete;
        private MetroFramework.Controls.MetroTile tEdit;
        private MetroFramework.Controls.MetroTile tAdd;
        private System.Windows.Forms.DataGridView gvThanhToan;
    }
}