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
            _users = new List<User>()
            {
                new User("firtsname","middle","last","log","pass","email","a",Role.Admin),
                new User()
                {
                    FirstName="Stepan",                // Вводим данные о пользователях
                    MidleName="Lavinsky",
                    LastName="Olegovich",
                    Email="lavinsky2004@gmail.com",
                    Login="admin",
                    Password="admin",
                    Phone="+89182202216",
                    Role=Role.Admin
                },
                new User()
                {
                    FirstName="Vitalii",
                    MidleName="Kulbed",
                    LastName="Yorivich",
                    Email="dedinsade282@gmail.com",
                    Login="buyer",
                    Password="buyer",
                    Phone="+88005535355",
                    Role=Role.Buyer
                },
                new User()
                {
                    FirstName="Dima",
                    MidleName="Lilia",
                    LastName="----",
                    Email="dyrak@maii.ru",
                    Login="manager",
                    Password="manager",
                    Phone="+89189891129",
                    Role=Role.Manager
                }
            };
            var user = UserLogic.FindUserByFirstName(_users, "firstnsme");
            

        }




        private void bthSignIn_Click(object sender, RoutedEventArgs e)
        {
            var user = UserLogic.Validate(_users, tbLogin.Text, tbPassword.Password);
            if (user is not null)
            {
                UserLogic.ValidateRole(user, this);
            }
            else
            {
                MessageBox.Show("Вас нет в системе", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);    // ошибка при вводе неккоректных данных
            }
        }
    }

   
}