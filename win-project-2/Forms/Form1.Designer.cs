namespace win_project_2
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btSignOut = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btHome = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.iconButton3);
            this.panelMenu.Controls.Add(this.btSignOut);
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.btHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 674);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Quicksand", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 453);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(230, 102);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.TabStop = false;
            this.btnMenu.Tag = "Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Quicksand", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Message;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 302);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(230, 151);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Tag = "Chat";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Quicksand", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Signal;
            this.iconButton3.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 210);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(230, 92);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.TabStop = false;
            this.iconButton3.Tag = "Statistic";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btSignOut
            // 
            this.btSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSignOut.FlatAppearance.BorderSize = 0;
            this.btSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignOut.Font = new System.Drawing.Font("Quicksand", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btSignOut.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSignOut.Location = new System.Drawing.Point(0, 616);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(230, 58);
            this.btSignOut.TabIndex = 1;
            this.btSignOut.Tag = "Sign out";
            this.btSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSignOut.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Quicksand", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.iconButton2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 94);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(230, 116);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Tag = "Account";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btHome
            // 
            this.btHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Quicksand", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btHome.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(230, 94);
            this.btHome.TabIndex = 0;
            this.btHome.Tag = "Home";
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1078, 87);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleDown;
            this.btnMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 15;
            this.btnMinimize.Location = new System.Drawing.Point(954, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 25);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 15;
            this.btnMaximize.Location = new System.Drawing.Point(993, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(44, 25);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 15;
            this.btnClose.Location = new System.Drawing.Point(1034, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 87);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1078, 587);
            this.panelDesktop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 674);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btHome;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btSignOut;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnMenu;
    }
}

