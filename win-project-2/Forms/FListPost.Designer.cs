namespace win_project_2.Forms
{
    partial class FListPost
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
            this.ucShowPost1 = new win_project_2.UserControls.UCShowPost();
            this.ucShowPost2 = new win_project_2.UserControls.UCShowPost();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ucShowPost2);
            this.guna2Panel1.Controls.Add(this.ucShowPost1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(721, 702);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ucShowPost1
            // 
            this.ucShowPost1.Location = new System.Drawing.Point(22, 12);
            this.ucShowPost1.Name = "ucShowPost1";
            this.ucShowPost1.Size = new System.Drawing.Size(676, 231);
            this.ucShowPost1.TabIndex = 0;
            // 
            // ucShowPost2
            // 
            this.ucShowPost2.Location = new System.Drawing.Point(12, 12);
            this.ucShowPost2.Name = "ucShowPost2";
            this.ucShowPost2.Size = new System.Drawing.Size(697, 231);
            this.ucShowPost2.TabIndex = 1;
            // 
            // FListPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 702);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FListPost";
            this.Text = "FListPost";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UserControls.UCShowPost ucShowPost1;
        private UserControls.UCShowPost ucShowPost2;
    }
}