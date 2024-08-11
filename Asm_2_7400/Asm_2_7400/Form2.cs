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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Asm_2_7400.LoginForm;

namespace Asm_2_7400
{
    public partial class Form_Select : Form
    {

        SqlConnection connection;
        public Form_Select()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=DESKTOP-4EAN90E\\SQLEXPRESS; Database=Asm2_7400; Integrated Security=True;");
            lb_userID.Text = "UserID : " + UserSession.UserID.ToString();
            lbUser.Text = "User : " + UserSession.UserName;
            if (UserSession.UserID != 1 & UserSession.UserID != 2)
            {
                btn_Staff_management.Enabled = false;
            }    

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_book_loan Fbl = new Form_book_loan();
            Fbl.ShowDialog();
            this.Dispose();
        }

        private void btn_Manage_Book_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Manage_book Fmb = new Form_Manage_book();
            Fmb.ShowDialog();
            this.Dispose();
        }

        private void btn_Staff_management_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_manage_staff Fmb = new Form_manage_staff();
            Fmb.ShowDialog();
            this.Dispose();
        }

        private void btn_Students_Borrowing_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_book_loan Fmb = new Form_book_loan();
            Fmb.ShowDialog();
            this.Dispose();
        }

        private void Form_Select_Load(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Fmb = new LoginForm();
            Fmb.ShowDialog();
            this.Dispose();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
