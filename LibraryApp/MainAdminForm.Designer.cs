namespace LibraryApp
{
    partial class MainAdminForm
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
            this.sections = new System.Windows.Forms.Button();
            this.add_book = new System.Windows.Forms.Button();
            this.log_out = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.read_now = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sections
            // 
            this.sections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sections.Location = new System.Drawing.Point(131, 69);
            this.sections.Name = "sections";
            this.sections.Size = new System.Drawing.Size(226, 23);
            this.sections.TabIndex = 0;
            this.sections.Text = "Sections";
            this.sections.UseVisualStyleBackColor = true;
            this.sections.Click += new System.EventHandler(this.sections_Click);
            // 
            // add_book
            // 
            this.add_book.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_book.Location = new System.Drawing.Point(131, 166);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(226, 23);
            this.add_book.TabIndex = 1;
            this.add_book.Text = "Add new Book";
            this.add_book.UseVisualStyleBackColor = true;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // log_out
            // 
            this.log_out.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_out.Location = new System.Drawing.Point(131, 399);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(226, 23);
            this.log_out.TabIndex = 3;
            this.log_out.Text = "LOG OUT";
            this.log_out.UseVisualStyleBackColor = true;
            // 
            // inventory
            // 
            this.inventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventory.Location = new System.Drawing.Point(131, 267);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(226, 23);
            this.inventory.TabIndex = 5;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Location = new System.Drawing.Point(131, 216);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(226, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // read_now
            // 
            this.read_now.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.read_now.Location = new System.Drawing.Point(131, 117);
            this.read_now.Name = "read_now";
            this.read_now.Size = new System.Drawing.Size(226, 23);
            this.read_now.TabIndex = 6;
            this.read_now.Text = "Read now";
            this.read_now.UseVisualStyleBackColor = true;
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.read_now);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.search);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.add_book);
            this.Controls.Add(this.sections);
            this.Name = "MainAdminForm";
            this.Text = "MainAdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sections;
        private System.Windows.Forms.Button add_book;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button read_now;
    }
}