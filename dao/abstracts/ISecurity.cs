using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoNew.entity;

namespace ToDoNew.dao.abstracts
{
    interface ISecurity
    {
        public User Auth(User user);

        public User LogOut(User user);
        


    }
}
