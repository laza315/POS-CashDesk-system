using System;
using System.Windows.Forms;

namespace eKasa
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        private void Iamwaiter_btn_Click(object sender, EventArgs e)
        {
             DecideWhoYouAre("waiter");
        }

        private void Iammanager_btn_Click(object sender, EventArgs e)
        {
            DecideWhoYouAre("manager");
        }

        private void DecideWhoYouAre(string role)
        {
            Login loginForm = new Login(role); 
            this.Hide(); 
            loginForm.ShowDialog();
            this.Show(); 
        }
    }
}
