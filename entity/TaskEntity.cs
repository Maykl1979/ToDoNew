using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoNew.entity
{
    internal class TaskEntity
    {
        private long Id;
        private long User_ID;
        private string Name;
        private string Status;
        private DateTime Time_Start;
        private DateTime Time_Stop;

        public TaskEntity()
        {

        }

        public TaskEntity(long Id, long User_ID, string Name, string Status, DateTime Time_Start, DateTime Time_Stop)
        {
            this.Id = Id;
            this.User_ID = User_ID;
            this.Name = Name;
            this.Status = Status;
            this.Time_Start = Time_Start;
            this.Time_Stop = Time_Stop;
        }

        public long id {
            set { this.Id = value; }
            get { return this.Id; }
        }

        public long user_id { 
            set { this.User_ID = value; }
            get { return this.User_ID; }
        }
        public string name
        {
            set { this.Name = value; }
            get { return this.Name; }
        }
        public string status
        {
            set { this.Status = value; }
            get { return this.Status; }
        }
        public DateTime TimeStart
        {
            set { this.Time_Start = value; }
            get { return this.Time_Start; }
        }
        public DateTime TimeStop
        {
            set { this.Time_Stop = value; }
            get { return this.Time_Stop; }
        }
    }
}
