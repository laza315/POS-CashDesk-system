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

namespace eKasa
{
    public partial class Login : Form
    {
        String role;
        public Login(string role)
        {
            this.role=role;
            InitializeComponent();
        }


        static SqlConnection Connection() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        public void ClearStatus(List <TextBox> fields)
        {
            foreach (TextBox field in fields) { 
                     field.Text = string.Empty;
            }
        }

        public void OpenDialog(Form form_instance)
        {
            this.Hide();
            ClearStatus([txt_username, txt_password]);
            form_instance.ShowDialog();
            this.Show();
        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string user_password = txt_password.Text;

            try
            {
                string query = $"SELECT * FROM Users WHERE username = @username AND password = @password AND role = @role";

                using (SqlConnection conn = Connection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", user_password);
                        cmd.Parameters.AddWithValue("@role", role);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);

                        if (dtable.Rows.Count > 0)
                        {
                            if (role == "waiter")
                            {
                                WaiterView waiterview = new WaiterView();
                                OpenDialog(waiterview);
                            }
                            else if (role == "manager")
                            {
                                ManagerView managerview = new ManagerView();
                                OpenDialog(managerview);
                            }
                         
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials or role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while logging in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
