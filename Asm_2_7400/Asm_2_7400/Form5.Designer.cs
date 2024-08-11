namespace Asm_2_7400
{
    partial class Form_manage_staff
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
            this.btn_Edit4 = new System.Windows.Forms.Button();
            this.btn_Exit4 = new System.Windows.Forms.Button();
            this.btn_Logout4 = new System.Windows.Forms.Button();
            this.dgv_manage_staff = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_StaffID = new System.Windows.Forms.TextBox();
            this.txt_Staf_name = new System.Windows.Forms.TextBox();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manage_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(296, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Manage Staff";
            // 
            // btn_Edit4
            // 
            this.btn_Edit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Edit4.Location = new System.Drawing.Point(12, 317);
            this.btn_Edit4.Name = "btn_Edit4";
            this.btn_Edit4.Size = new System.Drawing.Size(75, 43);
            this.btn_Edit4.TabIndex = 21;
            this.btn_Edit4.Text = "Edit";
            this.btn_Edit4.UseVisualStyleBackColor = true;
            this.btn_Edit4.Click += new System.EventHandler(this.btn_Edit4_Click);
            // 
            // btn_Exit4
            // 
            this.btn_Exit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Exit4.Location = new System.Drawing.Point(563, 54);
            this.btn_Exit4.Name = "btn_Exit4";
            this.btn_Exit4.Size = new System.Drawing.Size(75, 37);
            this.btn_Exit4.TabIndex = 19;
            this.btn_Exit4.Text = "Exit";
            this.btn_Exit4.UseVisualStyleBackColor = true;
            this.btn_Exit4.Click += new System.EventHandler(this.btn_Exit4_Click);
            // 
            // btn_Logout4
            // 
            this.btn_Logout4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Logout4.Location = new System.Drawing.Point(563, 11);
            this.btn_Logout4.Name = "btn_Logout4";
            this.btn_Logout4.Size = new System.Drawing.Size(75, 37);
            this.btn_Logout4.TabIndex = 18;
            this.btn_Logout4.Text = "Logout";
            this.btn_Logout4.UseVisualStyleBackColor = true;
            this.btn_Logout4.Click += new System.EventHandler(this.btn_Logout4_Click);
            // 
            // dgv_manage_staff
            // 
            this.dgv_manage_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manage_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_manage_staff.Location = new System.Drawing.Point(95, 219);
            this.dgv_manage_staff.Name = "dgv_manage_staff";
            this.dgv_manage_staff.Size = new System.Drawing.Size(546, 279);
            this.dgv_manage_staff.TabIndex = 17;
            this.dgv_manage_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manage_staff_CellClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_cancel.Location = new System.Drawing.Point(14, 366);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 43);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_StaffID
            // 
            this.txt_StaffID.Location = new System.Drawing.Point(113, 54);
            this.txt_StaffID.Name = "txt_StaffID";
            this.txt_StaffID.Size = new System.Drawing.Size(100, 20);
            this.txt_StaffID.TabIndex = 35;
            // 
            // txt_Staf_name
            // 
            this.txt_Staf_name.Location = new System.Drawing.Point(113, 80);
            this.txt_Staf_name.Name = "txt_Staf_name";
            this.txt_Staf_name.Size = new System.Drawing.Size(230, 20);
            this.txt_Staf_name.TabIndex = 36;
            // 
            // txt_Position
            // 
            this.txt_Position.Location = new System.Drawing.Point(113, 106);
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.Size = new System.Drawing.Size(230, 20);
            this.txt_Position.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Staff Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Staff position";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserID";
            this.Column1.HeaderText = "Staff ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Staff Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Position";
            this.Column3.HeaderText = "Position";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LastLogin";
            this.Column4.HeaderText = "Last Login";
            this.Column4.Name = "Column4";
            // 
            // Form_manage_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Position);
            this.Controls.Add(this.txt_Staf_name);
            this.Controls.Add(this.txt_StaffID);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Edit4);
            this.Controls.Add(this.btn_Exit4);
            this.Controls.Add(this.btn_Logout4);
            this.Controls.Add(this.dgv_manage_staff);
            this.Name = "Form_manage_staff";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form_manage_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manage_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Edit4;
        private System.Windows.Forms.Button btn_Exit4;
        private System.Windows.Forms.Button btn_Logout4;
        private System.Windows.Forms.DataGridView dgv_manage_staff;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_StaffID;
        private System.Windows.Forms.TextBox txt_Staf_name;
        private System.Windows.Forms.TextBox txt_Position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}