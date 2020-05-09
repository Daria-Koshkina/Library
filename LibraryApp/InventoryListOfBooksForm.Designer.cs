namespace LibraryApp
{
    partial class InventoryListOfBooksForm
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
            this.inventoryListOfBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inventoryListOfBooks
            // 
            this.inventoryListOfBooks.FormattingEnabled = true;
            this.inventoryListOfBooks.Location = new System.Drawing.Point(13, 23);
            this.inventoryListOfBooks.Name = "inventoryListOfBooks";
            this.inventoryListOfBooks.Size = new System.Drawing.Size(265, 238);
            this.inventoryListOfBooks.TabIndex = 0;
            this.inventoryListOfBooks.SelectedIndexChanged += new System.EventHandler(this.inventoryListOfBooks_SelectedIndexChanged);
            // 
            // InventoryListOfBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 284);
            this.Controls.Add(this.inventoryListOfBooks);
            this.MaximumSize = new System.Drawing.Size(412, 322);
            this.MinimumSize = new System.Drawing.Size(412, 322);
            this.Name = "InventoryListOfBooksForm";
            this.Text = "InventoryListOfBooksForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryListOfBooks;
    }
}