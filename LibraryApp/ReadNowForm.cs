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
    public partial class ReadNowForm : Form
    {
        public Library Library { private set; get; }
        public bool IsAdmin { private set; get; }
        public ReadNowForm(Library library, bool isAdmin)
        {
            Library = library;
            IsAdmin = isAdmin;
            InitializeComponent();
            this.Text = "Reading now";
            printListOfLikedBooks();
            list_of_books.ScrollAlwaysVisible = true;
        }

        private void list_of_books_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            new EmptyBook(Library, IsAdmin, getBook()).ShowDialog(this);
            this.Show();
            printListOfLikedBooks();
        }
        public Book getBook()
        {
            foreach (Book thisBook in Library.Books)
            {
                if (thisBook.Id == Library.GetBooksReadNow()[list_of_books.SelectedIndex].Id)
                {
                    return thisBook;
                }
            }
            return null;
        }
        public void printListOfLikedBooks()
        {
            list_of_books.Items.Clear();
            foreach (Book book in Library.GetBooksReadNow())
            {
                list_of_books.Items.Add(book.Name);
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
