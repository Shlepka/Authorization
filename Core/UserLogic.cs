using Basics.Model;
using Basics.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Basics.Core
{
    public static class UserLogic
    {
        public static User FindUserByFirstName(List<User> users, string firstName) =>
            users.FirstOrDefault(user => user.FirstName == firstName);

        public static User Validate(List<User> users, string login, string password)
        {
            return users.FirstOrDefault(user => user.Login == login && user.Password == password);
                
        }
        public static void ValidateRole(User user, Window window)
        {
            if (user is not null)                                     // открываем окно, которое соответсвтует
            {
                switch (user.Role)
                {
                    case Role.Admin:
                        {
                            new AdminWindows().Show();
                            window.Close();
                        }
                        break;
                    case Role.Buyer:
                        {
                            new BuyerWindow().Show();
                            window.Close();
                        }
                        break;
                    case Role.Manager:
                        {
                            new ManagerWindow().Show();
                            window.Close();
                        }
                        break;
                }
            }
        }
    }
}

