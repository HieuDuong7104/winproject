using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace win_project_2
{
    public partial class FInfor : Form
    {
        string FileImageName = "";
        public FInfor()
        {
            InitializeComponent();
            this.Load += new EventHandler(InforForm_Load);

        }
        
        private void InforForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void LoadData()
        {
            var realtime = new Data();
            UserInfo userinfo = await realtime.GetData("info/" + GlobalVariables.id + "/");
            
            rjTextBox1.Texts = userinfo.Name;
            rjTextBox2.Texts = userinfo.DateOfBirth;
            rjTextBox3.Texts = userinfo.Email;
            rjTextBox4.Texts = userinfo.PhoneNumber;
            rjTextBox5.Texts = userinfo.Address;

            if (userinfo.AvatarUrl != "Chưa nhập thông tin")
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(userinfo.AvatarUrl)));

            }
        }
        public bool isEditing = false;
        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private async void rjButton2_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                var realtimedatabase = new Data();
                var path = await realtimedatabase.uploadFile(FileImageName);
                UserInfo userInfo = new UserInfo(rjTextBox1.Texts, rjTextBox2.Texts, rjTextBox3.Texts, path, rjTextBox4.Texts, rjTextBox5.Texts);

                
                realtimedatabase.UploadData("info/" + GlobalVariables.id + "/" ,userInfo);

                rjButton1.Enabled = false;
                rjTextBox1.Enabled = false;
                rjTextBox2.Enabled = false;
                rjTextBox3.Enabled = false;
                rjTextBox4.Enabled = false;
                isEditing = false;
                rjButton2.Text = "CHỈNH SỬA";
            }
            else
            {
                rjButton2.Text = "LƯU";
                rjButton1.Enabled = true;
                rjTextBox1.Enabled = true;
                rjTextBox2.Enabled = true;
                rjTextBox3.Enabled = true;
                rjTextBox4.Enabled = true;
                rjTextBox5.Enabled = true;
                isEditing = true;
            }
        }

        void LoadImage(ref string imageName)
        {
            OpenFileDialog fileImageName = new OpenFileDialog();
            if(fileImageName.ShowDialog() == DialogResult.OK)
            {
                imageName = fileImageName.FileName;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            LoadImage(ref FileImageName);

            // Sử dụng using để đảm bảo tài nguyên được giải phóng
            using (var tempImage = new Bitmap(FileImageName))
            {
                pictureBox1.Image = new Bitmap(tempImage);
            }
        }


        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
