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
            DecideWhoYouAre("1");
        }

        private void Iammanager_btn_Click(object sender, EventArgs e)
        {
            DecideWhoYouAre("2");
        }

        private void DecideWhoYouAre(string role)
        {
            Login loginForm = new Login(role);
            this.Hide();
            loginForm.ShowDialog();
        }

        private void Starting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
