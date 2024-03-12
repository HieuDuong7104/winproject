using Firebase.Auth;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var up = new Data();
            up.uploadFile(@"C:\Users\LENOVO\Documents\Important\avatar_fb.jpg");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string email = "test1@gmail.com";
            string password = "123456";
            var firebase = new Firebase();
            var signInResult = await firebase.SignInAsync(email, password);

            if (signInResult != null)
            {
                // Chuyển đến Form2 nếu đăng nhập thành công
                //Form2 form2 = new Form2();
                //this.Hide();
                //form2.ShowDialog();
                //this.Close();
                MessageBox.Show("Đăng nhập thành công. Token = " + signInResult);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại thông tin.");
            }
        }
    }
}
