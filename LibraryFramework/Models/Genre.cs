using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFramework.Models
{
    [Serializable]
    public class Genre
    {
        public string Name { set; get; }
        public Guid Id { private set; get; }
        public Genre(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
    }
}
