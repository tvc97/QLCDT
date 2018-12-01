namespace QLCDT.UI
{
    partial class fmGiaCuoc
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
            this.gvGiaCuoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaCuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // gvGiaCuoc
            // 
            this.gvGiaCuoc.AllowUserToAddRows = false;
            this.gvGiaCuoc.AllowUserToDeleteRows = false;
            this.gvGiaCuoc.AllowUserToResizeRows = false;
            this.gvGiaCuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvGiaCuoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvGiaCuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGiaCuoc.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvGiaCuoc.Location = new System.Drawing.Point(23, 90);
            this.gvGiaCuoc.MultiSelect = false;
            this.gvGiaCuoc.Name = "gvGiaCuoc";
            this.gvGiaCuoc.ReadOnly = true;
            this.gvGiaCuoc.RowHeadersVisible = false;
            this.gvGiaCuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGiaCuoc.Size = new System.Drawing.Size(597, 254);
            this.gvGiaCuoc.TabIndex = 5;
            // 
            // fmGiaCuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 373);
            this.Controls.Add(this.gvGiaCuoc);
            this.Name = "fmGiaCuoc";
            this.Text = "Danh sách giá cước";
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaCuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvGiaCuoc;
    }
}