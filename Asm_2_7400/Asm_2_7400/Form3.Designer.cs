namespace Asm_2_7400
{
    partial class Form_Manage_book
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
            this.dgv_manage_book = new System.Windows.Forms.DataGridView();
            this.btn_Logout3 = new System.Windows.Forms.Button();
            this.btn_Exit3 = new System.Windows.Forms.Button();
            this.btn_Add3 = new System.Windows.Forms.Button();
            this.btn_Edit3 = new System.Windows.Forms.Button();
            this.btn_Del3 = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.Button();
            this.cb_Catgory = new System.Windows.Forms.ComboBox();
            this.txt_Book_ID = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_YearPublished = new System.Windows.Forms.TextBox();
            this.Col_BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Catgory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Year_Pub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Pub_er = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manage_book)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_manage_book
            // 
            this.dgv_manage_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manage_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_BookID,
            this.Col_Title,
            this.Col_Author,
            this.Col_Catgory,
            this.Col_Year_Pub,
            this.Col_Pub_er,
            this.Col_Quantity});
            this.dgv_manage_book.Location = new System.Drawing.Point(105, 246);
            this.dgv_manage_book.Name = "dgv_manage_book";
            this.dgv_manage_book.Size = new System.Drawing.Size(730, 244);
            this.dgv_manage_book.TabIndex = 0;
            this.dgv_manage_book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manage_book_CellClick);
            // 
            // btn_Logout3
            // 
            this.btn_Logout3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Logout3.Location = new System.Drawing.Point(758, 12);
            this.btn_Logout3.Name = "btn_Logout3";
            this.btn_Logout3.Size = new System.Drawing.Size(75, 37);
            this.btn_Logout3.TabIndex = 1;
            this.btn_Logout3.Text = "Logout";
            this.btn_Logout3.UseVisualStyleBackColor = true;
            this.btn_Logout3.Click += new System.EventHandler(this.btn_Logout3_Click);
            // 
            // btn_Exit3
            // 
            this.btn_Exit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Exit3.Location = new System.Drawing.Point(758, 55);
            this.btn_Exit3.Name = "btn_Exit3";
            this.btn_Exit3.Size = new System.Drawing.Size(75, 37);
            this.btn_Exit3.TabIndex = 2;
            this.btn_Exit3.Text = "Exit";
            this.btn_Exit3.UseVisualStyleBackColor = true;
            this.btn_Exit3.Click += new System.EventHandler(this.btn_Exit3_Click);
            // 
            // btn_Add3
            // 
            this.btn_Add3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Add3.Location = new System.Drawing.Point(12, 246);
            this.btn_Add3.Name = "btn_Add3";
            this.btn_Add3.Size = new System.Drawing.Size(75, 43);
            this.btn_Add3.TabIndex = 3;
            this.btn_Add3.Text = "Add";
            this.btn_Add3.UseVisualStyleBackColor = true;
            this.btn_Add3.Click += new System.EventHandler(this.btn_Add3_Click);
            // 
            // btn_Edit3
            // 
            this.btn_Edit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Edit3.Location = new System.Drawing.Point(14, 295);
            this.btn_Edit3.Name = "btn_Edit3";
            this.btn_Edit3.Size = new System.Drawing.Size(75, 43);
            this.btn_Edit3.TabIndex = 4;
            this.btn_Edit3.Text = "Edit";
            this.btn_Edit3.UseVisualStyleBackColor = true;
            this.btn_Edit3.Click += new System.EventHandler(this.btn_Edit3_Click);
            // 
            // btn_Del3
            // 
            this.btn_Del3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Del3.Location = new System.Drawing.Point(14, 344);
            this.btn_Del3.Name = "btn_Del3";
            this.btn_Del3.Size = new System.Drawing.Size(75, 43);
            this.btn_Del3.TabIndex = 5;
            this.btn_Del3.Text = "Delete";
            this.btn_Del3.UseVisualStyleBackColor = true;
            this.btn_Del3.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUser.Location = new System.Drawing.Point(8, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(43, 20);
            this.lbUser.TabIndex = 6;
            this.lbUser.Text = "User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(377, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Manage books";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(12, 442);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(75, 39);
            this.Report.TabIndex = 17;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // cb_Catgory
            // 
            this.cb_Catgory.FormattingEnabled = true;
            this.cb_Catgory.Location = new System.Drawing.Point(61, 173);
            this.cb_Catgory.Name = "cb_Catgory";
            this.cb_Catgory.Size = new System.Drawing.Size(193, 21);
            this.cb_Catgory.TabIndex = 19;
            // 
            // txt_Book_ID
            // 
            this.txt_Book_ID.Location = new System.Drawing.Point(61, 56);
            this.txt_Book_ID.Name = "txt_Book_ID";
            this.txt_Book_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_Book_ID.TabIndex = 20;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(61, 91);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(193, 20);
            this.txt_Title.TabIndex = 21;
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(61, 135);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(193, 20);
            this.txt_Author.TabIndex = 22;
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Location = new System.Drawing.Point(383, 89);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(216, 20);
            this.txt_Publisher.TabIndex = 23;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(383, 134);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_Quantity.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Year Published";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Publisher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Quantity";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_cancel.Location = new System.Drawing.Point(12, 393);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 43);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_YearPublished
            // 
            this.txt_YearPublished.Location = new System.Drawing.Point(383, 52);
            this.txt_YearPublished.Name = "txt_YearPublished";
            this.txt_YearPublished.Size = new System.Drawing.Size(119, 20);
            this.txt_YearPublished.TabIndex = 33;
            // 
            // Col_BookID
            // 
            this.Col_BookID.DataPropertyName = "BookID";
            this.Col_BookID.HeaderText = "Book ID";
            this.Col_BookID.Name = "Col_BookID";
            this.Col_BookID.Width = 60;
            // 
            // Col_Title
            // 
            this.Col_Title.DataPropertyName = "Title";
            this.Col_Title.HeaderText = "Title";
            this.Col_Title.Name = "Col_Title";
            this.Col_Title.Width = 120;
            // 
            // Col_Author
            // 
            this.Col_Author.DataPropertyName = "Author";
            this.Col_Author.HeaderText = "Author";
            this.Col_Author.Name = "Col_Author";
            this.Col_Author.Width = 150;
            // 
            // Col_Catgory
            // 
            this.Col_Catgory.DataPropertyName = "CategoryName";
            this.Col_Catgory.HeaderText = "Category";
            this.Col_Catgory.Name = "Col_Catgory";
            this.Col_Catgory.Width = 120;
            // 
            // Col_Year_Pub
            // 
            this.Col_Year_Pub.DataPropertyName = "YearPublished";
            this.Col_Year_Pub.HeaderText = "Year Published";
            this.Col_Year_Pub.Name = "Col_Year_Pub";
            this.Col_Year_Pub.Width = 60;
            // 
            // Col_Pub_er
            // 
            this.Col_Pub_er.DataPropertyName = "Publisher";
            this.Col_Pub_er.HeaderText = "Publisher";
            this.Col_Pub_er.Name = "Col_Pub_er";
            this.Col_Pub_er.Width = 120;
            // 
            // Col_Quantity
            // 
            this.Col_Quantity.DataPropertyName = "quantity";
            this.Col_Quantity.HeaderText = "Quantity";
            this.Col_Quantity.Name = "Col_Quantity";
            this.Col_Quantity.Width = 60;
            // 
            // Form_Manage_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 493);
            this.Controls.Add(this.txt_YearPublished);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.txt_Book_ID);
            this.Controls.Add(this.cb_Catgory);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btn_Del3);
            this.Controls.Add(this.btn_Edit3);
            this.Controls.Add(this.btn_Add3);
            this.Controls.Add(this.btn_Exit3);
            this.Controls.Add(this.btn_Logout3);
            this.Controls.Add(this.dgv_manage_book);
            this.Name = "Form_Manage_book";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form_Manage_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manage_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_manage_book;
        private System.Windows.Forms.Button btn_Logout3;
        private System.Windows.Forms.Button btn_Exit3;
        private System.Windows.Forms.Button btn_Add3;
        private System.Windows.Forms.Button btn_Edit3;
        private System.Windows.Forms.Button btn_Del3;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.ComboBox cb_Catgory;
        private System.Windows.Forms.TextBox txt_Book_ID;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_YearPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Catgory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Year_Pub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Pub_er;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Quantity;
    }
}