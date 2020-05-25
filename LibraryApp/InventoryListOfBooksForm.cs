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
    public partial class InventoryListOfBooksForm : Form
    { 
        public Library Library { private set; get; }
        public bool IsAdmin { private set; get; }
        public Guid Id { set; get; }
        public bool IsAuthor { set; get; }
        Book[] Books { set; get; }
        public InventoryListOfBooksForm(Library library, bool isAdmin, Guid id, bool isAuthor)
        {
            Library = library;
            IsAdmin = isAdmin;
            Id = id;
            IsAuthor = isAuthor;
            InitializeComponent();
            this.Text = "Books";
            prinListOfBooks();
        }

        private void inventoryListOfBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            if(getBook() == null)
            {
                this.Show();
                return;
            }
            new EmptyBook(Library, IsAdmin, getBook()).ShowDialog(this);
            this.Show();
            prinListOfBooks();
        }
        public Book getBook()
        {
            try
            {
                foreach (Book thisBook in Library.Books)
                {
                    if (thisBook.Id == Books[inventoryListOfBooks.SelectedIndex].Id)
                    {
                        return thisBook;
                    }
                }
            }
            catch
            {
                return null;
            }
            
            return null;
        }
        public void prinListOfBooks()
        {
            if (IsAuthor) Books = Library.ListOfBooksByAuthor(Id);
            else Books = Library.ListOfBooksByGenre(Id);
            inventoryListOfBooks.Items.Clear();
            foreach (Book book in Books)
            {
                inventoryListOfBooks.Items.Add(book.Name);
            }
            inventoryListOfBooks.Show();
        }
    }
}
