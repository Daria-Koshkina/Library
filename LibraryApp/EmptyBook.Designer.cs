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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // author
            // 
            this.author.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.author.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.Location = new System.Drawing.Point(42, 41);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(235, 30);
            this.author.TabIndex = 0;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(42, 97);
            this.name.MinimumSize = new System.Drawing.Size(140, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(235, 30);
            this.name.TabIndex = 2;
            // 
            // year
            // 
            this.year.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.year.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.Location = new System.Drawing.Point(42, 157);
            this.year.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(235, 30);
            this.year.TabIndex = 4;
            this.year.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.BackColor = System.Drawing.Color.SandyBrown;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.Color.SaddleBrown;
            this.save.Location = new System.Drawing.Point(350, 401);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(103, 35);
            this.save.TabIndex = 5;
            this.save.Text = "Save\r\n";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // read_now
            // 
            this.read_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.read_now.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.read_now.ForeColor = System.Drawing.Color.SaddleBrown;
            this.read_now.Location = new System.Drawing.Point(309, 46);
            this.read_now.Name = "read_now";
            this.read_now.Size = new System.Drawing.Size(140, 28);
            this.read_now.TabIndex = 6;
            this.read_now.Text = "Read now";
            this.read_now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.read_now.UseVisualStyleBackColor = true;
            this.read_now.CheckedChanged += new System.EventHandler(this.read_now_CheckedChanged);
            // 
            // genres
            // 
            this.genres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genres.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genres.FormattingEnabled = true;
            this.genres.Location = new System.Drawing.Point(42, 213);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(235, 31);
            this.genres.Sorted = true;
            this.genres.TabIndex = 7;
            // 
            // annotation
            // 
            this.annotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.annotation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.annotation.Location = new System.Drawing.Point(83, 275);
            this.annotation.Name = "annotation";
            this.annotation.Size = new System.Drawing.Size(314, 96);
            this.annotation.TabIndex = 8;
            this.annotation.Text = "";
            // 
            // press_like
            // 
            this.press_like.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.press_like.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.press_like.ForeColor = System.Drawing.Color.SaddleBrown;
            this.press_like.Location = new System.Drawing.Point(309, 90);
            this.press_like.Name = "press_like";
            this.press_like.Size = new System.Drawing.Size(140, 30);
            this.press_like.TabIndex = 9;
            this.press_like.Text = "Press like";
            this.press_like.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.press_like.UseVisualStyleBackColor = true;
            this.press_like.CheckedChanged += new System.EventHandler(this.press_like_CheckedChanged);
            // 
            // delete_book
            // 
            this.delete_book.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete_book.BackColor = System.Drawing.Color.SandyBrown;
            this.delete_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_book.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_book.ForeColor = System.Drawing.Color.SaddleBrown;
            this.delete_book.Location = new System.Drawing.Point(29, 401);
            this.delete_book.Name = "delete_book";
            this.delete_book.Size = new System.Drawing.Size(119, 35);
            this.delete_book.TabIndex = 10;
            this.delete_book.Text = "Delete book";
            this.delete_book.UseVisualStyleBackColor = false;
            this.delete_book.Click += new System.EventHandler(this.delete_book_Click);
            // 
            // number_of_likes
            // 
            this.number_of_likes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.number_of_likes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_likes.ForeColor = System.Drawing.Color.SaddleBrown;
            this.number_of_likes.Location = new System.Drawing.Point(309, 143);
            this.number_of_likes.Name = "number_of_likes";
            this.number_of_likes.Size = new System.Drawing.Size(129, 34);
            this.number_of_likes.TabIndex = 11;
            this.number_of_likes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(45, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(45, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(45, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(45, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(92, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Annotation";
            // 
            // EmptyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.MinimumSize = new System.Drawing.Size(500, 500);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}