using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorizationLibrary
{
    public static class AutorizationClass
    {
        public static bool Autorization = false;

        public static string Check(string login,string password,string trueLogin,string truePassword)
        {
            if(login.Length < 6)
            {
                return "Логин должен состоять минимум из 6 символов";
            }
            else
            {
                if(login == trueLogin)
                {
                    if (password.Length < 6)
                    {
                        return "Пароль должен состоять минимум из 6 символов";
                    }
                    else
                    {
                        if (password == truePassword)
                        {
                            return "Выполняется вход";
                        }
                        else
                        {
                            return "Неправильный пароль";
                        }
                    }
                }
                else
                {
                    return "Неправильный логин";
                }
            }
            
        }
    }
}
