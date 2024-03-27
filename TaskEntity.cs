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
using ToDoNew.entity;

namespace ToDoNew
{
    public partial class FormTack : Form
    {
        private User AuthUser = BaseSecurity.GetAuthUser();
        private ITaskDao taskDao;
        public FormTack()
        {
            InitializeComponent();
            taskDao = new TaskDataBase();
            TaskEntity taskEntity = new TaskEntity();
            taskEntity.user_id = AuthUser.Id;
            List<TaskEntity> tasks = taskDao.FindTask(taskEntity);
            foreach (TaskEntity taskNew in tasks)
            {
                flowLayoutPanel1.Controls.Add(new CurrentTask(taskNew.id, taskNew.name, taskNew.status, taskNew.TimeStart, taskNew.TimeStop));
            }
        }


        private void FormTack_Load(object sender, EventArgs e)
        {

        }

        private void FormTack_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TaskEntity task = new TaskEntity();
            task.user_id = AuthUser.Id;
            task.name = TaskName.Text;
            task.status = Status.Text;
            task.TimeStart = TimeStart.Value;
            task.TimeStop = TimeEnd.Value;

            try
            {
                taskDao.SeveTask(task);
                flowLayoutPanel1.Controls.Add(new CurrentTask(task.id, task.name, task.status, task.TimeStart, task.TimeStop));
                MessageBox.Show("ОК");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
