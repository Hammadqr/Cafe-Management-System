using System.Windows.Forms;
using Guna.UI.WinForms;


namespace DB_Project
{
    partial class menu : Form
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
            
            this.components = new System.ComponentModel.Container();
            Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
            this.dataSet1 = new DB_Project.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menu_addtocart = new Guna.UI.WinForms.GunaButton();
            this.menu_total = new Guna.UI.WinForms.GunaTextBox();
            this.menu_gunaNumeric1 = new Guna.UI.WinForms.GunaNumeric();
            this.menu_gotocart = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menu_price = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menu_listBox1 = new System.Windows.Forms.ListBox();
            this.menu_search = new Guna.UI.WinForms.GunaTextBox();
            this.menu_itemName = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menu_gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.menu_label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            gunaGradient2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // menu_addtocart
            // 
            this.menu_addtocart.Animated = true;
            this.menu_addtocart.AnimationHoverSpeed = 0.07F;
            this.menu_addtocart.AnimationSpeed = 0.03F;
            this.menu_addtocart.BackColor = System.Drawing.Color.Transparent;
            this.menu_addtocart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menu_addtocart.BorderColor = System.Drawing.Color.Black;
            this.menu_addtocart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menu_addtocart.FocusedColor = System.Drawing.Color.Empty;
            this.menu_addtocart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_addtocart.ForeColor = System.Drawing.Color.White;
            this.menu_addtocart.Image = null;
            this.menu_addtocart.ImageSize = new System.Drawing.Size(20, 20);
            this.menu_addtocart.Location = new System.Drawing.Point(57, 206);
            this.menu_addtocart.Name = "menu_addtocart";
            this.menu_addtocart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menu_addtocart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menu_addtocart.OnHoverForeColor = System.Drawing.Color.White;
            this.menu_addtocart.OnHoverImage = null;
            this.menu_addtocart.OnPressedColor = System.Drawing.Color.Black;
            this.menu_addtocart.Radius = 20;
            this.menu_addtocart.Size = new System.Drawing.Size(217, 42);
            this.menu_addtocart.TabIndex = 2;
            this.menu_addtocart.Text = "Add to Cart";
            this.menu_addtocart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menu_addtocart.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // menu_total
            // 
            this.menu_total.BackColor = System.Drawing.Color.Transparent;
            this.menu_total.BaseColor = System.Drawing.Color.RoyalBlue;
            this.menu_total.BorderColor = System.Drawing.Color.Indigo;
            this.menu_total.BorderSize = 3;
            this.menu_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.menu_total.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.menu_total.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menu_total.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu_total.Location = new System.Drawing.Point(290, 162);
            this.menu_total.Name = "menu_total";
            this.menu_total.PasswordChar = '\0';
            this.menu_total.Radius = 5;
            this.menu_total.SelectedText = "";
            this.menu_total.Size = new System.Drawing.Size(90, 26);
            this.menu_total.TabIndex = 14;
            // 
            // menu_gunaNumeric1
            // 
            this.menu_gunaNumeric1.BaseColor = System.Drawing.Color.White;
            this.menu_gunaNumeric1.BorderColor = System.Drawing.Color.Silver;
            this.menu_gunaNumeric1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menu_gunaNumeric1.ButtonForeColor = System.Drawing.Color.White;
            this.menu_gunaNumeric1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_gunaNumeric1.ForeColor = System.Drawing.Color.Black;
            this.menu_gunaNumeric1.Location = new System.Drawing.Point(639, 190);
            this.menu_gunaNumeric1.Maximum = ((long)(9999999));
            this.menu_gunaNumeric1.Minimum = ((long)(0));
            this.menu_gunaNumeric1.Name = "menu_gunaNumeric1";
            this.menu_gunaNumeric1.Size = new System.Drawing.Size(75, 30);
            this.menu_gunaNumeric1.TabIndex = 9;
            this.menu_gunaNumeric1.Text = "gunaNumeric1";
            this.menu_gunaNumeric1.Value = ((long)(0));
            this.menu_gunaNumeric1.ValueChanged += new System.EventHandler(this.menu_gunaNumeric1_ValueChanged);
            // 
            // menu_gotocart
            // 
            this.menu_gotocart.Animated = true;
            this.menu_gotocart.AnimationHoverSpeed = 0.07F;
            this.menu_gotocart.AnimationSpeed = 0.03F;
            this.menu_gotocart.BackColor = System.Drawing.Color.Transparent;
            this.menu_gotocart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menu_gotocart.BorderColor = System.Drawing.Color.Black;
            this.menu_gotocart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menu_gotocart.FocusedColor = System.Drawing.Color.Empty;
            this.menu_gotocart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_gotocart.ForeColor = System.Drawing.Color.White;
            this.menu_gotocart.Image = null;
            this.menu_gotocart.ImageSize = new System.Drawing.Size(20, 20);
            this.menu_gotocart.Location = new System.Drawing.Point(290, 206);
            this.menu_gotocart.Name = "menu_gotocart";
            this.menu_gotocart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menu_gotocart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menu_gotocart.OnHoverForeColor = System.Drawing.Color.White;
            this.menu_gotocart.OnHoverImage = null;
            this.menu_gotocart.OnPressedColor = System.Drawing.Color.Black;
            this.menu_gotocart.Radius = 20;
            this.menu_gotocart.Size = new System.Drawing.Size(217, 42);
            this.menu_gotocart.TabIndex = 13;
            this.menu_gotocart.Text = "Go to Cart";
            this.menu_gotocart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menu_gotocart.Click += new System.EventHandler(this.menu_gotocart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(521, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(373, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "MENU";
            // 
            // menu_price
            // 
            this.menu_price.BackColor = System.Drawing.Color.Transparent;
            this.menu_price.BaseColor = System.Drawing.Color.RoyalBlue;
            this.menu_price.BorderColor = System.Drawing.Color.Indigo;
            this.menu_price.BorderSize = 3;
            this.menu_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.menu_price.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.menu_price.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menu_price.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu_price.Location = new System.Drawing.Point(132, 152);
            this.menu_price.Name = "menu_price";
            this.menu_price.PasswordChar = '\0';
            this.menu_price.Radius = 5;
            this.menu_price.SelectedText = "";
            this.menu_price.Size = new System.Drawing.Size(92, 26);
            this.menu_price.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(363, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Price";
            // 
            // menu_listBox1
            // 
            this.menu_listBox1.FormattingEnabled = true;
            this.menu_listBox1.Location = new System.Drawing.Point(27, 190);
            this.menu_listBox1.Name = "menu_listBox1";
            this.menu_listBox1.Size = new System.Drawing.Size(120, 186);
            this.menu_listBox1.TabIndex = 21;
            this.menu_listBox1.SelectedIndexChanged += new System.EventHandler(this.menu_listBox1_SelectedIndexChanged);
            // 
            // menu_search
            // 
            this.menu_search.BackColor = System.Drawing.Color.Transparent;
            this.menu_search.BaseColor = System.Drawing.Color.LightSteelBlue;
            this.menu_search.BorderColor = System.Drawing.Color.Plum;
            this.menu_search.BorderSize = 3;
            this.menu_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.menu_search.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.menu_search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menu_search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu_search.Location = new System.Drawing.Point(108, 21);
            this.menu_search.Name = "menu_search";
            this.menu_search.PasswordChar = '\0';
            this.menu_search.Radius = 5;
            this.menu_search.SelectedText = "";
            this.menu_search.Size = new System.Drawing.Size(101, 26);
            this.menu_search.TabIndex = 22;
            this.menu_search.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // menu_itemName
            // 
            this.menu_itemName.BackColor = System.Drawing.Color.Transparent;
            this.menu_itemName.BaseColor = System.Drawing.Color.RoyalBlue;
            this.menu_itemName.BorderColor = System.Drawing.Color.Indigo;
            this.menu_itemName.BorderSize = 3;
            this.menu_itemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.menu_itemName.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.menu_itemName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menu_itemName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_itemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu_itemName.Location = new System.Drawing.Point(39, 152);
            this.menu_itemName.Name = "menu_itemName";
            this.menu_itemName.PasswordChar = '\0';
            this.menu_itemName.Radius = 5;
            this.menu_itemName.SelectedText = "";
            this.menu_itemName.Size = new System.Drawing.Size(87, 26);
            this.menu_itemName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(270, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Name";
            // 
            // menu_gunaComboBox1
            // 
            this.menu_gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.menu_gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.menu_gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.menu_gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.menu_gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menu_gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.menu_gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.menu_gunaComboBox1.FormattingEnabled = true;
            this.menu_gunaComboBox1.Location = new System.Drawing.Point(274, 167);
            this.menu_gunaComboBox1.Name = "menu_gunaComboBox1";
            this.menu_gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menu_gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.menu_gunaComboBox1.Size = new System.Drawing.Size(184, 26);
            this.menu_gunaComboBox1.TabIndex = 8;
            this.menu_gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.menu_gunaComboBox1_SelectedIndexChanged);
            // 
            // menu_label1
            // 
            this.menu_label1.AutoSize = true;
            this.menu_label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menu_label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_label1.Location = new System.Drawing.Point(36, 10);
            this.menu_label1.Name = "menu_label1";
            this.menu_label1.Size = new System.Drawing.Size(137, 18);
            this.menu_label1.TabIndex = 7;
            this.menu_label1.Text = "Select Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(30, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "search";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Thistle;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(22, 433);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 28);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LOGOUT";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(588, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Quantity";
            // 
            // gunaGradient2Panel1
            // 
            gunaGradient2Panel1.BackColor = System.Drawing.Color.Teal;
            gunaGradient2Panel1.Controls.Add(this.label2);
            gunaGradient2Panel1.Controls.Add(this.linkLabel1);
            gunaGradient2Panel1.Controls.Add(this.label7);
            gunaGradient2Panel1.Controls.Add(this.menu_gunaComboBox1);
            gunaGradient2Panel1.Controls.Add(this.label6);
            gunaGradient2Panel1.Controls.Add(this.menu_listBox1);
            gunaGradient2Panel1.Controls.Add(this.label5);
            gunaGradient2Panel1.Controls.Add(this.label4);
            gunaGradient2Panel1.Controls.Add(this.label3);
            gunaGradient2Panel1.Controls.Add(this.menu_gunaNumeric1);
            gunaGradient2Panel1.Controls.Add(this.panel1);
            gunaGradient2Panel1.Controls.Add(this.panel2);
            gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Teal;
            gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.SkyBlue;
            gunaGradient2Panel1.Location = new System.Drawing.Point(-10, -6);
            gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            gunaGradient2Panel1.Size = new System.Drawing.Size(782, 478);
            gunaGradient2Panel1.TabIndex = 21;
            gunaGradient2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.menu_gotocart);
            this.panel1.Controls.Add(this.menu_addtocart);
            this.panel1.Controls.Add(this.menu_price);
            this.panel1.Controls.Add(this.menu_label1);
            this.panel1.Controls.Add(this.menu_itemName);
            this.panel1.Controls.Add(this.menu_total);
            this.panel1.Location = new System.Drawing.Point(235, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 281);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.menu_search);
            this.panel2.Location = new System.Drawing.Point(3, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 281);
            this.panel2.TabIndex = 27;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(771, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(gunaGradient2Panel1);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            gunaGradient2Panel1.ResumeLayout(false);
            gunaGradient2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton menu_addtocart;
        private Guna.UI.WinForms.GunaTextBox menu_total;
        private Guna.UI.WinForms.GunaNumeric menu_gunaNumeric1;
        private Guna.UI.WinForms.GunaButton menu_gotocart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox menu_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox menu_listBox1;
        private Guna.UI.WinForms.GunaTextBox menu_search;
        private Guna.UI.WinForms.GunaTextBox menu_itemName;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox menu_gunaComboBox1;
        private System.Windows.Forms.Label menu_label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
    }
}