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
        Library Library { get; set; }

        public MainAdminForm(Library library)
        {
            Library = library;
            InitializeComponent();
            this.Hide();
        }

        private void add_book_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmptyBook(Library).ShowDialog(this);
            this.Show();
        }

        private void sections_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sections(Library).ShowDialog(this);
            this.Show();
        }
    }
}
