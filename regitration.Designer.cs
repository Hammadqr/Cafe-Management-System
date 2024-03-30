namespace DB_Project
{
    partial class regitration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registration_textBox_username = new System.Windows.Forms.TextBox();
            this.registration_textBox_confirmPass = new System.Windows.Forms.TextBox();
            this.registration_textBox_password = new System.Windows.Forms.TextBox();
            this.registration_showpassword = new System.Windows.Forms.CheckBox();
            this.registration_registerBtn = new System.Windows.Forms.Button();
            this.registration_tologinBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(170, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registration";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "confirm password";
            // 
            // registration_textBox_username
            // 
            this.registration_textBox_username.Location = new System.Drawing.Point(208, 104);
            this.registration_textBox_username.Name = "registration_textBox_username";
            this.registration_textBox_username.Size = new System.Drawing.Size(100, 20);
            this.registration_textBox_username.TabIndex = 4;
            this.registration_textBox_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // registration_textBox_confirmPass
            // 
            this.registration_textBox_confirmPass.Location = new System.Drawing.Point(208, 183);
            this.registration_textBox_confirmPass.Name = "registration_textBox_confirmPass";
            this.registration_textBox_confirmPass.PasswordChar = '*';
            this.registration_textBox_confirmPass.Size = new System.Drawing.Size(100, 20);
            this.registration_textBox_confirmPass.TabIndex = 5;
            // 
            // registration_textBox_password
            // 
            this.registration_textBox_password.Location = new System.Drawing.Point(208, 135);
            this.registration_textBox_password.Name = "registration_textBox_password";
            this.registration_textBox_password.PasswordChar = '*';
            this.registration_textBox_password.Size = new System.Drawing.Size(100, 20);
            this.registration_textBox_password.TabIndex = 6;
            this.registration_textBox_password.TextChanged += new System.EventHandler(this.registration_textBox_password_TextChanged);
            // 
            // registration_showpassword
            // 
            this.registration_showpassword.AutoSize = true;
            this.registration_showpassword.Location = new System.Drawing.Point(208, 209);
            this.registration_showpassword.Name = "registration_showpassword";
            this.registration_showpassword.Size = new System.Drawing.Size(102, 17);
            this.registration_showpassword.TabIndex = 8;
            this.registration_showpassword.Text = "Show Password";
            this.registration_showpassword.UseVisualStyleBackColor = true;
            this.registration_showpassword.CheckedChanged += new System.EventHandler(this.registration_showpassword_CheckedChanged);
            // 
            // registration_registerBtn
            // 
            this.registration_registerBtn.Location = new System.Drawing.Point(233, 232);
            this.registration_registerBtn.Name = "registration_registerBtn";
            this.registration_registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registration_registerBtn.TabIndex = 9;
            this.registration_registerBtn.Text = "Register";
            this.registration_registerBtn.UseVisualStyleBackColor = true;
            this.registration_registerBtn.Click += new System.EventHandler(this.registration_registerBtn_Click);
            // 
            // registration_tologinBtn
            // 
            this.registration_tologinBtn.Location = new System.Drawing.Point(187, 293);
            this.registration_tologinBtn.Name = "registration_tologinBtn";
            this.registration_tologinBtn.Size = new System.Drawing.Size(131, 23);
            this.registration_tologinBtn.TabIndex = 10;
            this.registration_tologinBtn.Text = "Back to LOGIN";
            this.registration_tologinBtn.UseVisualStyleBackColor = true;
            this.registration_tologinBtn.Click += new System.EventHandler(this.registration_tologinBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Already have an account";
            // 
            // regitration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(483, 396);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registration_tologinBtn);
            this.Controls.Add(this.registration_registerBtn);
            this.Controls.Add(this.registration_showpassword);
            this.Controls.Add(this.registration_textBox_password);
            this.Controls.Add(this.registration_textBox_confirmPass);
            this.Controls.Add(this.registration_textBox_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "regitration";
            this.Load += new System.EventHandler(this.regitration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox registration_textBox_username;
        private System.Windows.Forms.TextBox registration_textBox_confirmPass;
        private System.Windows.Forms.TextBox registration_textBox_password;
        private System.Windows.Forms.CheckBox registration_showpassword;
        private System.Windows.Forms.Button registration_registerBtn;
        private System.Windows.Forms.Button registration_tologinBtn;
        private System.Windows.Forms.Label label5;
    }
}