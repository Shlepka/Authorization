using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basics.Core;
using Basics.View;



namespace Basics.Model
{
    public class User                             //что-то непонятное
                                                 // узнать подробнее
    {
        public string FirstName { get; set; }
        public string MidleName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Role Role { get; set; }
        public User()
        {
            FirstName = string.Empty;
            MidleName = string.Empty;
            LastName = string.Empty;
            Login = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Role = Role.Unknown;
        }

        public User(string firstName, string middleName, String lastName, string login, string password, string email,
            string phone, Role role)
        {
            FirstName = firstName;
            MidleName = middleName;
            LastName = lastName;
            Login = login;
            Password = password;
            Email = email;
            Phone = phone;
            Role = role;


        }
    } }
