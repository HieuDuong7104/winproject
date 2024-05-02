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
    public partial class FListNTapply : Form
    {
        private DB dt;
        public FListNTapply()
        {
            InitializeComponent();
            dt = new DB();

            dt.OnNotify_ntt += dt_OnNotify_ntt;
            dt.ListenForNewNotify_ntt();
        }

        public async void dt_OnNotify_ntt(string notify_ntt)
        {
            string input = notify_ntt;
            char[] delimiter = { '-' };

            string[] parts = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            string id_job = parts[0];

            string remainingPart = string.Join("-", parts.Skip(1));
            
            foreach (var user in remainingPart.Split(delimiter))
            {
                UCAccept new_uc = new UCAccept(id_job, user, GlobalVariables.id);   
                flowLayoutPanel1.Invoke(new Action(() =>
                {
                    flowLayoutPanel1.Controls.Add(new_uc);
                }));
            }
        }
    }
}
