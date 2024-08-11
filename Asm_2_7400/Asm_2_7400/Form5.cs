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
    public partial class Form_manage_staff : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        string connectionString = @"Data Source=DESKTOP-4EAN90E\SQLEXPRESS;Initial Catalog=Asm2_7400;Integrated Security=True";

        public Form_manage_staff()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=DESKTOP-4EAN90E\\SQLEXPRESS; Database=Asm2_7400; Integrated Security=True;");

        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT u.UserID, u.Name, u.Position, a.LastLogin
                FROM [user] u
                INNER JOIN accounts a ON u.UserID = a.UserID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_manage_staff.DataSource = dt;
            }
        }
        private void ClearFields()
        {

            txt_StaffID.Clear();
            txt_Staf_name.Clear();
            txt_Position.Clear();

            dgv_manage_staff.ClearSelection();

        }

        private void btn_Exit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Logout4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Fmb = new LoginForm();
            Fmb.ShowDialog();
            this.Dispose();
        }

        private void Form_manage_staff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_manage_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_manage_staff.Rows[e.RowIndex];

                txt_StaffID.Text = row.Cells[0].Value.ToString();
                txt_Staf_name.Text = row.Cells[1].Value.ToString();
                txt_Position.Text = row.Cells[2].Value.ToString();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btn_Edit4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [user] SET Name = @Name, Position = @Position WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", txt_StaffID.Text);
                command.Parameters.AddWithValue("@Name", txt_Staf_name.Text);
                command.Parameters.AddWithValue("@Position", txt_Position.Text);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    LoadData();
                    MessageBox.Show("Data has been updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}
