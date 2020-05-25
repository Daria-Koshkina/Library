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
        public Book[] ListboxElements { private set; get; }
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
            if(getBook() == null) {
                this.Show();
                return;
            }
            new EmptyBook(Library, IsAdmin, getBook()).ShowDialog(this);
            this.Show();
            UpdteListOfBooks();

        }
        public Book getBook()
        {
            try
            {
                foreach (Book thisBook in Library.Books)
                {
                    if (thisBook.Id == ListboxElements[books.SelectedIndex].Id)
                    {
                        return thisBook;
                    }
                }
            }
            catch(System.IndexOutOfRangeException)
            {
                return null;
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
            UpdteListOfBooks();
        }
        public void UpdteListOfBooks()
        {
            ListboxElements = Library.ListOfBooksByGenre(getGenre().Id);
            Library.SortBookName(ListboxElements);
            books.Items.Clear();
            foreach (Book book in ListboxElements)
            {
                books.Items.Add(book.Name);
            }
            if (books.Items.Count == 0)
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
