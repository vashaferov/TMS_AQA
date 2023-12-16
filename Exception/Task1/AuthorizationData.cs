using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Task1
{
    internal class AuthorizationData
    {
         string login;
         string password;

        public string Login
        {
            get => login;
            set => login = value;     
        }
        public string Password
        {
            get => password;
            set => password = value;
        }

        public static bool CheckData(string login, string password, string confirmPassword)
        {
            if (login.Length > 20 || login.Contains(" "))
            {
                throw new WrongLoginException("Поле Логин содержит больше 20 символов или в нем присутствуют пробелы!");
            }
            else if (password.Length > 20 || password.Contains(" ") || !CheckNumInPassword(password))
            {
                throw new WrongPasswordException("Длина пароля должна быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру!");
            }
            else if (confirmPassword != password)
            {
                throw new WrongPasswordException("Пароль не совпал!");
            }
            else
                return true;                    
        }

        private static bool CheckNumInPassword(string str)
        {
            bool flag = false;

            foreach (char s in str)
                if (Char.IsDigit(s))
                {
                    flag = true;
                    break;
                }
                    
            return flag;
        }
    }
}
