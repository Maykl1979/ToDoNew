namespace ToDoNew
{
    partial class FormTack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            buttonSave = new Button();
            TimeEnd = new DateTimePicker();
            TimeStart = new DateTimePicker();
            Status = new ComboBox();
            TaskName = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonSave);
            splitContainer1.Panel1.Controls.Add(TimeEnd);
            splitContainer1.Panel1.Controls.Add(TimeStart);
            splitContainer1.Panel1.Controls.Add(Status);
            splitContainer1.Panel1.Controls.Add(TaskName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(574, 395);
            splitContainer1.SplitterDistance = 229;
            splitContainer1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(47, 254);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить,";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // TimeEnd
            // 
            TimeEnd.Location = new Point(12, 172);
            TimeEnd.Name = "TimeEnd";
            TimeEnd.Size = new Size(200, 23);
            TimeEnd.TabIndex = 4;
            // 
            // TimeStart
            // 
            TimeStart.Location = new Point(12, 116);
            TimeStart.Name = "TimeStart";
            TimeStart.Size = new Size(200, 23);
            TimeStart.TabIndex = 3;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Location = new Point(12, 73);
            Status.Name = "Status";
            Status.Size = new Size(200, 23);
            Status.TabIndex = 2;
            // 
            // TaskName
            // 
            TaskName.Location = new Point(12, 29);
            TaskName.Name = "TaskName";
            TaskName.Size = new Size(200, 23);
            TaskName.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(341, 395);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // FormTack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 395);
            Controls.Add(splitContainer1);
            Name = "FormTack";
            Text = "Список дел";
            FormClosed += FormTack_FormClosed;
            Load += FormTack_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonSave;
        private DateTimePicker TimeEnd;
        private DateTimePicker TimeStart;
        private ComboBox Status;
        private TextBox TaskName;
    }
}