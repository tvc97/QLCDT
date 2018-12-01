namespace QLCDT.UI
{
    partial class fmHopDong
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
            this.gvHDDK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvHDDK)).BeginInit();
            this.SuspendLayout();
            // 
            // tDelete
            // 
            this.tDelete.Location = new System.Drawing.Point(284, 82);
            this.tDelete.Name = "tDelete";
            this.tDelete.Size = new System.Drawing.Size(101, 83);
            this.tDelete.TabIndex = 2;
            this.tDelete.Text = "Xóa";
            this.tDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tDelete.TileImage = global::QLCDT.Properties.Resources.delete1;
            this.tDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tDelete.UseTileImage = true;
            this.tDelete.Click += new System.EventHandler(this.tDelete_Click);
            // 
            // tEdit
            // 
            this.tEdit.Location = new System.Drawing.Point(156, 82);
            this.tEdit.Name = "tEdit";
            this.tEdit.Size = new System.Drawing.Size(101, 83);
            this.tEdit.TabIndex = 3;
            this.tEdit.Text = "Sửa";
            this.tEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tEdit.TileImage = global::QLCDT.Properties.Resources.edit1;
            this.tEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tEdit.UseTileImage = true;
            this.tEdit.Click += new System.EventHandler(this.tEdit_Click);
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
            // gvHDDK
            // 
            this.gvHDDK.AllowUserToAddRows = false;
            this.gvHDDK.AllowUserToDeleteRows = false;
            this.gvHDDK.AllowUserToResizeRows = false;
            this.gvHDDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHDDK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvHDDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHDDK.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvHDDK.Location = new System.Drawing.Point(33, 201);
            this.gvHDDK.MultiSelect = false;
            this.gvHDDK.Name = "gvHDDK";
            this.gvHDDK.ReadOnly = true;
            this.gvHDDK.RowHeadersVisible = false;
            this.gvHDDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHDDK.Size = new System.Drawing.Size(774, 310);
            this.gvHDDK.TabIndex = 6;
            // 
            // fmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 546);
            this.Controls.Add(this.gvHDDK);
            this.Controls.Add(this.tDelete);
            this.Controls.Add(this.tEdit);
            this.Controls.Add(this.tAdd);
            this.Name = "fmHopDong";
            this.Text = "Danh sách hợp đồng đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.gvHDDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile tDelete;
        private MetroFramework.Controls.MetroTile tEdit;
        private MetroFramework.Controls.MetroTile tAdd;
        private System.Windows.Forms.DataGridView gvHDDK;
    }
}