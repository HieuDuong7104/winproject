namespace win_project_2.UserControls
{
    partial class UCAccept
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_dsth = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(202, 40);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(196, 47);
            this.btn_info.TabIndex = 0;
            this.btn_info.Text = "Xen thông tin người thợ";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_dsth
            // 
            this.btn_dsth.Location = new System.Drawing.Point(460, 40);
            this.btn_dsth.Name = "btn_dsth";
            this.btn_dsth.Size = new System.Drawing.Size(164, 47);
            this.btn_dsth.TabIndex = 1;
            this.btn_dsth.Text = "Accept";
            this.btn_dsth.UseVisualStyleBackColor = true;
            this.btn_dsth.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(15, 55);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(93, 16);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "ĐƠN XIN VIỆC";
            // 
            // UCAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.btn_dsth);
            this.Controls.Add(this.btn_info);
            this.Name = "UCAccept";
            this.Size = new System.Drawing.Size(761, 132);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_dsth;
        private System.Windows.Forms.Label lb_name;
    }
}
