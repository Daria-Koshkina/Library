using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project.Models
{
    abstract class User
    {
        public string Name { set; get; }
        public string Login { protected set; get; }
        public int Password { protected set; get; }
        public Guid Id { protected set; get; }
    }
}
