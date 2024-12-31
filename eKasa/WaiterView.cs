using eKasa.Models;
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


namespace eKasa
{
    public partial class WaiterView : Form
    {
        public WaiterView()
        {
            InitializeComponent();
        }

        private bool LogUserOut()
        {
            bool user_active = true;
            string query = $"SELECT * FROM Users WHERE is_active = 1";

            using (SqlConnection conn = ConnectMe.Connection())
            {
                conn.Open();
                var command = new SqlCommand(query, conn);
                var sda = new SqlDataAdapter(command);

                DataTable dtable = new DataTable();

                sda.Fill(dtable);

                if (dtable.Rows.Count == 1)
                {
                    int id = (from DataRow dr in dtable.Rows select (int)dr["id"]).FirstOrDefault();

                    Users users = new Users();
                    string loguser_out = "UPDATE Users SET is_active = 0 WHERE id = @id";

                    while (user_active)
                    {
                        try
                        {
                            command.CommandText = loguser_out;
                            {
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                                user_active = false;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"We couldn't log you out! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
            }
            return user_active;

        }

        private void X_and_loguserout_Click(object sender, EventArgs e)
        {
            bool loged_out = LogUserOut();
            if (loged_out)
            {
                {
                    Login loginForm = new Login("");
                    this.Hide();
                    loginForm.ShowDialog();
                    this.Show();
                }
                Application.Exit();
            }

        }
    }
}
