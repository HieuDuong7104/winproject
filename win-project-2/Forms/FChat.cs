using Firebase.Auth;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DataClass;
using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class FChat : Form
    {
        private DB dt;
        public string receiver = "";
        public string combinedString = "";
        public FChat(string id)
        {
            InitializeComponent();
            dt = new DB();
            dt.OnMessageReceived += dt_OnMessageReceived;
            receiver = id;
            string[] users = new string[] { GlobalVariables.id, id };
            Array.Sort(users);

            // Ghép hai chuỗi đã sắp xếp
            combinedString = String.Join("-", users);
            dt.ListenForNewMessages(combinedString);
            
        }
        private async void dt_OnMessageReceived(string message)
        {
            // Xử lý tin nhắn mới tại đây
            // Ví dụ: cập nhật giao diện người dùng hoặc lưu tin nhắn vào một biến
            Console.WriteLine("Tin nhắn mới: " + message);
            createMessage(message);
            

        }

        private void createMessage(string input)
        {
            if (!input.Contains("-"))
            {
                Console.WriteLine("Chuỗi không hợp lệ. Không có dấu '-' để tách.");
                return; // Dừng hàm nếu không có dấu '-'
            }

            string[] parts = input.Split('-');
            if (parts.Length < 3)
            {
                Console.WriteLine("Chuỗi không hợp lệ. Cần có ít nhất hai dấu '-' để tách thành ba phần.");
                return; // Dừng hàm nếu không đủ phần để tách
            }

            // Gán giá trị cho các biến từ các phần tách được
            string sender = parts[0];
            string receive = parts[1];
            string content = String.Join("-", parts.Skip(2)); // Nối lại phần còn lại của chuỗi nếu có nhiều hơn một dấu '-'


            Console.WriteLine($"sender = {sender}, receive = {receive}, content = {content}");

            UserControl userControl;

            if (GlobalVariables.id == sender)
            {
                UCSendMesage userControl2 = new UCSendMesage();
                //userControl2.Dock = DockStyle.Top;
                userControl2.Title = content;
                userControl = userControl2;
            }
            else
            {
                UCReceive userControl3 = new UCReceive();
                //userControl3.Dock = DockStyle.Top;
                userControl3.Title = content;
                //userControl3.Icon = guna2CirclePictureBox2.Image;
                userControl = userControl3;
            }

            // Kiểm tra xem có cần sử dụng Invoke không
          
             if (flowLayoutPanel1.InvokeRequired)
            {
                // Sử dụng Invoke để thực hiện hành động từ UI thread
                flowLayoutPanel1.Invoke(new Action(() =>
                {
                    flowLayoutPanel1.Controls.Add(userControl);
                    // Cuộn xuống sau khi thêm control
                    flowLayoutPanel1.ScrollControlIntoView(userControl);
                }));
            }
            else
            {
                // Nếu đã ở UI thread, thêm control và cuộn xuống trực tiếp
                flowLayoutPanel1.Controls.Add(userControl);
                // Cuộn xuống sau khi thêm control
                flowLayoutPanel1.ScrollControlIntoView(userControl);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            if(guna2TextBox1.Text != "")
            {
                string mess = GlobalVariables.id + "-" + receiver + "-" + guna2TextBox1.Text;
                dt.SendMessage(combinedString ,mess);
                guna2TextBox1.Clear();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
