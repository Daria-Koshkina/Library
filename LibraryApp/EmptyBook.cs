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
        public bool IsAdmin { private set; get; }
        public Book Book { set; get; }
        public EmptyBook(Library library, bool isAdmin, Book book = null)
        {
            Library = library;
            IsAdmin = isAdmin;
            Book = book;
            InitializeComponent();
            if(Book != null) this.Text = $"Book {Book.Name}";
            if(Book == null)
            {
                delete_book.Hide();
            }

            else this.Text = "Book";
            if(IsAdmin == false)
            {
                delete_book.Hide();
            }

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
                foreach(Guid userId in Book.likedBy)
                {
                    if(userId == Library.CurrentUser.Id)
                    {
                        press_like.Checked = true;
                        break;
                    }
                }
                number_of_likes.Text = $"{book.likedBy.Count} people liked this book";
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
                    if (press_like.Checked)
                    {
                        Library.pressLike(currentBook);
                    }
                }
                else
                {
                    if (read_now.Checked)
                    {
                        Library.getBook(Book);
                    }
                    else Library.returnBook(Book);
                    if (press_like.Checked)
                    {
                        Library.pressLike(Book);
                    }
                    else Library.removeLike(Book);
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

        private void delete_book_Click(object sender, EventArgs e)
        {
            string caption = "Deleting book";
            string message = "Are you sure that you would like to delete this book?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                Library.DeleteBook(Book.Id);
                this.Hide();
            }
            
        }

        private void press_like_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
