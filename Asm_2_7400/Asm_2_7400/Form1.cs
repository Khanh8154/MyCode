using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm_2_7400
{
    public partial class LoginForm : Form
    {
        
        SqlConnection connection;
        string connectionString = "Server= DESKTOP-4EAN90E\\SQLEXPRESS; Database= Asm2_7400; Integrated Security=True;";
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassword.Text;
            
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                Form_Select Fbl = new Form_Select();
                Fbl.ShowDialog();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
          

        }
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT u.UserID, u.Name 
                FROM [user] u
                INNER JOIN accounts a ON u.UserID = a.UserID
                WHERE a.Username = @Username AND a.PasswordHash = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        UserSession.UserID = reader.GetInt32(0);
                        UserSession.UserName = reader.GetString(1);
                        reader.Close();

                        string updateQuery = "UPDATE accounts SET lastLogin = @lastLogin WHERE UserID = @UserID";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@lastLogin", DateTime.Now);
                        updateCmd.Parameters.AddWithValue("@UserID", UserSession.UserID);
                        updateCmd.ExecuteNonQuery();

                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }
        public static class UserSession
        {
            public static int UserID { get; set; }
            public static string UserName { get; set; }
        }


    }
}
