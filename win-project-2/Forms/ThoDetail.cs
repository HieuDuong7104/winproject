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
using win_project_2.DataClass;

namespace win_project_2.Forms
{
    public partial class ThoDetail : Form
    {
        public ThoDetail()
        {
            InitializeComponent();
        }

        private async void ThoDetail_Load(object sender, EventArgs e)
        {
            var dt = new DB();
            NguoiTho nguoitho = await dt.GetInfoNguoiTho(GlobalVariables.id);
            lb_Name.Text = nguoitho.Name;
            lb_job.Text = nguoitho.JobName;
            lb_Mail.Text = nguoitho.Email;
            lb_Sdt.Text = nguoitho.PhoneNumber;
            if (nguoitho.AvatarUrl != "")
            {
                guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(nguoitho.AvatarUrl)));

            }
        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }
    }
}
