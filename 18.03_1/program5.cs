using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03_1
{
    internal class program5
    {
        static void Main()
        {
            Console.Write("Введите дату в формате ДД.ММ.ГГГГ (например, 22.12.2021): ");
            string inputDate = Console.ReadLine();

            if (!DateTime.TryParseExact(inputDate, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                Console.WriteLine("Ошибка: Введите дату в формате ДД.ММ.ГГГГ!");
                return;
            }

            string dayOfWeek = GetRussianDayOfWeek(date.DayOfWeek);

            string season = GetSeason(date);

            Console.WriteLine($"{season} {dayOfWeek}");
        }

        static string GetSeason(DateTime date)
        {
            int month = date.Month;
            int day = date.Day;

            if ((month == 12 && day >= 1) || month == 1 || month == 2)
                return "Winter";
            else if ((month == 3 && day >= 1) || month == 4 || month == 5)
                return "Spring";
            else if ((month == 6 && day >= 1) || month == 7 || month == 8)
                return "Summer";
            else
                return "Autumn";
        }

        static string GetRussianDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday: return "Понедельник";
                case DayOfWeek.Tuesday: return "Вторник";
                case DayOfWeek.Wednesday: return "Среда";
                case DayOfWeek.Thursday: return "Четверг";
                case DayOfWeek.Friday: return "Пятница";
                case DayOfWeek.Saturday: return "Суббота";
                case DayOfWeek.Sunday: return "Воскресенье";
                default: return "Неизвестный день";
            }
        }
    }
}
