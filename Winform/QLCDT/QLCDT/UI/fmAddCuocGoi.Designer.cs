namespace QLCDT.UI
{
    partial class fmAddCuocGoi
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
            this.tbData = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnAutoGen = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(23, 95);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(489, 469);
            this.tbData.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 595);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 58);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Thêm dữ liệu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAutoGen
            // 
            this.btnAutoGen.Location = new System.Drawing.Point(286, 595);
            this.btnAutoGen.Name = "btnAutoGen";
            this.btnAutoGen.Size = new System.Drawing.Size(226, 58);
            this.btnAutoGen.TabIndex = 1;
            this.btnAutoGen.Text = "Sinh tự động";
            this.btnAutoGen.Click += new System.EventHandler(this.btnAutoGen_Click);
            // 
            // fmAddCuocGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 676);
            this.Controls.Add(this.btnAutoGen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbData);
            this.Name = "fmAddCuocGoi";
            this.Text = "Thêm cuộc gọi";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbData;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnAutoGen;
    }
}