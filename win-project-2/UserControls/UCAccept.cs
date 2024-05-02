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
using win_project_2.Forms;

namespace win_project_2.UserControls
{
    public partial class UCAccept : UserControl
    {
        string id_job = "";
        string id_nt = "";
        string id_ntt = "";
        public UCAccept(string job, string nt, string ntt)
        {
            InitializeComponent();
            id_job = job;
            id_nt = nt;
            id_ntt = ntt;
        }


        private async void btn_accept_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            await dt.AcceptWorker(id_job, id_nt, id_ntt);
        }

        private async void btn_info_Click(object sender, EventArgs e)
        {
            ThoDetail f = new ThoDetail(id_nt);
            f.ShowDialog();
        }
    }
}
