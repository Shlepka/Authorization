using Basics.Model;
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
using Basics.Core;
using Basics.View;



namespace Basics.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    ///  Автор-Лавинский Степан)
    public partial class AuthorizationWindow : Window
    {
        private List<User> _users;   // создаем список, который будет хранить юзеров
        public AuthorizationWindow()
        {
            InitializeComponent();

            _users = UserParser.ParseFile("users1.txt").ToList();
        }




        private void bthSignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbLogin.Text == string.Empty || tbPassword.Password == string.Empty)
                {
                    throw new Exception("Введите логин или пароль!");
                }

                if (UserLogic.Validate(tbLogin.Text, tbPassword.Password))
                {
                    new AdminWindows().Show();
                    Close();
                }
                else
                {
                    throw new Exception("Неверный логин или пароль!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }

   
}