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
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_of_genres
            // 
            this.list_of_genres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.list_of_genres.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_of_genres.FormattingEnabled = true;
            this.list_of_genres.Location = new System.Drawing.Point(175, 12);
            this.list_of_genres.Name = "list_of_genres";
            this.list_of_genres.Size = new System.Drawing.Size(121, 31);
            this.list_of_genres.TabIndex = 0;
            this.list_of_genres.SelectedIndexChanged += new System.EventHandler(this.list_of_genres_SelectedIndexChanged);
            // 
            // books
            // 
            this.books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.books.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.books.FormattingEnabled = true;
            this.books.ItemHeight = 23;
            this.books.Location = new System.Drawing.Point(19, 63);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(299, 349);
            this.books.TabIndex = 1;
            this.books.SelectedIndexChanged += new System.EventHandler(this.books_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.BackColor = System.Drawing.Color.SandyBrown;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.menu.Location = new System.Drawing.Point(353, 373);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(103, 35);
            this.menu.TabIndex = 2;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.books);
            this.Controls.Add(this.list_of_genres);
            this.MinimumSize = new System.Drawing.Size(500, 488);
            this.Name = "Sections";
            this.Text = "Sections";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox list_of_genres;
        private System.Windows.Forms.ListBox books;
        private System.Windows.Forms.Button menu;
    }
}