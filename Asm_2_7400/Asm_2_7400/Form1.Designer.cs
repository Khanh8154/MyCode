namespace Asm_2_7400
{
    partial class LoginForm
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
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.btnLogin1 = new System.Windows.Forms.Button();
            this.Password1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbPassword.Location = new System.Drawing.Point(315, 193);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '#';
            this.txbPassword.Size = new System.Drawing.Size(266, 37);
            this.txbPassword.TabIndex = 29;
            this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbUserName.Location = new System.Drawing.Point(315, 131);
            this.txbUserName.Multiline = true;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(266, 37);
            this.txbUserName.TabIndex = 28;
            this.txbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(497, 288);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(84, 32);
            this.btnExit1.TabIndex = 27;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // btnLogin1
            // 
            this.btnLogin1.Location = new System.Drawing.Point(315, 288);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(84, 32);
            this.btnLogin1.TabIndex = 26;
            this.btnLogin1.Text = "Login";
            this.btnLogin1.UseVisualStyleBackColor = true;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // Password1
            // 
            this.Password1.AutoSize = true;
            this.Password1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password1.Location = new System.Drawing.Point(219, 204);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(69, 17);
            this.Password1.TabIndex = 25;
            this.Password1.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserName.Location = new System.Drawing.Point(219, 141);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(79, 17);
            this.UserName.TabIndex = 24;
            this.UserName.Text = "User Name";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.UserName);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.Button btnLogin1;
        private System.Windows.Forms.Label Password1;
        private System.Windows.Forms.Label UserName;
    }
}

