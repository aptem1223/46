using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // Перечисление для математических операций
    enum MathOperation
    {
        Сложение,
        Вычитание,
        Умножение,
        Деление,
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ввод двух вещественных чисел
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Ввод математической операции
            Console.WriteLine("Выберите операцию Сложение,Вычитание,Умножение,Деление,: ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, out MathOperation operation))
            {
                double result = Calculate(num1, num2, operation);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: Некорректная операция.");
            }
            Console.Read();
        }

        static double Calculate(double a, double b, MathOperation operation)
        {
            switch (operation)
            {
                case MathOperation.Сложение:
                    return a + b;
                case MathOperation.Вычитание:
                    return a - b;
                case MathOperation.Умножение:
                    return a * b;
                case MathOperation.Деление:
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка: Деление на ноль.");
                        return double.NaN;
                    }
                    return a / b;
                default:
                    throw new ArgumentException("Неизвестная операция");
            }
        }
    }
}
