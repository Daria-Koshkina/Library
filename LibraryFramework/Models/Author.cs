using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFramework.Models
{
    [Serializable]
    public class Author
    {
        public string Name { set; get; }
        public Guid Id { private set; get; }
        public Author(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
    }
}
