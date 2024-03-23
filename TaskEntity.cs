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
            for (int i = 1; i < 11; i++)
            {
                flowLayoutPanel1.Controls.Add(new CurrentTask("Задача" + i.ToString()));

            }
            taskDao = new TaskDataBase();
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
            TaskEntity Task = new TaskEntity();
        }
    }
}
