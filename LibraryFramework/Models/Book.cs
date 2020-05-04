using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFramework.Models
{
    [Serializable]
    public class Book
    {
        public string Name { set; get; }
        public Author Author { set; get; }
        public Genre Genre { set; get; }
        public int Year { set; get; }
        public string Annotation { set; get; }
        public Guid Id { private set; get;}
        public Guid userId;
        public List<Guid> likedBy;
        public Book (string name, Author author, Genre genre, int year, string annotation)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
            Annotation = annotation;
            Id = Guid.NewGuid();
            userId = Guid.Empty;
            likedBy = new List<Guid>();
        }

    }
}
