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
            LabelTaskName = new Label();
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
            // LabelTaskName
            // 
            LabelTaskName.AutoSize = true;
            LabelTaskName.Location = new Point(118, 21);
            LabelTaskName.Name = "LabelTaskName";
            LabelTaskName.Size = new Size(38, 15);
            LabelTaskName.TabIndex = 2;
            LabelTaskName.Text = "label1";
            // 
            // CurrentTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(LabelTaskName);
            Controls.Add(TaskName);
            Name = "CurrentTask";
            Size = new Size(410, 95);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TaskName;
        private Label LabelTaskName;
    }
}
