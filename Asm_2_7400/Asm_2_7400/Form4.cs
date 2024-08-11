using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm_2_7400
{
    public partial class Form_book_loan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        string connectionString = @"Data Source=DESKTOP-4EAN90E\SQLEXPRESS;Initial Catalog=Asm2_7400;Integrated Security=True";
        public Form_book_loan()
        {
            InitializeComponent();
            this.btn_Add4.Click += new System.EventHandler(this.btn_Add4_Click);
            this.btn_Edit4.Click += new System.EventHandler(this.btn_Edit4_Click);
            this.btn_Del4.Click += new System.EventHandler(this.btn_Del4_Click);
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);

            connection = new SqlConnection("Server=DESKTOP-4EAN90E\\SQLEXPRESS; Database=Asm2_7400; Integrated Security=True;");


        }
        private void LoadBorrowingData()
        {
            string query = "SELECT BorrowingID, BookID, Student_name, Address, Phone, BorrowDate, ReturnDate FROM Borrowing";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv_book_loan.DataSource = table;
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add4_Click(object sender, EventArgs e)
        {
            try
            {
                string BorrowingID = txt_Borrow.Text;
                string BookID = txt_BookID.Text;
                string Student_name = txt_StudentName.Text;
                string Andress = txt_Andress.Text;
                string Phone = txt_Phone.Text;
                string BorrowDate = date_Borro.Text.ToString();
                string ReturnDate = date_Return.Text.ToString();
                int error = 0;
                string query = "select * from Borrowing where BorrowingID = @BorrowingID";
                connection.Open();
                SqlCommand cmdcheck = new SqlCommand(query, connection);
                cmdcheck.Parameters.Add("@BorrowingID", SqlDbType.Int);
                cmdcheck.Parameters["@BorrowingID"].Value = BorrowingID;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    MessageBox.Show("This BorrowingID is existing, please choose another", "Warning", MessageBoxButtons.OKCancel);
                    ClearFields();
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    string insert = "insert into Borrowing values (@BorrowingID,@BookID,@Student_name,@Address,@Phone,@BorrowDate,@ReturnDate)";
                    SqlCommand cmd = new SqlCommand(insert, connection);
                    cmd.Parameters.Add("@BorrowingID", SqlDbType.Int);
                    cmd.Parameters["@BorrowingID"].Value = BorrowingID;
                    cmd.Parameters.Add("@BookID", SqlDbType.Int);
                    cmd.Parameters["@BookID"].Value = BookID;
                    cmd.Parameters.Add("@Student_name", SqlDbType.VarChar);
                    cmd.Parameters["@Student_name"].Value = Student_name;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar);
                    cmd.Parameters["@Address"].Value = Andress;
                    cmd.Parameters.Add("@Phone", SqlDbType.Int);
                    cmd.Parameters["@Phone"].Value = Phone;
                    cmd.Parameters.Add("@BorrowDate", SqlDbType.Date);
                    cmd.Parameters["@BorrowDate"].Value = BorrowDate;
                    cmd.Parameters.Add("@ReturnDate", SqlDbType.Date);
                    cmd.Parameters["@ReturnDate"].Value = ReturnDate;

                    cmd.ExecuteNonQuery();
                    LoadBorrowingData();
                    MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("The data entered is incorrect, please re-enter." + ex.Message, "Error", MessageBoxButtons.OK);
                ClearFields();
            }
        }

        private void ClearFields()
        {

            txt_Borrow.Clear();
            txt_BookID.Clear();
            txt_StudentName.Clear();
            txt_Andress.Clear();
            txt_Phone.Clear();

            date_Borro.Value = DateTime.Now;
            date_Return.Value = DateTime.Now;
            dgv_book_loan.ClearSelection();

        }

        private void Report_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BorrowingID, BookID, Student_name, Address, Phone, BorrowDate, ReturnDate FROM Borrowing";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                int totalBorrowedBooks = table.Rows.Count;
                int overdueBooks = 0;

                foreach (DataRow row in table.Rows)
                {
                    DateTime returnDate = Convert.ToDateTime(row["ReturnDate"]);
                    if (returnDate < DateTime.Now)
                    {
                        overdueBooks++;
                    }
                }

                MessageBox.Show($"Số sách đang được mượn: {totalBorrowedBooks}\nSố sách quá hạn mượn: {overdueBooks}");

                foreach (DataGridViewRow row in dgv_book_loan.Rows)
                {
                    DateTime returnDate = Convert.ToDateTime(row.Cells[6].Value);
                    if (returnDate < DateTime.Now)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void btn_Edit4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Borrowing SET BookID = @BookID, Student_name = @Student_name, Address = @Address, Phone = @Phone, BorrowDate = @BorrowDate, ReturnDate = @ReturnDate WHERE BorrowingID = @BorrowingID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BorrowingID", txt_Borrow.Text);
                command.Parameters.AddWithValue("@BookID", txt_BookID.Text);
                command.Parameters.AddWithValue("@Student_name", txt_StudentName.Text);
                command.Parameters.AddWithValue("@Address", txt_Andress.Text);
                command.Parameters.AddWithValue("@Phone", txt_Phone.Text);
                command.Parameters.AddWithValue("@BorrowDate", date_Borro.Value);
                command.Parameters.AddWithValue("@ReturnDate", date_Return.Value);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    LoadBorrowingData();
                    MessageBox.Show("Data has been updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_Del4_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM book WHERE BorrowingID = @BorrowingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BorrowingID", txt_Borrow.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadBorrowingData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgv_book_loan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_book_loan.Rows[e.RowIndex];

                txt_Borrow.Text = row.Cells[0].Value.ToString();
                txt_BookID.Text = row.Cells[1].Value.ToString();
                txt_StudentName.Text = row.Cells[2].Value.ToString();
                txt_Andress.Text = row.Cells[3].Value.ToString();
                txt_Phone.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Form_book_loan_Load(object sender, EventArgs e)
        {
            LoadBorrowingData();
        }

        private void btn_Logout4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Fmb = new LoginForm();
            Fmb.ShowDialog();
            this.Dispose();
        }

        private void btn_Exit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
