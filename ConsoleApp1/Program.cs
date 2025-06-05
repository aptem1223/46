using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Month
    {
        Январь = 1,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Август,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Месяцы года:");
            foreach (Month month in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{(int)month}. {month}");
            }
            Month currentMonth = Month.Июнь;
            Console.WriteLine($"\nТекущий месяц: {currentMonth} ({(int)currentMonth})");
            Console.Read();
        }
    }
}
