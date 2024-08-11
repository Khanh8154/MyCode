namespace Asm_2_7400
{
    partial class Form_Select
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Manage_Book = new System.Windows.Forms.Button();
            this.btn_Book_on_loan = new System.Windows.Forms.Button();
            this.btn_Staff_management = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.lb_userID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Manage_Book
            // 
            this.btn_Manage_Book.Location = new System.Drawing.Point(39, 110);
            this.btn_Manage_Book.Name = "btn_Manage_Book";
            this.btn_Manage_Book.Size = new System.Drawing.Size(124, 66);
            this.btn_Manage_Book.TabIndex = 0;
            this.btn_Manage_Book.Text = "Manage books in the library";
            this.btn_Manage_Book.UseVisualStyleBackColor = true;
            this.btn_Manage_Book.Click += new System.EventHandler(this.btn_Manage_Book_Click);
            // 
            // btn_Book_on_loan
            // 
            this.btn_Book_on_loan.Location = new System.Drawing.Point(224, 110);
            this.btn_Book_on_loan.Name = "btn_Book_on_loan";
            this.btn_Book_on_loan.Size = new System.Drawing.Size(124, 66);
            this.btn_Book_on_loan.TabIndex = 1;
            this.btn_Book_on_loan.Text = "Manage books on loan";
            this.btn_Book_on_loan.UseVisualStyleBackColor = true;
            this.btn_Book_on_loan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Staff_management
            // 
            this.btn_Staff_management.Location = new System.Drawing.Point(129, 218);
            this.btn_Staff_management.Name = "btn_Staff_management";
            this.btn_Staff_management.Size = new System.Drawing.Size(124, 66);
            this.btn_Staff_management.TabIndex = 2;
            this.btn_Staff_management.Text = "Staff management";
            this.btn_Staff_management.UseVisualStyleBackColor = true;
            this.btn_Staff_management.Click += new System.EventHandler(this.btn_Staff_management_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(78, 318);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(85, 38);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(224, 318);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(85, 38);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUser.Location = new System.Drawing.Point(12, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(43, 20);
            this.lbUser.TabIndex = 7;
            this.lbUser.Text = "User";
            // 
            // lb_userID
            // 
            this.lb_userID.AutoSize = true;
            this.lb_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_userID.Location = new System.Drawing.Point(266, 9);
            this.lb_userID.Name = "lb_userID";
            this.lb_userID.Size = new System.Drawing.Size(60, 20);
            this.lb_userID.TabIndex = 8;
            this.lb_userID.Text = "UserID";
            // 
            // Form_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 370);
            this.Controls.Add(this.lb_userID);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Staff_management);
            this.Controls.Add(this.btn_Book_on_loan);
            this.Controls.Add(this.btn_Manage_Book);
            this.Name = "Form_Select";
            this.Text = "Select page";
            this.Load += new System.EventHandler(this.Form_Select_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Manage_Book;
        private System.Windows.Forms.Button btn_Book_on_loan;
        private System.Windows.Forms.Button btn_Staff_management;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lb_userID;
    }
}