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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read now";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_of_books
            // 
            this.list_of_books.FormattingEnabled = true;
            this.list_of_books.Location = new System.Drawing.Point(25, 64);
            this.list_of_books.Name = "list_of_books";
            this.list_of_books.Size = new System.Drawing.Size(287, 355);
            this.list_of_books.TabIndex = 1;
            this.list_of_books.SelectedIndexChanged += new System.EventHandler(this.list_of_books_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(439, 383);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(105, 36);
            this.menu.TabIndex = 2;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // ReadNowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.list_of_books);
            this.Controls.Add(this.label1);
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