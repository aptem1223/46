using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        enum WeekDay
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Дни недели:");
                foreach (WeekDay day in Enum.GetValues(typeof(WeekDay)))
                {
                    Console.WriteLine($"{(int)day}. {day}");
                }
                WeekDay today = WeekDay.Wednesday;
                Console.WriteLine($"\nСегодня: {today} ({(int)today})");
                Console.Read();
            }
        }
}
