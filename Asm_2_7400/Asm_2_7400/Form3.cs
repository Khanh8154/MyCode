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
using System.Xml.Linq;

namespace Asm_2_7400
{
    public partial class Form_Manage_book : Form
    {
        SqlConnection connection;
        public Form_Manage_book()
        {
            InitializeComponent();
            this.btn_Add3.Click += new System.EventHandler(this.btn_Add3_Click);
            this.btn_Edit3.Click += new System.EventHandler(this.btn_Edit3_Click);
            this.btn_Del3.Click += new System.EventHandler(this.btn_Del_Click);
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);

            connection = new SqlConnection("Server=DESKTOP-4EAN90E\\SQLEXPRESS; Database=Asm2_7400; Integrated Security=True;");
        }
        private void LoadData()
        {
            string query = "SELECT b.BookID, b.Title, b.Author, c.CategoryName, b.YearPublished, b.Publisher, b.Quantity " +
                           "FROM book b JOIN category c ON b.CategoryID = c.CategoryID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_manage_book.DataSource = table;
        }

        private void LoadCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM category";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cb_Catgory.DataSource = table;
            cb_Catgory.DisplayMember = "CategoryName";
            cb_Catgory.ValueMember = "CategoryID";
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM book WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", txt_Book_ID.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add3_Click(object sender, EventArgs e)
        {
            try
            {
                string BookID = txt_Book_ID.Text;
                string Title = txt_Title.Text;
                string Author = txt_Author.Text;
                string category = cb_Catgory.SelectedValue.ToString();
                string yearPublished = txt_YearPublished.Text.ToString();
                string publisher = txt_Publisher.Text.ToString();
                string quantity = txt_Quantity.Text.ToString();
                int error = 0;
                string query = "select * from Book where BookID = @BookID";
                connection.Open();
                SqlCommand cmdcheck = new SqlCommand(query, connection);
                cmdcheck.Parameters.Add("@BookID", SqlDbType.Int);
                cmdcheck.Parameters["@BookID"].Value = BookID;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    MessageBox.Show("This BookID is existing, please choose another", "Warning", MessageBoxButtons.OKCancel);
                    ClearFields();
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    string insert = "insert into Book values (@BookID,@CategoryID,@Title,@Author,@YearPublished,@Publisher,@Quantity)";
                    SqlCommand cmd = new SqlCommand(insert, connection);
                    cmd.Parameters.Add("@BookID", SqlDbType.Int);
                    cmd.Parameters["@BookID"].Value = BookID;
                    cmd.Parameters.Add("@CategoryID", SqlDbType.Int);
                    cmd.Parameters["@CategoryID"].Value = category;
                    cmd.Parameters.Add("@Title", SqlDbType.VarChar);
                    cmd.Parameters["@Title"].Value = Title;
                    cmd.Parameters.Add("@Author", SqlDbType.VarChar);
                    cmd.Parameters["@Author"].Value = Author;
                    cmd.Parameters.Add("@YearPublished", SqlDbType.Int);
                    cmd.Parameters["@YearPublished"].Value = yearPublished;
                    cmd.Parameters.Add("@Publisher", SqlDbType.VarChar);
                    cmd.Parameters["@Publisher"].Value = publisher;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                    cmd.Parameters["@Quantity"].Value = quantity;

                    cmd.ExecuteNonQuery();
                    LoadData();
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

        private void btn_Edit3_Click(object sender, EventArgs e)
        {
            string query = "UPDATE book SET Title = @Title, Author = @Author, CategoryID = @CategoryID, " +
                   "YearPublished = @YearPublished, Publisher = @Publisher, Quantity = @Quantity " +
                   "WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", txt_Book_ID.Text);
            command.Parameters.AddWithValue("@Title", txt_Title.Text);
            command.Parameters.AddWithValue("@Author", txt_Author.Text);
            command.Parameters.AddWithValue("@CategoryID", cb_Catgory.SelectedValue);
            command.Parameters.AddWithValue("@YearPublished", txt_YearPublished.Text);
            command.Parameters.AddWithValue("@Publisher", txt_Publisher.Text);
            command.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        private void ClearFields()
        {
            txt_Book_ID.Clear();
            txt_Title.Clear();
            txt_Author.Clear();
            cb_Catgory.SelectedIndex = -1;
            txt_YearPublished.Clear();
            txt_Publisher.Clear();
            txt_Quantity.Clear();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Form_Manage_book_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCategories();
        }

        private void dgv_manage_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_manage_book.Rows[e.RowIndex];

                txt_Book_ID.Text = row.Cells[0].Value.ToString();
                txt_Title.Text = row.Cells[1].Value.ToString();
                txt_Author.Text = row.Cells[2].Value.ToString();
                txt_YearPublished.Text = row.Cells[4].Value.ToString();
                txt_Publisher.Text = row.Cells[5].Value.ToString();
                txt_Quantity.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btn_Logout3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Fmb = new LoginForm();
            Fmb.ShowDialog();
            this.Dispose();
        }

        private void btn_Exit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            int totalQuantity = 0;

            foreach (DataGridViewRow row in dgv_manage_book.Rows)
            {
                if (row.Cells[6].Value != null)
                {
                    totalQuantity += Convert.ToInt32(row.Cells[6].Value);
                }
            }

            MessageBox.Show("Total Quantity: " + totalQuantity.ToString());

        }
    }
}
