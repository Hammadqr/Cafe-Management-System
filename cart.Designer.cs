namespace DB_Project
{
    partial class cart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cart_checkout = new Guna.UI.WinForms.GunaButton();
            this.removeItem = new Guna.UI.WinForms.GunaButton();
            this.addItem = new Guna.UI.WinForms.GunaButton();
            this.back = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(85, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 348);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 225);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(209, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "CART";
            // 
            // cart_checkout
            // 
            this.cart_checkout.AnimationHoverSpeed = 0.07F;
            this.cart_checkout.AnimationSpeed = 0.03F;
            this.cart_checkout.BackColor = System.Drawing.Color.Transparent;
            this.cart_checkout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cart_checkout.BorderColor = System.Drawing.Color.Black;
            this.cart_checkout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cart_checkout.FocusedColor = System.Drawing.Color.Empty;
            this.cart_checkout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_checkout.ForeColor = System.Drawing.Color.Snow;
            this.cart_checkout.Image = null;
            this.cart_checkout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cart_checkout.ImageSize = new System.Drawing.Size(20, 20);
            this.cart_checkout.Location = new System.Drawing.Point(432, 381);
            this.cart_checkout.Name = "cart_checkout";
            this.cart_checkout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cart_checkout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cart_checkout.OnHoverForeColor = System.Drawing.Color.White;
            this.cart_checkout.OnHoverImage = null;
            this.cart_checkout.OnPressedColor = System.Drawing.Color.Black;
            this.cart_checkout.Radius = 20;
            this.cart_checkout.Size = new System.Drawing.Size(187, 42);
            this.cart_checkout.TabIndex = 1;
            this.cart_checkout.Text = "Proceed To checkout";
            this.cart_checkout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // removeItem
            // 
            this.removeItem.AnimationHoverSpeed = 0.07F;
            this.removeItem.AnimationSpeed = 0.03F;
            this.removeItem.BackColor = System.Drawing.Color.Transparent;
            this.removeItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeItem.BorderColor = System.Drawing.Color.Black;
            this.removeItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.removeItem.FocusedColor = System.Drawing.Color.Empty;
            this.removeItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItem.ForeColor = System.Drawing.Color.GhostWhite;
            this.removeItem.Image = null;
            this.removeItem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removeItem.ImageSize = new System.Drawing.Size(20, 20);
            this.removeItem.Location = new System.Drawing.Point(625, 219);
            this.removeItem.Name = "removeItem";
            this.removeItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.removeItem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.removeItem.OnHoverForeColor = System.Drawing.Color.White;
            this.removeItem.OnHoverImage = null;
            this.removeItem.OnPressedColor = System.Drawing.Color.Black;
            this.removeItem.Radius = 20;
            this.removeItem.Size = new System.Drawing.Size(160, 42);
            this.removeItem.TabIndex = 2;
            this.removeItem.Text = "Remove Item";
            this.removeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.addItem.Location = new System.Drawing.Point(628, 171);
            this.addItem.Name = "addItem";
            this.addItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addItem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addItem.OnHoverForeColor = System.Drawing.Color.White;
            this.addItem.OnHoverImage = null;
            this.addItem.OnPressedColor = System.Drawing.Color.Black;
            this.addItem.Radius = 20;
            this.addItem.Size = new System.Drawing.Size(160, 42);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "Add Item";
            this.addItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // back
            // 
            this.back.AnimationHoverSpeed = 0.07F;
            this.back.AnimationSpeed = 0.03F;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back.BorderColor = System.Drawing.Color.Black;
            this.back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.back.FocusedColor = System.Drawing.Color.Empty;
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.GhostWhite;
            this.back.Image = null;
            this.back.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.back.ImageSize = new System.Drawing.Size(20, 20);
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.back.OnHoverBorderColor = System.Drawing.Color.Black;
            this.back.OnHoverForeColor = System.Drawing.Color.White;
            this.back.OnHoverImage = null;
            this.back.OnPressedColor = System.Drawing.Color.Black;
            this.back.Radius = 20;
            this.back.Size = new System.Drawing.Size(67, 42);
            this.back.TabIndex = 4;
            this.back.Text = "BACK";
            this.back.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.cart_checkout);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.panel1);
            this.Name = "cart";
            this.Text = "cart";
            this.Load += new System.EventHandler(this.cart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton cart_checkout;
        private Guna.UI.WinForms.GunaButton removeItem;
        private Guna.UI.WinForms.GunaButton addItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton back;
    }
}