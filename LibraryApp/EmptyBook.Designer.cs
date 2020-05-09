namespace LibraryApp
{
    partial class EmptyBook
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
            this.author = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            this.read_now = new System.Windows.Forms.CheckBox();
            this.genres = new System.Windows.Forms.ComboBox();
            this.annotation = new System.Windows.Forms.RichTextBox();
            this.press_like = new System.Windows.Forms.CheckBox();
            this.delete_book = new System.Windows.Forms.Button();
            this.number_of_likes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(42, 52);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(140, 20);
            this.author.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(42, 97);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(140, 20);
            this.name.TabIndex = 2;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(42, 143);
            this.year.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(140, 20);
            this.year.TabIndex = 4;
            this.year.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(350, 401);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(103, 35);
            this.save.TabIndex = 5;
            this.save.Text = "Save\r\n";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // read_now
            // 
            this.read_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.read_now.Location = new System.Drawing.Point(309, 52);
            this.read_now.Name = "read_now";
            this.read_now.Size = new System.Drawing.Size(140, 20);
            this.read_now.TabIndex = 6;
            this.read_now.Text = "Read now";
            this.read_now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.read_now.UseVisualStyleBackColor = true;
            this.read_now.CheckedChanged += new System.EventHandler(this.read_now_CheckedChanged);
            // 
            // genres
            // 
            this.genres.FormattingEnabled = true;
            this.genres.Location = new System.Drawing.Point(42, 189);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(140, 21);
            this.genres.Sorted = true;
            this.genres.TabIndex = 7;
            // 
            // annotation
            // 
            this.annotation.Location = new System.Drawing.Point(83, 275);
            this.annotation.Name = "annotation";
            this.annotation.Size = new System.Drawing.Size(314, 96);
            this.annotation.TabIndex = 8;
            this.annotation.Text = "";
            // 
            // press_like
            // 
            this.press_like.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.press_like.Location = new System.Drawing.Point(309, 97);
            this.press_like.Name = "press_like";
            this.press_like.Size = new System.Drawing.Size(140, 20);
            this.press_like.TabIndex = 9;
            this.press_like.Text = "Press like";
            this.press_like.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.press_like.UseVisualStyleBackColor = true;
            this.press_like.CheckedChanged += new System.EventHandler(this.press_like_CheckedChanged);
            // 
            // delete_book
            // 
            this.delete_book.Location = new System.Drawing.Point(29, 401);
            this.delete_book.Name = "delete_book";
            this.delete_book.Size = new System.Drawing.Size(99, 35);
            this.delete_book.TabIndex = 10;
            this.delete_book.Text = "Delete book";
            this.delete_book.UseVisualStyleBackColor = true;
            this.delete_book.Click += new System.EventHandler(this.delete_book_Click);
            // 
            // number_of_likes
            // 
            this.number_of_likes.Location = new System.Drawing.Point(309, 143);
            this.number_of_likes.Name = "number_of_likes";
            this.number_of_likes.Size = new System.Drawing.Size(129, 20);
            this.number_of_likes.TabIndex = 11;
            this.number_of_likes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmptyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.number_of_likes);
            this.Controls.Add(this.delete_book);
            this.Controls.Add(this.press_like);
            this.Controls.Add(this.annotation);
            this.Controls.Add(this.genres);
            this.Controls.Add(this.read_now);
            this.Controls.Add(this.save);
            this.Controls.Add(this.year);
            this.Controls.Add(this.name);
            this.Controls.Add(this.author);
            this.Name = "EmptyBook";
            this.Text = "EmptyBook";
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox read_now;
        private System.Windows.Forms.ComboBox genres;
        private System.Windows.Forms.RichTextBox annotation;
        private System.Windows.Forms.CheckBox press_like;
        private System.Windows.Forms.Button delete_book;
        private System.Windows.Forms.Label number_of_likes;
    }
}