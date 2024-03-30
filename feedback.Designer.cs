namespace DB_Project
{
    partial class feedback
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
            this.removeItem = new Guna.UI.WinForms.GunaButton();
            this.menu_search = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.menu_search);
            this.panel1.Controls.Add(this.removeItem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(133, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 348);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(209, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Feedback";
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
            this.removeItem.Location = new System.Drawing.Point(124, 162);
            this.removeItem.Name = "removeItem";
            this.removeItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.removeItem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.removeItem.OnHoverForeColor = System.Drawing.Color.White;
            this.removeItem.OnHoverImage = null;
            this.removeItem.OnPressedColor = System.Drawing.Color.Black;
            this.removeItem.Radius = 20;
            this.removeItem.Size = new System.Drawing.Size(160, 42);
            this.removeItem.TabIndex = 3;
            this.removeItem.Text = "submit";
            this.removeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.menu_search.Location = new System.Drawing.Point(124, 130);
            this.menu_search.Name = "menu_search";
            this.menu_search.PasswordChar = '\0';
            this.menu_search.Radius = 5;
            this.menu_search.SelectedText = "";
            this.menu_search.Size = new System.Drawing.Size(322, 26);
            this.menu_search.TabIndex = 23;
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "feedback";
            this.Text = "feedback";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton removeItem;
        private Guna.UI.WinForms.GunaTextBox menu_search;
    }
}