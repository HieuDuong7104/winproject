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
            this.lb_jobname.AutoSize = true;
            this.lb_jobname.Location = new System.Drawing.Point(108, 49);
            this.lb_jobname.Name = "lb_jobname";
            this.lb_jobname.Size = new System.Drawing.Size(44, 16);
            this.lb_jobname.TabIndex = 0;
            this.lb_jobname.Text = "label1";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(328, 49);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(44, 16);
            this.lb_status.TabIndex = 1;
            this.lb_status.Text = "label2";
            // 
            // btn_complete
            // 
            this.btn_complete.Location = new System.Drawing.Point(624, 49);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(128, 23);
            this.btn_complete.TabIndex = 2;
            this.btn_complete.Text = "HOÀN THÀNH";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // UCWaitJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_jobname);
            this.Name = "UCWaitJob";
            this.Size = new System.Drawing.Size(812, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_jobname;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_complete;
    }
}
