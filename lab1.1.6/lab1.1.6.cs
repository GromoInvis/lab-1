using System;

namespace TrigonometrySolver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Оголосіть змінні для c, a, b і n.
            double c, a, b, n;

            // Запросіть користувача ввести значення c, a, b і n.
            Console.WriteLine("Введіть значення c:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть значення a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть значення b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть значення n:");
            n = Convert.ToDouble(Console.ReadLine());

            // Розв'яжіть рівняння.
            double y = (a - 2)/(2 * a + b) + (Math.Sin(3 * a)/(Math.Cos(b)));

            // Виведіть результат.
            Console.WriteLine("Рішення рівняння: y = " + y);
        }
    }
}
