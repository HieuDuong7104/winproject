using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_project_2.Forms
{
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
            guna2Panel1.AutoScroll = true;
            guna2Panel1.HorizontalScroll.Enabled = true;
            string desiredLabelName = "Software Enginer";

            foreach (Control control in guna2Panel1.Controls)
            {
                if (control is UserControl)
                {
                    UserControl userControl = control as UserControl;
                    Label labelName = userControl.Controls["lbJob"] as Label;

                    if (labelName != null && labelName.Text == desiredLabelName)
                    {
                        userControl.Visible = true;
                    }
                    else
                    {
                        userControl.Visible = false;
                    }
                }
            }

        }
        private void ucNhanvien1_Load(object sender, EventArgs e)
        {

        }

        private void ucNhanvien1_Click(object sender, EventArgs e)
        {
            // Khởi tạo một đối tượng của form NhanVienView
            NhanVienView nhanVienView = new NhanVienView();

            // Hiển thị form NhanVienView
            nhanVienView.Show();
        }

        private void ucNhanvien1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
