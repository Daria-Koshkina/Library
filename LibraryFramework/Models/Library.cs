﻿using Course_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFramework.Models

{
    public class Library
    {
        public List<Admin> Admins { private set; get; }
        public List<Guest> Guests { private set; get; }
        public List<Book> Books { private set; get; }
        public List<Genre> Genres { private set; get; }
        public List<Author> Authors { private set; get; }
        public User CurrentUser { private set; get; }

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

        public void FillDataTest(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                AddBook($"Book{i}", $"Author{i}", $"Genre{i}", 100 * i, "Good book!");
            }
        }

        public bool Register(string name, string login, string password, bool isAdmin)
        {
            int passwordHash = password.GetHashCode();
            if (IsInList(login))
            {
                // A user with this login already exists.
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
