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
    public partial class SearchForm : Form
    {
        public Library Library { private set; get; }
        public bool IsAdmin { private set; get; }
        public Book[] SearchBooks { private set; get; }
        public SearchForm(Library library, bool isAdmin)
        {
            Library = library;
            IsAdmin = isAdmin;
            InitializeComponent();
            books.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            UpdateListOfBooks();
        }

        private void books_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            new EmptyBook(Library, IsAdmin, getBook()).ShowDialog(this);
            this.Show();
            UpdateListOfBooks();
        }
        public Book getBook()
        {
            foreach (Book thisBook in Library.Books)
            {
                if (thisBook.Id == SearchBooks[books.SelectedIndex].Id)
                {
                    return thisBook;
                }
            }
            return null;
        }

        public void UpdateListOfBooks()
        {
            string searchString = textBoxSearch.Text.Trim();
            if (searchString.Length == 0) return;
            SearchBooks = Library.Search(searchString);
            Library.SortBookName(SearchBooks);
            books.Items.Clear();
            foreach (Book book in SearchBooks)
            {
                books.Items.Add($"{book.Name} {book.Author.Name}");
            }
            books.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
