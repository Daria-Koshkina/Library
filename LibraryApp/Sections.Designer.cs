namespace LibraryApp
{
    partial class Sections
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
            this.list_of_genres = new System.Windows.Forms.ComboBox();
            this.books = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // list_of_genres
            // 
            this.list_of_genres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_of_genres.FormattingEnabled = true;
            this.list_of_genres.Location = new System.Drawing.Point(175, 12);
            this.list_of_genres.Name = "list_of_genres";
            this.list_of_genres.Size = new System.Drawing.Size(121, 21);
            this.list_of_genres.TabIndex = 0;
            this.list_of_genres.SelectedIndexChanged += new System.EventHandler(this.list_of_genres_SelectedIndexChanged);
            // 
            // books
            // 
            this.books.FormattingEnabled = true;
            this.books.Location = new System.Drawing.Point(12, 52);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(460, 368);
            this.books.TabIndex = 1;
            this.books.SelectedIndexChanged += new System.EventHandler(this.books_SelectedIndexChanged);
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.books);
            this.Controls.Add(this.list_of_genres);
            this.Name = "Sections";
            this.Text = "Sections";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox list_of_genres;
        private System.Windows.Forms.ListBox books;
    }
}