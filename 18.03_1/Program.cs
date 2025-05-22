using System;

class Program1
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 100: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Ошибка: Введите корректное число!");
            return;
        }

        if (number < 1 || number > 100)
        {
            Console.WriteLine("Ошибка: Число должно быть в диапазоне от 1 до 100!");
            return;
        }

        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Fizz Buzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}