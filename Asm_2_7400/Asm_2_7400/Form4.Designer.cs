namespace Asm_2_7400
{
    partial class Form_book_loan
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
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Del4 = new System.Windows.Forms.Button();
            this.btn_Edit4 = new System.Windows.Forms.Button();
            this.btn_Add4 = new System.Windows.Forms.Button();
            this.btn_Exit4 = new System.Windows.Forms.Button();
            this.btn_Logout4 = new System.Windows.Forms.Button();
            this.dgv_book_loan = new System.Windows.Forms.DataGridView();
            this.Report = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_Borrow = new System.Windows.Forms.TextBox();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.date_Borro = new System.Windows.Forms.DateTimePicker();
            this.date_Return = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Andress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_loan)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(332, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Manage books for loan";
            // 
            // btn_Del4
            // 
            this.btn_Del4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Del4.Location = new System.Drawing.Point(14, 362);
            this.btn_Del4.Name = "btn_Del4";
            this.btn_Del4.Size = new System.Drawing.Size(75, 43);
            this.btn_Del4.TabIndex = 13;
            this.btn_Del4.Text = "Delete";
            this.btn_Del4.UseVisualStyleBackColor = true;
            this.btn_Del4.Click += new System.EventHandler(this.btn_Del4_Click);
            // 
            // btn_Edit4
            // 
            this.btn_Edit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Edit4.Location = new System.Drawing.Point(14, 313);
            this.btn_Edit4.Name = "btn_Edit4";
            this.btn_Edit4.Size = new System.Drawing.Size(75, 43);
            this.btn_Edit4.TabIndex = 12;
            this.btn_Edit4.Text = "Edit";
            this.btn_Edit4.UseVisualStyleBackColor = true;
            this.btn_Edit4.Click += new System.EventHandler(this.btn_Edit4_Click);
            // 
            // btn_Add4
            // 
            this.btn_Add4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Add4.Location = new System.Drawing.Point(14, 264);
            this.btn_Add4.Name = "btn_Add4";
            this.btn_Add4.Size = new System.Drawing.Size(75, 43);
            this.btn_Add4.TabIndex = 11;
            this.btn_Add4.Text = "Add";
            this.btn_Add4.UseVisualStyleBackColor = true;
            this.btn_Add4.Click += new System.EventHandler(this.btn_Add4_Click);
            // 
            // btn_Exit4
            // 
            this.btn_Exit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Exit4.Location = new System.Drawing.Point(731, 55);
            this.btn_Exit4.Name = "btn_Exit4";
            this.btn_Exit4.Size = new System.Drawing.Size(75, 37);
            this.btn_Exit4.TabIndex = 10;
            this.btn_Exit4.Text = "Exit";
            this.btn_Exit4.UseVisualStyleBackColor = true;
            this.btn_Exit4.Click += new System.EventHandler(this.btn_Exit4_Click);
            // 
            // btn_Logout4
            // 
            this.btn_Logout4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Logout4.Location = new System.Drawing.Point(731, 12);
            this.btn_Logout4.Name = "btn_Logout4";
            this.btn_Logout4.Size = new System.Drawing.Size(75, 37);
            this.btn_Logout4.TabIndex = 9;
            this.btn_Logout4.Text = "Logout";
            this.btn_Logout4.UseVisualStyleBackColor = true;
            this.btn_Logout4.Click += new System.EventHandler(this.btn_Logout4_Click);
            // 
            // dgv_book_loan
            // 
            this.dgv_book_loan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_book_loan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column8,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dgv_book_loan.Location = new System.Drawing.Point(95, 249);
            this.dgv_book_loan.Name = "dgv_book_loan";
            this.dgv_book_loan.Size = new System.Drawing.Size(711, 250);
            this.dgv_book_loan.TabIndex = 8;
            this.dgv_book_loan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_book_loan_CellClick);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(14, 460);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(75, 39);
            this.Report.TabIndex = 16;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_cancel.Location = new System.Drawing.Point(14, 411);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 43);
            this.btn_cancel.TabIndex = 33;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_Borrow
            // 
            this.txt_Borrow.Location = new System.Drawing.Point(101, 55);
            this.txt_Borrow.Name = "txt_Borrow";
            this.txt_Borrow.Size = new System.Drawing.Size(100, 20);
            this.txt_Borrow.TabIndex = 34;
            // 
            // txt_BookID
            // 
            this.txt_BookID.Location = new System.Drawing.Point(101, 81);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.Size = new System.Drawing.Size(100, 20);
            this.txt_BookID.TabIndex = 35;
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(101, 107);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(185, 20);
            this.txt_StudentName.TabIndex = 36;
            // 
            // date_Borro
            // 
            this.date_Borro.Location = new System.Drawing.Point(410, 104);
            this.date_Borro.Name = "date_Borro";
            this.date_Borro.Size = new System.Drawing.Size(200, 20);
            this.date_Borro.TabIndex = 38;
            // 
            // date_Return
            // 
            this.date_Return.Location = new System.Drawing.Point(410, 130);
            this.date_Return.Name = "date_Return";
            this.date_Return.Size = new System.Drawing.Size(200, 20);
            this.date_Return.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Borrowing ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Book ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Student Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Borrơ Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Return Date";
            // 
            // txt_Andress
            // 
            this.txt_Andress.Location = new System.Drawing.Point(101, 133);
            this.txt_Andress.Name = "txt_Andress";
            this.txt_Andress.Size = new System.Drawing.Size(185, 20);
            this.txt_Andress.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Andress";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(410, 78);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(100, 20);
            this.txt_Phone.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Phone";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BorrowingID";
            this.Column1.HeaderText = "Borrowing ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BookID";
            this.Column2.HeaderText = "Book ID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Student_name";
            this.Column7.HeaderText = "Student Name";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Address";
            this.Column8.HeaderText = "Andress";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Phone";
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BorrowDate";
            this.Column5.HeaderText = "Borrow Date";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ReturnDate";
            this.Column6.HeaderText = "Return Date";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Form_book_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 511);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Andress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_Return);
            this.Controls.Add(this.date_Borro);
            this.Controls.Add(this.txt_StudentName);
            this.Controls.Add(this.txt_BookID);
            this.Controls.Add(this.txt_Borrow);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Del4);
            this.Controls.Add(this.btn_Edit4);
            this.Controls.Add(this.btn_Add4);
            this.Controls.Add(this.btn_Exit4);
            this.Controls.Add(this.btn_Logout4);
            this.Controls.Add(this.dgv_book_loan);
            this.Name = "Form_book_loan";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form_book_loan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_loan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Del4;
        private System.Windows.Forms.Button btn_Edit4;
        private System.Windows.Forms.Button btn_Add4;
        private System.Windows.Forms.Button btn_Exit4;
        private System.Windows.Forms.Button btn_Logout4;
        private System.Windows.Forms.DataGridView dgv_book_loan;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_Borrow;
        private System.Windows.Forms.TextBox txt_BookID;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.DateTimePicker date_Borro;
        private System.Windows.Forms.DateTimePicker date_Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Andress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}