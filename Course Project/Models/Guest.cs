using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project.Models
{
    [Serializable]
    class Guest : User
    {
        public Guest(string name, string login, int password)
        {
            Name = name;
            Login = login;
            Password = password;
            Id = Guid.NewGuid();
        }
    }
}
