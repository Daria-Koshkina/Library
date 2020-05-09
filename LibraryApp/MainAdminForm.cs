using LibraryFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class MainAdminForm : Form
    {
        public Library Library { get; private set; }
        public bool IsAdmin { private set; get; }

        public MainAdminForm(Library library, bool isAdmin)
        {
            Library = library;
            IsAdmin = isAdmin;
            InitializeComponent();
            this.Text = "Main form";
            if(IsAdmin == false)
            {
                add_book.Hide();
                inventory.Hide();
            }

        }

        private void add_book_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmptyBook(Library, IsAdmin).ShowDialog(this);
            this.Show();
        }

        private void sections_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sections(Library, IsAdmin).ShowDialog(this);
            this.Show();
        }

        private void read_now_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReadNowForm(Library, IsAdmin).ShowDialog(this);
            this.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchForm(Library, IsAdmin).ShowDialog(this);
            this.Show();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InventoryForm(Library, IsAdmin).ShowDialog(this);
            this.Show();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            this.Close();
            new AuthorizationForm(Library).Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            string caption = "Application closing";
            string message = "Are you sure that you would like to close this application?";
            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
