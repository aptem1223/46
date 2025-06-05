using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    enum UserRole
    {
        Администратор,
        Модератор,
        Пользователь,
        Гость,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу роль (Администратор,Модератор,Пользователь,Гость,):");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out UserRole role))  // true = игнор регистра
            {
                Console.WriteLine(GetRoleMessage(role));
            }
            else
            {
                Console.WriteLine("Ошибка: введена некорректная роль.");
            }
        }
        static string GetRoleMessage(UserRole role)
        {
            switch (role)
            {
                case UserRole.Администратор:
                    return "Вы зарегистрированы как администратор.";
                case UserRole.Модератор:
                    return "Вы зарегистрированы как модератор.";
                case UserRole.Пользователь:
                    return "Вы зарегистрированы как пользователь.";
                case UserRole.Гость:
                    return "Вы зарегистрированы как гость.";
                default:
                    return "Неизвестная роль.";
            }
        }
    }
}
