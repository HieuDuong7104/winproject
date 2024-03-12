using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_project_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = guna2TextBox1.Text;
            GlobalVariables.Variable = email.Split('@')[0];
            string password = guna2TextBox2.Text;
            var firebase = new Firebase();
            var signInResult = await firebase.SignInAsync(email, password);

            if (signInResult != null)
            {
                // Chuyển đến Form2 nếu đăng nhập thành công
                //Form2 form2 = new Form2();
                //this.Hide();
                //form2.ShowDialog();
                //this.Close();
                
                MessageBox.Show("Đăng nhập thành công.");
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại thông tin.");
            }
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            string email = guna2TextBox1.Text;
            GlobalVariables.Variable = email.Split('@')[0];
            string password = guna2TextBox2.Text;
            var firebase = new Firebase();
            await firebase.CreateUser(email, password);

            

        }
    }
}
