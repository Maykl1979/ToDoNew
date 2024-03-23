using ToDoNew.dao.impl;
using ToDoNew.entity;

namespace ToDoNew
{
    public partial class Authoriz : Form
    {
        public Authoriz()
        {
            InitializeComponent();
            TextBoxPassword.PasswordChar = '*';
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
        {

            User user = new User(0, "", textBoxLogin.Text, TextBoxPassword.Text);
            try
            {
                buttonEntrance.BackColor = Color.Cornsilk;
                user = new BaseSecurity().Auth(user);
                FormTack formTack = new FormTack();
                this.Hide();
                formTack.ShowDialog();
                buttonEntrance.BackColor = Color.Coral;
                this.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Не верные данные", "Ошибка");

            }
        }
    }
}