namespace DB_Project
{
    partial class manager_item_prices
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menu_search = new Guna.UI.WinForms.GunaTextBox();
            this.addItem = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(133, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 348);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(162, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Set Item Prices";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(332, 188);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.menu_search.Location = new System.Drawing.Point(536, 401);
            this.menu_search.Name = "menu_search";
            this.menu_search.PasswordChar = '\0';
            this.menu_search.Radius = 5;
            this.menu_search.SelectedText = "";
            this.menu_search.Size = new System.Drawing.Size(101, 33);
            this.menu_search.TabIndex = 26;
            // 
            // addItem
            // 
            this.addItem.AnimationHoverSpeed = 0.07F;
            this.addItem.AnimationSpeed = 0.03F;
            this.addItem.BackColor = System.Drawing.Color.Transparent;
            this.addItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addItem.BorderColor = System.Drawing.Color.Black;
            this.addItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addItem.FocusedColor = System.Drawing.Color.Empty;
            this.addItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.ForeColor = System.Drawing.Color.Snow;
            this.addItem.Image = null;
            this.addItem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addItem.ImageSize = new System.Drawing.Size(20, 20);
            this.addItem.Location = new System.Drawing.Point(445, 401);
            this.addItem.Name = "addItem";
            this.addItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addItem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addItem.OnHoverForeColor = System.Drawing.Color.White;
            this.addItem.OnHoverImage = null;
            this.addItem.OnPressedColor = System.Drawing.Color.Black;
            this.addItem.Radius = 20;
            this.addItem.Size = new System.Drawing.Size(85, 37);
            this.addItem.TabIndex = 27;
            this.addItem.Text = "New price";
            this.addItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // manager_item_prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu_search);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.panel1);
            this.Name = "manager_item_prices";
            this.Text = "manager_item_prices";
            this.Load += new System.EventHandler(this.manager_item_prices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaTextBox menu_search;
        private Guna.UI.WinForms.GunaButton addItem;
    }
}