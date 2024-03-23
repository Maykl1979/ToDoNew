using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoNew.entity
{
    internal class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

         public User(long Id, string Name, string Login, string Password)
        {
            this.Id = Id;
            this.Name = Name;
            this.Login = Login;
            this.Password = Password;
        }
    }
}
