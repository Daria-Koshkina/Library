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
        public Library Library { set; get; }
        public Sections(Library library)
        {
            Library = library;
            InitializeComponent();
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
            new EmptyBook(Library, getBook()).ShowDialog(this);
            this.Show();
        }
        public Book getBook()
        {
            foreach (Book thisBook in Library.Books)
            {
                if (thisBook.Id == Library.ListOfBooks(list_of_genres.Text)[books.SelectedIndex].Id)
                {
                    return thisBook;
                }
            }
            return null;
        }

        private void list_of_genres_SelectedIndexChanged(object sender, EventArgs e)
        {
            books.Items.Clear();
            Book[] listbox_elements = Library.ListOfBooks(list_of_genres.Text);
            foreach(Book book in listbox_elements)
            {
                books.Items.Add(book.Name);
            }
            books.Show();
        }
    }
}
