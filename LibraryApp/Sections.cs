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
    public partial class Sections : Form
    {
        public Library Library { private set; get; }
        public bool IsAdmin { private set; get; }
        public Sections(Library library, bool isAdmin)
        {
            Library = library;
            IsAdmin = isAdmin;
            InitializeComponent();
            this.Text = "Sections";
            list_of_genres.Text = "Genre";
            foreach (Genre genre in Library.Genres)
            {
                list_of_genres.Items.Add(genre.Name);
            }
            books.ScrollAlwaysVisible = true;
            books.Hide();
        }

        private void books_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            new EmptyBook(Library, IsAdmin, getBook()).ShowDialog(this);
            this.Show();
            printListOfBooks();

        }
        public Book getBook()
        {
            foreach (Book thisBook in Library.Books)
            {
                if (thisBook.Id == Library.ListOfBooksByGenre(getGenre().Id)[books.SelectedIndex].Id)
                {
                    return thisBook;
                }
            }
            return null;
        }
        public Genre getGenre()
        {
            foreach (Genre thisGenre in Library.Genres)
            {
                if (thisGenre.Id == Library.Genres[list_of_genres.SelectedIndex].Id)
                {
                    return thisGenre;
                }
            }
            return null;
        }

        private void list_of_genres_SelectedIndexChanged(object sender, EventArgs e)
        {
            printListOfBooks();
        }
        public void printListOfBooks()
        {
            books.Items.Clear();
            Book[] listbox_elements = Library.ListOfBooksByGenre(getGenre().Id);
            foreach (Book book in listbox_elements)
            {
                books.Items.Add(book.Name);
            }
            if(books.Items.Count == 0)
            {
                list_of_genres.Items.Clear();
                foreach (Genre genre in Library.Genres)
                {
                    list_of_genres.Items.Add(genre.Name);
                }
            }
            books.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
