using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using eKasa.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;
using Microsoft.VisualBasic.Devices;



namespace eKasa
{
    static class ConnectMe
    {
        public static SqlConnection Connection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
    /*
     * The idea behind this is that there is only one active user per login, although a user can run > 1 .exe file. 
     * We implement that restriction by having only one user instance instantiated using the Singleton pattern. 
     * First is the straight-forward approach.
     */

    public partial class Login : Form
    {
        public string username;
        public string user_password;
        String role;




        public Login(string role)
        {
            this.role = role;

            InitializeComponent();


        }

        public void ClearStatus(List<TextBox> fields)
        {
            foreach (TextBox field in fields)
            {
                field.Text = string.Empty;
            }
        }

        public void OpenDialog(Form formInstance)
        {
            this.Hide();
            ClearStatus(new List<TextBox> { txt_username, txt_password });
            formInstance.ShowDialog();
            this.Show();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HandleLogin()
        {
            username = txt_username.Text.Trim();
            user_password = txt_password.Text.Trim();

            Form selectedForm = role == "1" ? (Form)new WaiterView() : new ManagerView(username);

            Action dialog = () => OpenDialog(selectedForm);

            UserSessionManager.LogUserIn(username, user_password, role, dialog);
        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            HandleLogin();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HandleLogin();
            }
        }
    }
    
}
