namespace ToDoNew
{
    partial class Authoriz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEntrance = new Button();
            textBoxLogin = new TextBox();
            TextBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonEntrance
            // 
            buttonEntrance.Location = new Point(35, 156);
            buttonEntrance.Name = "buttonEntrance";
            buttonEntrance.Size = new Size(110, 33);
            buttonEntrance.TabIndex = 0;
            buttonEntrance.Text = "Вход";
            buttonEntrance.UseVisualStyleBackColor = true;
            buttonEntrance.Click += buttonEntrance_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(35, 49);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(110, 23);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.Text = "Admin";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(35, 103);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(110, 23);
            TextBoxPassword.TabIndex = 2;
            TextBoxPassword.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 52);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 103);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // Authoriz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 257);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonEntrance);
            Name = "Authoriz";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrance;
        private TextBox textBoxLogin;
        private TextBox TextBoxPassword;
        private Label label1;
        private Label label2;
    }
}