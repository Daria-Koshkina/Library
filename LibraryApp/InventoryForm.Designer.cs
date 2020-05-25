namespace LibraryApp
{
    partial class InventoryForm
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
            this.list = new System.Windows.Forms.ListBox();
            this.sortedByAuthor = new System.Windows.Forms.RadioButton();
            this.sortedByName = new System.Windows.Forms.RadioButton();
            this.sortedByGenre = new System.Windows.Forms.RadioButton();
            this.number_of_books = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.MaximumSize = new System.Drawing.Size(200, 43);
            this.label1.MinimumSize = new System.Drawing.Size(100, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorted by:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 23;
            this.list.Location = new System.Drawing.Point(27, 49);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(290, 326);
            this.list.TabIndex = 4;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // sortedByAuthor
            // 
            this.sortedByAuthor.AutoSize = true;
            this.sortedByAuthor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortedByAuthor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sortedByAuthor.Location = new System.Drawing.Point(130, 11);
            this.sortedByAuthor.Name = "sortedByAuthor";
            this.sortedByAuthor.Size = new System.Drawing.Size(81, 27);
            this.sortedByAuthor.TabIndex = 5;
            this.sortedByAuthor.TabStop = true;
            this.sortedByAuthor.Text = "Author";
            this.sortedByAuthor.UseVisualStyleBackColor = true;
            this.sortedByAuthor.CheckedChanged += new System.EventHandler(this.sortedByName_CheckedChanged);
            // 
            // sortedByName
            // 
            this.sortedByName.AutoSize = true;
            this.sortedByName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortedByName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sortedByName.Location = new System.Drawing.Point(217, 11);
            this.sortedByName.Name = "sortedByName";
            this.sortedByName.Size = new System.Drawing.Size(71, 27);
            this.sortedByName.TabIndex = 6;
            this.sortedByName.TabStop = true;
            this.sortedByName.Text = "Name";
            this.sortedByName.UseVisualStyleBackColor = true;
            this.sortedByName.CheckedChanged += new System.EventHandler(this.sortedByName_CheckedChanged);
            // 
            // sortedByGenre
            // 
            this.sortedByGenre.AutoSize = true;
            this.sortedByGenre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortedByGenre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sortedByGenre.Location = new System.Drawing.Point(294, 11);
            this.sortedByGenre.Name = "sortedByGenre";
            this.sortedByGenre.Size = new System.Drawing.Size(73, 27);
            this.sortedByGenre.TabIndex = 7;
            this.sortedByGenre.TabStop = true;
            this.sortedByGenre.Text = "Genre";
            this.sortedByGenre.UseVisualStyleBackColor = true;
            this.sortedByGenre.CheckedChanged += new System.EventHandler(this.sortedByName_CheckedChanged);
            // 
            // number_of_books
            // 
            this.number_of_books.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.number_of_books.AutoSize = true;
            this.number_of_books.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_books.Location = new System.Drawing.Point(27, 409);
            this.number_of_books.Name = "number_of_books";
            this.number_of_books.Size = new System.Drawing.Size(51, 20);
            this.number_of_books.TabIndex = 8;
            this.number_of_books.Text = "label2";
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.BackColor = System.Drawing.Color.SandyBrown;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.menu.Location = new System.Drawing.Point(357, 352);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(105, 39);
            this.menu.TabIndex = 9;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.number_of_books);
            this.Controls.Add(this.sortedByGenre);
            this.Controls.Add(this.sortedByName);
            this.Controls.Add(this.sortedByAuthor);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(500, 488);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.RadioButton sortedByAuthor;
        private System.Windows.Forms.RadioButton sortedByName;
        private System.Windows.Forms.RadioButton sortedByGenre;
        private System.Windows.Forms.Label number_of_books;
        private System.Windows.Forms.Button menu;
    }
}