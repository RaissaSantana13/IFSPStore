using IFSPStoreDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStoreDomain.Entity
{
    public class User : BaseEntity<int>
    {
        public User(int id, string name, string password, string login, string email, DateTime registrationDate, DateTime loginDate, bool actve) : base(id)
        {
            Name = name;
            Password = password;
            Login = login;
            Email = email;
            RegistrationDate = registrationDate;
            LoginDate = loginDate;
            Active = actve; 
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LoginDate { get; set; }
        public bool Active { get; set; }

    }
}
