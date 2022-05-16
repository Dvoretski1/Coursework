using System.Windows;
using System.Windows.Media;

namespace Coursework.Views.Windows
{
   
    public partial class RegistrationWindows : Window
    {
        public RegistrationWindows()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string Name = TextBoxName.Text.Trim();
            string Login = TextBoxLogin.Text.Trim();
            string Password = TextBoxPassword.Password.Trim();
            string PasswordRepeat = TextBoxPasswordRepeat.Password.Trim();
            string Email = TextBoxEmail.Text.Trim().ToLower();

            if (Name.Length < 3)
            {
                TextBoxName.ToolTip = "Имя введено не корректно";
                TextBoxName.Background = Brushes.LightCoral;
            }
            else if (Login.Length < 8)
            {
                TextBoxLogin.ToolTip = "Логин введен не корректно";
                TextBoxLogin.Background = Brushes.LightCoral;
            }
            else if (Password.Length < 8)
            {
                TextBoxPassword.ToolTip = "Пароль введен не корректно";
                TextBoxPassword.Background = Brushes.LightCoral;
            }
            else if (Password != PasswordRepeat)
            {
                TextBoxPasswordRepeat.ToolTip = "Пароль не совпадает";
                TextBoxPasswordRepeat.Background = Brushes.LightCoral;
            }
            else if (Email.Length < 8 || !Email.Contains("@") || !Email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Email введен не корректно";
                TextBoxEmail.Background = Brushes.LightCoral;
            }
            else
            {
                TextBoxName.ToolTip = "";
                TextBoxName.Background = Brushes.Transparent;
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxPassword.ToolTip = "";
                TextBoxPassword.Background = Brushes.Transparent;
                TextBoxPasswordRepeat.ToolTip = "";
                TextBoxPasswordRepeat.Background = Brushes.Transparent;
                TextBoxEmail.ToolTip = "";
                TextBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Вы успешно зарегистрировались");
            }
        }

        private void Button_Windows_Log_Click(object sender, RoutedEventArgs e)
        {
            LoginWindows loginWindows = new LoginWindows();
            loginWindows.Show();
            this.Hide();
        }
    }
}
