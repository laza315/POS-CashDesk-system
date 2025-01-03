using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eKasa.Login;

namespace eKasa
{
    public partial class ManagerView : Form
    {
        private string managerUsername;
        public ManagerView(string manager_username)
        {
            InitializeComponent();
            this.managerUsername = manager_username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            managerName.Text = managerUsername + "!";
            lblDateTime.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void XandSignout(object sender, EventArgs e)
        {
            bool loged_out = UserSessionManager.LogUserOut();

            if (loged_out)
            {
                {
                    Starting starting_frm = new Starting();
                    this.Hide();
                    starting_frm.ShowDialog();
                    this.Show();
                }
                Application.Exit();
            }

        }

        private void dodaj_artikal_btn_Click(object sender, EventArgs e)
        {
            AddArticle article_frm = new AddArticle();
            this.Hide();
            this.Close();
            article_frm.ShowDialog();
            this.Show();
        }
    }
}
