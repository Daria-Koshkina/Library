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
    public partial class InventoryForm : Form
    {
        public Library Library { private set; get; }
        public bool IsAdmin { private set; get; }
        public InventoryForm(Library library, bool isAdmin)
        {
            Library = library;
            IsAdmin = isAdmin;
            InitializeComponent();
            this.Text = "Inventory";
            list.Hide();
            sortedByAuthor.Checked = false;
        }
        public void printListOfBooks()
        {
            list.Items.Clear();
            foreach (Book book in Library.Books)
            {
                list.Items.Add(book.Name);
            }
            number_of_books.Text = $"In this Library there are {Library.Books.Count} book/books.";
            list.Show();
        }
        public void printListOfAuthors()
        {
            list.Items.Clear();
            foreach (Author author in Library.Authors)
            {
                list.Items.Add(author.Name);
            }
            number_of_books.Text = $"In this Library there are {Library.Books.Count} book/books.";
            list.Show();
        }
        public void printListOfGenres()
        {
            list.Items.Clear();
            foreach (Genre genre in Library.Genres)
            {
                list.Items.Add(genre.Name);
            }
            number_of_books.Text = $"In this Library there are {Library.Books.Count} book/books.";
            list.Show();
        }
        public Book getBook()
        {
            foreach (Book thisBook in Library.Books)
            {
                if (thisBook.Id == Library.Books[list.SelectedIndex].Id)
                {
                    return thisBook;
                }
            }
            return null;
        }
        public Author getAuthor()
        {
            foreach (Author thisAuthor in Library.Authors)
            {
                if (thisAuthor.Id == Library.Authors[list.SelectedIndex].Id)
                {
                    return thisAuthor;
                }
            }
            return null;
        }
        public Genre getGenre()
        {
            foreach (Genre thisGenre in Library.Genres)
            {
                if (thisGenre.Id == Library.Genres[list.SelectedIndex].Id)
                {
                    return thisGenre;
                }
            }
            return null;
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortedByName.Checked)
            {
                new EmptyBook(Library, IsAdmin, getBook()).ShowDialog(this);
                printListOfBooks();
            }
            if (sortedByAuthor.Checked)
            {
                new InventoryListOfBooksForm(Library, IsAdmin, getAuthor().Id, true).ShowDialog(this);
                printListOfAuthors();
            }
            if(sortedByGenre.Checked)
            {
                new InventoryListOfBooksForm(Library, IsAdmin, getGenre().Id, false).ShowDialog(this);
                printListOfGenres();
            }
           
        }
        private void sortedByName_CheckedChanged(object sender, EventArgs e)
        {
            if (sortedByName.Checked)
            {
                printListOfBooks();
            }
            else if (sortedByAuthor.Checked)
            {
                printListOfAuthors();
            }
            else printListOfGenres();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
