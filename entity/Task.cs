using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoNew.entity
{
    internal class TaskEntity
    {
        private long Id { get; set; }
        private long User_ID { get; set; }
        private string Name { get; set; }
        private string Status { get; set; }
        private DateTime Time_Start { get; set; }
        private DateTime Time_Stop { get; set; }

        public TaskEntity(long Id, long User_ID, string Name, string Status, DateTime Time_Start, DateTime Time_Stop)
        {
            this.Id = Id;
            this.User_ID = User_ID;
            this.Name = Name;
            this.Status = Status;
            this.Time_Start = Time_Start;
            this.Time_Stop = Time_Stop;
        }
    }
}
