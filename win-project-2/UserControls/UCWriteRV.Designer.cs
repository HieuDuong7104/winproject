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
            this.lb_name.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_name.Location = new System.Drawing.Point(96, 73);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(563, 31);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "label1";
            // 
            // btn_rv
            // 
            this.btn_rv.Location = new System.Drawing.Point(743, 52);
            this.btn_rv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rv.Name = "btn_rv";
            this.btn_rv.Size = new System.Drawing.Size(184, 67);
            this.btn_rv.TabIndex = 1;
            this.btn_rv.Text = "Viết đánh giá";
            this.btn_rv.UseVisualStyleBackColor = true;
            this.btn_rv.Click += new System.EventHandler(this.btn_rv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(9, 10);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UCWriteRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_rv);
            this.Controls.Add(this.lb_name);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCWriteRV";
            this.Size = new System.Drawing.Size(1135, 179);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_rv;
        private System.Windows.Forms.Button button1;
    }
}
