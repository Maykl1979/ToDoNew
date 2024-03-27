namespace ToDoNew
{
    partial class CurrentTask
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            TaskName = new Label();
            SuspendLayout();
            // 
            // TaskName
            // 
            TaskName.AutoSize = true;
            TaskName.Location = new Point(13, 21);
            TaskName.Name = "TaskName";
            TaskName.Size = new Size(99, 15);
            TaskName.TabIndex = 1;
            TaskName.Text = "Название задачи";
            // 
            // CurrentTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(TaskName);
            Name = "CurrentTask";
            Size = new Size(171, 95);
            //Click += CurrentTask_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TaskName;
    }
}
