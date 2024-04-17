namespace win_project_2.Forms
{
    partial class FHome
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            //this.ucNhanvien2 = new win_project_2.UCNhanvien();
            //this.ucNhanvien1 = new win_project_2.UCNhanvien();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ucNhanvien2);
            this.guna2Panel1.Controls.Add(this.ucNhanvien1);
            this.guna2Panel1.Location = new System.Drawing.Point(47, 130);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(346, 565);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ucNhanvien2
            // 
            this.ucNhanvien2.Location = new System.Drawing.Point(29, 473);
            this.ucNhanvien2.Name = "ucNhanvien2";
            this.ucNhanvien2.Size = new System.Drawing.Size(268, 309);
            this.ucNhanvien2.TabIndex = 1;
            // 
            // ucNhanvien1
            // 
            this.ucNhanvien1.Location = new System.Drawing.Point(29, 17);
            this.ucNhanvien1.Name = "ucNhanvien1";
            this.ucNhanvien1.Size = new System.Drawing.Size(268, 309);
            this.ucNhanvien1.TabIndex = 0;
            this.ucNhanvien1.Load += new System.EventHandler(this.ucNhanvien1_Load_1);
            this.ucNhanvien1.Click += new System.EventHandler(this.ucNhanvien1_Click);
            // 
            // FHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 764);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FHome";
            this.Text = "FHome";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UCNhanvien ucNhanvien2;
        private UCNhanvien ucNhanvien1;
    }
}