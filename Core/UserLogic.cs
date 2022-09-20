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
        public static User FindUserByFirstName(List<User> users, string FirstName) =>
               users.FirstOrDefault(user => user.FirstName == FirstName);

        public static bool Validate(string login, string password) =>
           login == "admin" && password == "admin";
    }
}

