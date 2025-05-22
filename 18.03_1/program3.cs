using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03_1
{
    internal class program3
    {
        static void Main()
        {
            Console.WriteLine("Введите четыре цифры (каждая от 0 до 9):");

            Console.Write("Первая цифра: ");
            string input1 = Console.ReadLine();

            Console.Write("Вторая цифра: ");
            string input2 = Console.ReadLine();

            Console.Write("Третья цифра: ");
            string input3 = Console.ReadLine();

            Console.Write("Четвертая цифра: ");
            string input4 = Console.ReadLine();

            if (!int.TryParse(input1, out int digit1) ||
                !int.TryParse(input2, out int digit2) ||
                !int.TryParse(input3, out int digit3) ||
                !int.TryParse(input4, out int digit4))
            {
                Console.WriteLine("Ошибка: Введите корректные цифры!");
                return;
            }

            if (digit1 < 0 || digit1 > 9 ||
                digit2 < 0 || digit2 > 9 ||
                digit3 < 0 || digit3 > 9 ||
                digit4 < 0 || digit4 > 9)
            {
                Console.WriteLine("Ошибка: Каждая цифра должна быть в диапазоне от 0 до 9!");
                return;
            }

            int result = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

            Console.WriteLine($"Сформированное число: {result}");
        }
    }
}
