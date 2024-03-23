using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoNew.entity;

namespace ToDoNew.dao.abstracts
{
    interface ITaskDao
    {
        void SeveTask(TaskEntity task);
        TaskEntity FindTask(string description);
        TaskEntity UpdateTaskr(TaskEntity task);
        void DeliteTask(TaskEntity task);
    }
}
