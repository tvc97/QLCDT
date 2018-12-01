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
            this.gvCuocGoi.MultiSelect = false;
            this.gvCuocGoi.Name = "gvCuocGoi";
            this.gvCuocGoi.ReadOnly = true;
            this.gvCuocGoi.RowHeadersVisible = false;
            this.gvCuocGoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCuocGoi.Size = new System.Drawing.Size(716, 299);
            this.gvCuocGoi.TabIndex = 6;
            // 
            // tDelete
            // 
            this.tDelete.Location = new System.Drawing.Point(164, 82);
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
            // fmCuocGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 527);
            this.Controls.Add(this.tDelete);
            this.Controls.Add(this.gvCuocGoi);
            this.Controls.Add(this.tAdd);
            this.Name = "fmCuocGoi";
            this.Text = "Danh sách cuộc gọi";
            ((System.ComponentModel.ISupportInitialize)(this.gvCuocGoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile tAdd;
        private System.Windows.Forms.DataGridView gvCuocGoi;
        private MetroFramework.Controls.MetroTile tDelete;
    }
}