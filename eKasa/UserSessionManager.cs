using eKasa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace eKasa
{
    public static class UserSessionManager
    {
        public static void LogUserIn(string txt_username, string user_password, string role, Action dialogInstance)
        {
            string username = txt_username;
            string password = user_password;
            string roleName = role;

            try
            {
                string query = $"SELECT * FROM Users WHERE username = @username AND password = @password AND role = @role";

                using (SqlConnection conn = ConnectMe.Connection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", user_password);
                        cmd.Parameters.AddWithValue("@role", roleName);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);

                        if (dtable.Rows.Count > 0)
                        {
                            int id = (from DataRow dr in dtable.Rows select (int)dr["id"]).FirstOrDefault();

                            Users users = new Users();
                            string query_for_activity = "UPDATE Users SET is_active = @is_active WHERE id = @id";

                            using (SqlCommand cmd2 = new SqlCommand(query_for_activity, conn))
                            {
                                cmd2.Parameters.AddWithValue("@is_active", 1);
                                cmd2.Parameters.AddWithValue("@id", id);

                                cmd2.ExecuteNonQuery();

                                if (role == "1")
                                {
                                    dialogInstance();
                                }
                                else if (role == "2")
                                {
                                    dialogInstance();

                                }
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
        public static bool LogUserOut()
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
    }
}
