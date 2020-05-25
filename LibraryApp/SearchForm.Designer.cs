namespace LibraryApp
{
    partial class SearchForm
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.books = new System.Windows.Forms.ListBox();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(22, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(364, 30);
            this.textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonSearch.Location = new System.Drawing.Point(393, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(79, 37);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // books
            // 
            this.books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.books.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.books.FormattingEnabled = true;
            this.books.ItemHeight = 23;
            this.books.Location = new System.Drawing.Point(22, 53);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(266, 349);
            this.books.TabIndex = 2;
            this.books.SelectedIndexChanged += new System.EventHandler(this.books_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.BackColor = System.Drawing.Color.SandyBrown;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.menu.Location = new System.Drawing.Point(358, 382);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(114, 39);
            this.menu.TabIndex = 3;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.books);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.MinimumSize = new System.Drawing.Size(500, 488);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox books;
        private System.Windows.Forms.Button menu;
    }
}