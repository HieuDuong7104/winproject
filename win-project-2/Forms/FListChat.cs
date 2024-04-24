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
using win_project_2.DataClass;
using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class FListChat : Form
    {
        public FListChat()
        {
            InitializeComponent();
            LoadData(GlobalVariables.id);
        }

        public async void LoadData(string id)
        {
            var dt = new DB();
            string contact = await dt.GetContactList(id);

            if (contact != "")
            {
                string[] userArray = contact.Split(',');

                foreach (string user in userArray)
                {
                    UCListChat uc = new UCListChat(user);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void FListChat_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
