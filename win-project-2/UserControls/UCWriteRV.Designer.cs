namespace win_project_2.UserControls
{
    partial class UCWriteRV
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
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_rv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(135, 64);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(44, 16);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "label1";
            // 
            // btn_rv
            // 
            this.btn_rv.Location = new System.Drawing.Point(547, 44);
            this.btn_rv.Name = "btn_rv";
            this.btn_rv.Size = new System.Drawing.Size(164, 57);
            this.btn_rv.TabIndex = 1;
            this.btn_rv.Text = "Viết đánh giá";
            this.btn_rv.UseVisualStyleBackColor = true;
            this.btn_rv.Click += new System.EventHandler(this.btn_rv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UCWriteRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_rv);
            this.Controls.Add(this.lb_name);
            this.Name = "UCWriteRV";
            this.Size = new System.Drawing.Size(746, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_rv;
        private System.Windows.Forms.Button button1;
    }
}
