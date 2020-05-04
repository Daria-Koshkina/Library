using Course_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project.Models

{
    class Library
    {
        public List<Admin> Admins { private set; get; }
        public List<Guest> Guests { private set; get; }
        public List<Book> Books { private set; get; }
        public List<Genre> Genres { private set; get; }
        public List<Author> Authors { private set; get; }

        private Dao<Admin> adminsDao = new Dao<Admin>("admin.bin");
        private Dao<Guest> guestsDao = new Dao<Guest>("guest.bin");
        private Dao<Book> booksDao = new Dao<Book>("book.bin");
        private Dao<Genre> genresDao = new Dao<Genre>("genre.bin");
        private Dao<Author> authorsDao = new Dao<Author>("author.bin");


        public Library()
        {
            Admins = adminsDao.Load();
            Guests = guestsDao.Load();
            Books = booksDao.Load();
            Genres = genresDao.Load();
            Authors = authorsDao.Load();
        }

        public void FillDataTest(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                AddBook($"Book{i}", $"Author{i}", $"Genre{i}", 100 * i, "Good book!");
            }
        }

        public void Register(string name, string login, int pasword, string type)
        {
            if (IsInList(login))
            {
                // A user with this login already exists.
                return;
            }
            if (type == "Admin")
            {
                Admin admin = new Admin(name, login, pasword);
                Admins.Add(admin);
                adminsDao.Save(Admins);
            }
            else
            {
                Guest guest = new Guest(name, login, pasword);
                Guests.Add(guest);
                guestsDao.Save(Guests);
            }
        }

        public bool Authorize(string login, int password)
        {
            foreach (Admin admin in Admins)
            {
                if (admin.Login == login && admin.Password == password) return true;
            }
            foreach (Guest guest in Guests)
            {
                if (guest.Login == login && guest.Password == password) return true;
            }
            return false;
        }

        public void AddBook(string name, string authorName, string genreName, int year, string annotation)
        {
            Book book = new Book(name, GetAuthor(authorName), GetGenre(genreName), year, annotation);
            Books.Add(book);
            booksDao.Save(Books);
        }

        public void DeleteBook(Guid id)
        {
            foreach(Book book in Books)
            {
                if(book.Id == id)
                {
                    Books.Remove(book);
                    booksDao.Save(Books);
                    break;
                }
            }
        }

        public Book[] Search(string query)
        {
            string query1 = query.ToLower();
            return Books.Where(book => book.Name.ToLower().Contains(query1) || book.Author.Name.ToLower().Contains(query1)).ToArray();            
        }



        private Author GetAuthor(string authorName)
        {
            foreach(Author a in Authors)
            {
                if (a.Name == authorName) return a;
            }
            Author author = new Author(authorName);
            Authors.Add(author);
            authorsDao.Save(Authors);
            return author;
        }
        private Genre GetGenre(string genreName)
        {
            foreach (Genre g in Genres)
            {
                if (g.Name == genreName) return g;
            }
            Genre genre = new Genre(genreName);
            Genres.Add(genre);
            genresDao.Save(Genres);
            return genre;
        }
        private bool IsInList(string login)
        {
            foreach(Admin admin in Admins)
            {
                if (admin.Login == login) return true;
            }
            foreach(Guest guest in Guests)
            {
                if (guest.Login == login) return true;
            }
            return false;
        }
    }
}
