namespace DB_Project
{
    partial class Form1
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
            this.login_welcome_txt = new System.Windows.Forms.Label();
            this.login_checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_textBox_username = new System.Windows.Forms.TextBox();
            this.login_textBox_password = new System.Windows.Forms.TextBox();
            this.login_registerBtn = new System.Windows.Forms.Button();
            this.login_loginBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // login_welcome_txt
            // 
            this.login_welcome_txt.AutoSize = true;
            this.login_welcome_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.login_welcome_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_welcome_txt.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_welcome_txt.ForeColor = System.Drawing.Color.Olive;
            this.login_welcome_txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login_welcome_txt.Location = new System.Drawing.Point(125, 49);
            this.login_welcome_txt.Name = "login_welcome_txt";
            this.login_welcome_txt.Padding = new System.Windows.Forms.Padding(5);
            this.login_welcome_txt.Size = new System.Drawing.Size(266, 33);
            this.login_welcome_txt.TabIndex = 0;
            this.login_welcome_txt.Text = "Welcome To Cafe Bites";
            // 
            // login_checkBox1
            // 
            this.login_checkBox1.AutoSize = true;
            this.login_checkBox1.BackColor = System.Drawing.Color.Olive;
            this.login_checkBox1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.login_checkBox1.Location = new System.Drawing.Point(150, 218);
            this.login_checkBox1.Name = "login_checkBox1";
            this.login_checkBox1.Size = new System.Drawing.Size(133, 22);
            this.login_checkBox1.TabIndex = 1;
            this.login_checkBox1.Text = "Show Password";
            this.login_checkBox1.UseVisualStyleBackColor = false;
            this.login_checkBox1.CheckedChanged += new System.EventHandler(this.login_checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(122, 104);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(122, 158);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // login_textBox_username
            // 
            this.login_textBox_username.Location = new System.Drawing.Point(125, 126);
            this.login_textBox_username.Name = "login_textBox_username";
            this.login_textBox_username.Size = new System.Drawing.Size(158, 20);
            this.login_textBox_username.TabIndex = 5;
            this.login_textBox_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // login_textBox_password
            // 
            this.login_textBox_password.Location = new System.Drawing.Point(125, 183);
            this.login_textBox_password.Name = "login_textBox_password";
            this.login_textBox_password.PasswordChar = '*';
            this.login_textBox_password.Size = new System.Drawing.Size(158, 20);
            this.login_textBox_password.TabIndex = 6;
            this.login_textBox_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login_registerBtn
            // 
            this.login_registerBtn.BackColor = System.Drawing.Color.Olive;
            this.login_registerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.login_registerBtn.Location = new System.Drawing.Point(177, 291);
            this.login_registerBtn.Name = "login_registerBtn";
            this.login_registerBtn.Size = new System.Drawing.Size(75, 23);
            this.login_registerBtn.TabIndex = 7;
            this.login_registerBtn.Text = "Register";
            this.login_registerBtn.UseVisualStyleBackColor = false;
            this.login_registerBtn.Click += new System.EventHandler(this.login_registerBtn_Click);
            // 
            // login_loginBtn
            // 
            this.login_loginBtn.Location = new System.Drawing.Point(179, 264);
            this.login_loginBtn.Name = "login_loginBtn";
            this.login_loginBtn.Size = new System.Drawing.Size(75, 21);
            this.login_loginBtn.TabIndex = 8;
            this.login_loginBtn.Text = "LOGIN";
            this.login_loginBtn.UseVisualStyleBackColor = true;
            this.login_loginBtn.Click += new System.EventHandler(this.login_loginBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(481, 353);
            this.Controls.Add(this.login_loginBtn);
            this.Controls.Add(this.login_registerBtn);
            this.Controls.Add(this.login_textBox_password);
            this.Controls.Add(this.login_textBox_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_checkBox1);
            this.Controls.Add(this.login_welcome_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_welcome_txt;
        private System.Windows.Forms.CheckBox login_checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_textBox_username;
        private System.Windows.Forms.TextBox login_textBox_password;
        private System.Windows.Forms.Button login_registerBtn;
        private System.Windows.Forms.Button login_loginBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

