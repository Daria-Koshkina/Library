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
        public Book[] BooksList { private set; get; }
        public Author[] AuthorsList { private set; get; }
        public Genre[] GenresList { private set; get; }
        public InventoryForm(Library library, bool isAdmin)
        {
            Library = library;
            IsAdmin = isAdmin;
            InitializeComponent();
            this.Text = "Inventory";
            list.Hide();
            sortedByAuthor.Checked = false;
        }
        public void UpdateListOfBooks()
        {
            BooksList = Library.Books.ToArray();
            Library.SortBookName(BooksList);
            list.Items.Clear();
            foreach (Book book in BooksList)
            {
                list.Items.Add(book.Name);
            }
            number_of_books.Text = $"In this Library there are {Library.Books.Count} book/books.";
            list.Show();
        }
        public void UpdateListOfAuthors()
        {
            AuthorsList = Library.Authors.ToArray();
            Library.SortAuthorName(AuthorsList);
            list.Items.Clear();
            foreach (Author author in AuthorsList)
            {
                list.Items.Add(author.Name);
            }
            number_of_books.Text = $"In this Library there are {Library.Books.Count} book/books.";
            list.Show();
        }
        public void UpdateListOfGenres()
        {
            GenresList = Library.Genres.ToArray();
            Library.SortGenreName(GenresList);
            list.Items.Clear();
            foreach (Genre genre in GenresList)
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
                if (thisBook.Id == BooksList[list.SelectedIndex].Id)
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
                if (thisAuthor.Id == AuthorsList[list.SelectedIndex].Id)
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
                if (thisGenre.Id == GenresList[list.SelectedIndex].Id)
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
                UpdateListOfBooks();
            }
            if (sortedByAuthor.Checked)
            {
                new InventoryListOfBooksForm(Library, IsAdmin, getAuthor().Id, true).ShowDialog(this);
                UpdateListOfAuthors();
            }
            if(sortedByGenre.Checked)
            {
                new InventoryListOfBooksForm(Library, IsAdmin, getGenre().Id, false).ShowDialog(this);
                UpdateListOfGenres();
            }
           
        }
        private void sortedByName_CheckedChanged(object sender, EventArgs e)
        {
            if (sortedByName.Checked)
            {
                UpdateListOfBooks();
            }
            else if (sortedByAuthor.Checked)
            {
                UpdateListOfAuthors();
            }
            else UpdateListOfGenres();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
