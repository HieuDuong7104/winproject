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

namespace win_project_2.UserControls
{
    public partial class UCTho : UserControl
    {
        public UCTho(NguoiTho nguoitho)
        {
            InitializeComponent();
            LoadData(nguoitho);
        }

        public void LoadData(NguoiTho nguoitho)
        {
            lb_job.Text = nguoitho.JobName;
            lb_Name.Text = nguoitho.Name;
            if (nguoitho.AvatarUrl != "")
            {
                guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(nguoitho.AvatarUrl)));

            }
        }

        private void lb_job_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
