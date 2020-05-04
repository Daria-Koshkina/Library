using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFramework.Models
{
    [Serializable]
    public class Admin: User
    {
        public Admin(string name, string login, int password)
        {
            Name = name;
            Login = login;
            Password = password;
            Id = Guid.NewGuid();
        }
    }
}
