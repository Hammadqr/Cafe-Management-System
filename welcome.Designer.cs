using System.Windows.Forms;
using Guna.UI.WinForms;



namespace DB_Project

{
    partial class welcome : Form
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
            this.registerbtn = new Guna.UI.WinForms.GunaButton();
            this.loginbtn = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerbtn
            // 
            this.registerbtn.AnimationHoverSpeed = 0.07F;
            this.registerbtn.AnimationSpeed = 0.03F;
            this.registerbtn.BackColor = System.Drawing.Color.Transparent;
            this.registerbtn.BaseColor = System.Drawing.Color.Teal;
            this.registerbtn.BorderColor = System.Drawing.Color.Black;
            this.registerbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.registerbtn.FocusedColor = System.Drawing.Color.Empty;
            this.registerbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerbtn.ForeColor = System.Drawing.Color.White;
            this.registerbtn.Image = null;
            this.registerbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.registerbtn.Location = new System.Drawing.Point(139, 101);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.registerbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.registerbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.registerbtn.OnHoverImage = null;
            this.registerbtn.OnPressedColor = System.Drawing.Color.Black;
            this.registerbtn.Radius = 20;
            this.registerbtn.Size = new System.Drawing.Size(160, 42);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "REGISTER";
            this.registerbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.AnimationHoverSpeed = 0.07F;
            this.loginbtn.AnimationSpeed = 0.03F;
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.BaseColor = System.Drawing.Color.Teal;
            this.loginbtn.BorderColor = System.Drawing.Color.Black;
            this.loginbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginbtn.FocusedColor = System.Drawing.Color.Empty;
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Image = null;
            this.loginbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.loginbtn.Location = new System.Drawing.Point(139, 169);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.loginbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.loginbtn.OnHoverImage = null;
            this.loginbtn.OnPressedColor = System.Drawing.Color.Black;
            this.loginbtn.Radius = 20;
            this.loginbtn.Size = new System.Drawing.Size(160, 42);
            this.loginbtn.TabIndex = 1;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginbtn.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.registerbtn);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Location = new System.Drawing.Point(72, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 317);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO CAFE BITES";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(601, 403);
            this.Controls.Add(this.panel1);
            this.Name = "welcome";
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton registerbtn;
        private Guna.UI.WinForms.GunaButton loginbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}