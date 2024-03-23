using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoNew.dao.abstracts;
using ToDoNew.dao.impl;

namespace ToDoNew
{
    public partial class CurrentTask : UserControl
    {
        private long Id { get; set; }
        private ITaskDao taskDao;
        public CurrentTask(long id, string name, string status, DateTime timeStart, DateTime timeStop)
        {
            InitializeComponent();
            taskDao = new TaskDataBase();
        }
                
      
    }
}
