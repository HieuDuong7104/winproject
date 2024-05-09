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
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.SuspendLayout();
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(266, 66);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(196, 47);
            this.btn_info.TabIndex = 0;
            this.btn_info.Text = "Xen thông tin người thợ";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_dsth
            // 
            this.btn_dsth.Location = new System.Drawing.Point(524, 66);
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
            this.lb_name.BackColor = System.Drawing.Color.White;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_name.Location = new System.Drawing.Point(70, 74);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(146, 25);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "ĐƠN XIN VIỆC";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.White;
            this.guna2Shapes1.FillColor = System.Drawing.Color.White;
            this.guna2Shapes1.Location = new System.Drawing.Point(-43, 18);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(883, 141);
            this.guna2Shapes1.TabIndex = 3;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // UCAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.btn_dsth);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "UCAccept";
            this.Size = new System.Drawing.Size(816, 182);
            this.Load += new System.EventHandler(this.UCAccept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_dsth;
        private System.Windows.Forms.Label lb_name;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
    }
}
