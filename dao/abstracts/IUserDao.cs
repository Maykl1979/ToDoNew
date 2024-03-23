using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoNew.entity;


namespace ToDoNew.dao.abstracts
{
    interface IUserDao
    {
        User SeveUser(User user);
        User FindUser(int id);
        User UpdateUser(User user);
        User DeliteUser(int id);

    }
}
