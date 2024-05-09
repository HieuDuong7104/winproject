namespace win_project_2.UserControls
{
    partial class UCWaitJob
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
            this.lb_jobname = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.btn_complete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_jobname
            // 
            this.lb_jobname.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_jobname.Location = new System.Drawing.Point(91, 61);
            this.lb_jobname.Name = "lb_jobname";
            this.lb_jobname.Size = new System.Drawing.Size(88, 25);
            this.lb_jobname.TabIndex = 0;
            this.lb_jobname.Text = "label1";
            // 
            // lb_status
            // 
            this.lb_status.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_status.Location = new System.Drawing.Point(275, 61);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(283, 29);
            this.lb_status.TabIndex = 1;
            this.lb_status.Text = "label2";
            // 
            // btn_complete
            // 
            this.btn_complete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_complete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_complete.Location = new System.Drawing.Point(656, 50);
            this.btn_complete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(196, 40);
            this.btn_complete.TabIndex = 2;
            this.btn_complete.Text = "Hoàn thành";
            this.btn_complete.UseVisualStyleBackColor = false;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // UCWaitJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_jobname);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCWaitJob";
            this.Size = new System.Drawing.Size(914, 151);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_jobname;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_complete;
    }
}
