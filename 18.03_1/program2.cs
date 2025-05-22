using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03_1
{
    internal class program2
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            string inputValue = Console.ReadLine();

            Console.Write("Введите процент: ");
            string inputPercent = Console.ReadLine();

            if (!double.TryParse(inputValue, out double value) ||
                !double.TryParse(inputPercent, out double percent))
            {
                Console.WriteLine("Ошибка: Введите корректные числа!");
                return;
            }

            double result = (value * percent) / 100;

            Console.WriteLine($"{percent}% от {value} = {result}");
        }
    }
}
