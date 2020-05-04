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
    public partial class EmptyBook : Form
    {
        public Library Library { private set; get; }
        public Book Book { set; get; }
        public EmptyBook(Library library, Book book = null)
        {
            Library = library;
            Book = book;
            InitializeComponent();
            if (Book != null)
            {
                author.Text = Book.Author.Name;
                author.Enabled = false;
                name.Text = Book.Name;
                name.Enabled = false;
                genres.Text = Book.Genre.Name;
                genres.Enabled = false;
                year.Value = Book.Year;
                year.Enabled = false;
                annotation.Text = Book.Annotation;
                annotation.Enabled = false;
                if (Book.userId == Library.CurrentUser.Id)
                {
                    read_now.Checked = true;
                }
            }
            AddGenres();
            this.Hide();
        }
        public void AddGenres()
        {
            foreach (Genre genre in Library.Genres)
            {
                genres.Items.Add(genre.Name);
            }
        }

        public bool ValidateBookData()
        {
            if(author.Text.Length == 0)
            {
                string message = "You did not enter an author";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
                return false;
            }
            if (name.Text.Length == 0)
            {
                string message = "You did not enter a book name";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
                return false;
            }
            if (year.Text.Length == 0)
            {
                string message = "You did not enter a year";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
                return false;
            }
            if (genres.Text.Length == 0)
            {
                string message = "You did not enter a genre";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
                return false;
            }
            return true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (ValidateBookData())
            {
                if (Book == null) 
                {
                    Book currentBook = Library.AddBook(name.Text, author.Text, genres.Text, Convert.ToInt32(year.Value), annotation.Text);
                    if (read_now.Checked)
                    {
                        Library.getBook(currentBook);
                    }
                }
                else
                {
                    if (read_now.Checked)
                    {
                        Library.getBook(Book);
                    }
                    else Library.returnBook(Book);
                }
                this.Hide();
            }
        }

        private void read_now_CheckedChanged(object sender, EventArgs e)
        {
            if (Book == null) return;
            if (read_now.Checked)
            {
                if (Book.userId != Guid.Empty && Book.userId != Library.CurrentUser.Id)
                {
                    string message = "This book is already taken from the library";
                    string caption = "Get book status changing";
                    MessageBox.Show(message, caption);
                    read_now.Checked = false;
                }
            }
        }
    }
}
