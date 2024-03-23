using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoNew
{
    public partial class CurrentTask : UserControl
    {
        public CurrentTask(string text)
        {
            InitializeComponent();
            TaskName.Text = text;
        }
                
        private void CurrentTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TaskName.Text);
        }
    }
}
