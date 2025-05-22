using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03_1
{
    internal class program4
    {
        static void Main()
        {
            Console.Write("Введите шестизначное число: ");
            string inputNumber = Console.ReadLine();

            if (!int.TryParse(inputNumber, out int number) || inputNumber.Length != 6 || number < 100000 || number > 999999)
            {
                Console.WriteLine("Ошибка: Введите корректное шестизначное число!");
                return;
            }

            Console.Write("Введите номер первого разряда (1-6): ");
            string inputPos1 = Console.ReadLine();
            Console.Write("Введите номер второго разряда (1-6): ");
            string inputPos2 = Console.ReadLine();

            if (!int.TryParse(inputPos1, out int pos1) || !int.TryParse(inputPos2, out int pos2) ||
                pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6)
            {
                Console.WriteLine("Ошибка: Номера разрядов должны быть от 1 до 6!");
                return;
            }

            char[] digits = inputNumber.ToCharArray();

            char temp = digits[pos1 - 1];
            digits[pos1 - 1] = digits[pos2 - 1];
            digits[pos2 - 1] = temp;

            string result = new string(digits);

            Console.WriteLine($"Число после обмена цифр: {result}");
        }
    }
}
