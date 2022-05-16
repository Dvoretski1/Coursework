using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Coursework.Views.Windows
{
    public partial class LoginWindows : Window
    {
        public LoginWindows()
        {
            InitializeComponent();
        }

        private void Button_Log_Click(object sender, RoutedEventArgs e)
        {
            string Name = TextBoxName.Text.Trim();
            string Login = TextBoxLogin.Text.Trim(); 
            string Password = TextBoxPassword.Password.Trim();

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
            else
            {
                TextBoxName.ToolTip = "";
                TextBoxName.Background = Brushes.Transparent;
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxPassword.ToolTip = "";
                TextBoxPassword.Background = Brushes.Transparent;

                MessageBox.Show("Вы успешно Вошли в аккаунт");
            }
        }

        private void Button_Windows_Reg_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindows registrationWindows = new RegistrationWindows();
            registrationWindows.Show();
            this.Hide();
        }
    }
}
