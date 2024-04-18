using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DataClass;
using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class ThoDetail : Form
    {
        public string id;
        public ThoDetail(string id)
        {
            InitializeComponent();
            LoadData(id);
            
        }

        private async void LoadData(string id)
        {
            var dt = new DB();
            NguoiTho nguoitho = await dt.GetInfoNguoiTho(id);
            lb_Name.Text = nguoitho.Name;
            lb_job.Text = nguoitho.JobName;
            lb_Name1.Text = nguoitho.Name;
            lb_Job1.Text = nguoitho.JobName;
            lb_Mail.Text = nguoitho.Email;
            lb_Sdt.Text = nguoitho.PhoneNumber;
            if (nguoitho.AvatarUrl != "")
            {
                guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(nguoitho.AvatarUrl)));

            }

            List<Review> listReview = await dt.GetAllReview(id);
            if (listReview == null)
            {
                return;
            }
            foreach (Review review in listReview)
            {
                var new_uc = new UCRating(review);
                flowLayoutPanel1.Controls.Add(new_uc);
            }
        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes4_Click(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            await dt.AddUserToFavorites(id);
        }

        private async void bnt_Mess_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            await dt.AddtoContact(id);
            string[] users = new string[] { GlobalVariables.id, id };
            Array.Sort(users);
            string combinedString = String.Join("-", users);
            FChat f = new FChat(id);
            f.ShowDialog();
        }
        //private async void update_FavTho()
        //{

        //    // Lấy Thông tin tất cả NguoiTimTho trả về List

        //    var dt = new DB();
        //    List<NguoiTimTho> listNguoiTimTho = await dt.GetAllNguoiTimTho();
        //    foreach (NguoiTimTho nguoiTimTho in listNguoiTimTho)
        //    {
        //    }
        //}
    }
}
