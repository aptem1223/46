using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
        enum Post
        {
            Manager = 160,
            Developer = 170,
            Tester = 150,
            Designer = 155
        }
        class Accountant
        {
            
            public bool AskForBonus(Post worker, int hours)
            {
                int requiredHours = (int)worker;
                return hours > requiredHours;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите должность (Manager, Developer, Tester, Designer):");
                string inputRole = Console.ReadLine();
                if (!Enum.TryParse(inputRole, true, out Post post))
                {
                    Console.WriteLine("Ошибка: введена некорректная должность.");
                    return;
                }
                Console.Write("Введите количество отработанных часов: ");
                if (!int.TryParse(Console.ReadLine(), out int hours) || hours < 0)
                {
                    Console.WriteLine("Ошибка: введите корректное положительное число часов.");
                    return;
                }
                Accountant accountant = new Accountant();
                bool hasBonus = accountant.AskForBonus(post, hours);

                Console.WriteLine($"\nДолжность: {post}");
                Console.WriteLine($"Норма часов: {(int)post}");
                Console.WriteLine($"Отработано: {hours}");
                Console.WriteLine(hasBonus
                    ? "Премия положена!"
                    : "Премия не положена.");
            Console.Read();
            }   
        }
}
