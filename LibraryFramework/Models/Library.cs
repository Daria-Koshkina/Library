using Course_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFramework.Models

{
    /// <summary>
    /// This is the main class. It consist of a few collection of objects. Collection of books, of authors, of genres, of admins and guests.
    /// </summary>
    public class Library
    {
        public List<Admin> Admins { private set; get; }
        public List<Guest> Guests { private set; get; }
        public List<Book> Books { private set; get; }
        public List<Genre> Genres { private set; get; }
        public List<Author> Authors { private set; get; }
        public User CurrentUser { private set; get; }

        /// <summary>
        /// The following private properties create collections of elements of the Dao class for working with data.
        /// </summary>
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
            CurrentUser = null;
        }

        /// <summary>
        /// This method creates test data and fills the library. 
        /// </summary>
        /// <param name="n"></param>
        public void FillDataTest(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                AddBook($"Book{i}", $"Author{i}", $"Genre{i}", 100 * i, "Good book!");
            }
        }

        /// <summary>
        /// This method creates a new user. 
        /// </summary>
        /// <param name="name">user name</param>
        /// <param name="login">unique user login</param>
        /// <param name="password">user password</param>
        /// <param name="isAdmin">boolean variable, if the user is registered as an administrator, the variable is equal to true, if as a guest - false</param>
        /// <returns>If data was entered incorrectly method returns false, otherwise returns false.</returns>
        public bool Register(string name, string login, string password, bool isAdmin)
        {
            int passwordHash = password.GetHashCode();
            if (IsInList(login))
            {
                return false;
            }
            if (isAdmin)
            {
                Admin admin = new Admin(name, login, passwordHash);
                CurrentUser = admin;
                Admins.Add(admin);
                adminsDao.Save(Admins);
            }
            else
            {
                Guest guest = new Guest(name, login, passwordHash);
                CurrentUser = guest;
                Guests.Add(guest);
                guestsDao.Save(Guests);
            }
            return true;
        }

        /// <summary>
        /// Authorizes user. Requests login and password.
        /// </summary>
        /// <param name="login">user login</param>
        /// <param name="password">user password</param>
        /// <returns>If data was entered incorrectly method returns false, otherwise returns false.</returns>
        public bool Authorize(string login, string password)
        {
            int passwordHash = password.GetHashCode();
            foreach (Admin admin in Admins)
            {
                if (admin.Login == login && admin.Password == passwordHash)
                {
                    CurrentUser = admin;
                    return true;
                }
            }
            foreach (Guest guest in Guests)
            {
                if (guest.Login == login && guest.Password == passwordHash)
                {
                    CurrentUser = guest;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// This method creates new book and adds it to the library.
        /// </summary>
        /// <param name="name">book name</param>
        /// <param name="authorName">author name</param>
        /// <param name="genreName">genre name</param>
        /// <param name="year">year of publication of the book</param>
        /// <param name="annotation">annotation</param>
        /// <returns></returns>
        public Book AddBook(string name, string authorName, string genreName, int year, string annotation)
        {
            Book book = new Book(name, GetAuthor(authorName), GetGenre(genreName), year, annotation);
            Books.Add(book);
            booksDao.Save(Books);
            return book;
        }

        public void DeleteBook(Guid id)
        {
            foreach(Book book in Books)
            {
                if(book.Id == id)
                {
                    Guid authorId = book.Author.Id;
                    Guid genreId = book.Genre.Id;
                    Books.Remove(book);
                    booksDao.Save(Books);
                    this.deleteAutor(authorId);
                    this.deleteGenre(genreId);
                    
                    break;
                }
            }
        }
        public Book[] ListOfBooksByGenre(Guid id)
        {
            List<Book> list = new List<Book>();
            foreach(Book book in Books)
            {
                if (book.Genre.Id == id) list.Add(book);
            }
            Book[] books = new Book[list.Count];
            for(int i = 0; i < books.Length; i++)
            {
                books[i] = list[i];
            }
            return books;
        }
        public Book[] ListOfBooksByAuthor(Guid id)
        {
            List<Book> books = new List<Book>();
            foreach(Book book in Books)
            {
                if (book.Author.Id == id)
                {
                    books.Add(book);
                }
            }
            return books.ToArray();
        }

        public Book[] Search(string query)
        {
            string query1 = query.ToLower();
            return Books.Where(book => book.Name.ToLower().Contains(query1) || book.Author.Name.ToLower().Contains(query1)).ToArray();            
        }

        public bool IsInList(string login)
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
        public List<Book> GetBooksReadNow()
        {
            List<Book> books = new List<Book>();
            foreach(Book book in Books)
            {
                if (book.userId == CurrentUser.Id) books.Add(book);
            }
            return books;
        }
        public void getBook(Book book)
        {
            if (book.userId == Guid.Empty)
            {
                book.userId = CurrentUser.Id;
                booksDao.Save(Books);
            }
        }
        public void returnBook(Book book)
        {
            if (book.userId == CurrentUser.Id)
            {
                book.userId = Guid.Empty;
                booksDao.Save(Books);
            }
        }
        public void pressLike(Book book)
        {
            foreach (Guid userId in book.likedBy)
            {
                if (userId == CurrentUser.Id) return;
            }
            book.likedBy.Add(CurrentUser.Id);
            booksDao.Save(Books);
        }
        public void removeLike(Book book)
        {
            for(int i = 0; i < book.likedBy.Count; i++)
            {
                if (book.likedBy[i] == CurrentUser.Id)
                {
                    book.likedBy.Remove(CurrentUser.Id);
                    booksDao.Save(Books);
                }
            }
        }
        public void SortBookName(Book[] books)
        {
            for(int i = 0; i < books.Length; i++)
            {
                for(int j = 0; j < books.Length - 1; j++)
                {
                    if (NeedToOrder(books[j].Name, books[j+1].Name))
                    {
                        Book temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }
        }
        public void SortAuthorName(Author[] authors)
        {
            for (int i = 0; i < authors.Length; i++)
            {
                for (int j = 0; j < authors.Length - 1; j++)
                {
                    if (NeedToOrder(authors[j].Name, authors[j + 1].Name))
                    {
                        Author temp = authors[j];
                        authors[j] = authors[j + 1];
                        authors[j + 1] = temp;
                    }
                }
            }
        }
        public void SortGenreName(Genre[] genres)
        {
            for (int i = 0; i < genres.Length; i++)
            {
                for (int j = 0; j < genres.Length - 1; j++)
                {
                    if (NeedToOrder(genres[j].Name, genres[j + 1].Name))
                    {
                        Genre temp = genres[j];
                        genres[j] = genres[j + 1];
                        genres[j + 1] = temp;
                    }
                }
            }
        }
        private bool NeedToOrder(string str1, string str2)
        {
            for(int i = 0; i < (str1.Length < str2.Length ? str1.Length : str2.Length); i++)
            {
                if (str1.ToCharArray()[i] < str2.ToCharArray()[i]) return false;
                if (str1.ToCharArray()[i] > str2.ToCharArray()[i]) return true;
            }
            return false;
        }

        private Author GetAuthor(string authorName)
        {
            foreach (Author a in Authors)
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
        private void deleteAutor(Guid authorId)
        {
            int counter = 0;
            foreach(Book book in Books)
            {
                if (book.Author.Id == authorId)
                {
                    counter++;
                }
            }
            if(counter == 0)
            {
                foreach(Author author in Authors)
                {
                    if(author.Id == authorId)
                    {
                        Authors.Remove(author);
                        authorsDao.Save(Authors);
                        break;
                    }
                }
            }
        }
        private void deleteGenre(Guid genreId)
        {
            int counter = 0;
            foreach (Book book in Books)
            {
                if (book.Genre.Id == genreId)
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                foreach (Genre genre in Genres)
                {
                    if (genre.Id == genreId)
                    {
                        Genres.Remove(genre);
                        genresDao.Save(Genres);
                        break;
                    }
                }
            }
        }
    }
}
