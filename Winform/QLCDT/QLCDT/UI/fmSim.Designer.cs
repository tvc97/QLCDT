namespace QLCDT.UI
{
    partial class fmSim
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
            this.tAdd = new MetroFramework.Controls.MetroTile();
            this.gvSim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvSim)).BeginInit();
            this.SuspendLayout();
            // 
            // tDelete
            // 
            this.tDelete.Location = new System.Drawing.Point(154, 82);
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
            // gvSim
            // 
            this.gvSim.AllowUserToAddRows = false;
            this.gvSim.AllowUserToDeleteRows = false;
            this.gvSim.AllowUserToResizeRows = false;
            this.gvSim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSim.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSim.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvSim.Location = new System.Drawing.Point(33, 201);
            this.gvSim.MultiSelect = false;
            this.gvSim.Name = "gvSim";
            this.gvSim.ReadOnly = true;
            this.gvSim.RowHeadersVisible = false;
            this.gvSim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSim.Size = new System.Drawing.Size(709, 303);
            this.gvSim.TabIndex = 6;
            // 
            // fmSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 527);
            this.Controls.Add(this.gvSim);
            this.Controls.Add(this.tDelete);
            this.Controls.Add(this.tAdd);
            this.Name = "fmSim";
            this.Text = "Danh sách sim";
            ((System.ComponentModel.ISupportInitialize)(this.gvSim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile tDelete;
        private MetroFramework.Controls.MetroTile tAdd;
        private System.Windows.Forms.DataGridView gvSim;
    }
}