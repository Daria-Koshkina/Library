namespace LibraryApp
{
    partial class ReadNowForm
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
            this.list_of_books = new System.Windows.Forms.ListBox();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(199, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read now";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_of_books
            // 
            this.list_of_books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_of_books.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_of_books.FormattingEnabled = true;
            this.list_of_books.ItemHeight = 23;
            this.list_of_books.Location = new System.Drawing.Point(25, 64);
            this.list_of_books.Name = "list_of_books";
            this.list_of_books.Size = new System.Drawing.Size(287, 349);
            this.list_of_books.TabIndex = 1;
            this.list_of_books.SelectedIndexChanged += new System.EventHandler(this.list_of_books_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.BackColor = System.Drawing.Color.SandyBrown;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.menu.Location = new System.Drawing.Point(340, 383);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(105, 36);
            this.menu.TabIndex = 2;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // ReadNowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.list_of_books);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(483, 488);
            this.Name = "ReadNowForm";
            this.Text = "ReadNowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_of_books;
        private System.Windows.Forms.Button menu;
    }
}