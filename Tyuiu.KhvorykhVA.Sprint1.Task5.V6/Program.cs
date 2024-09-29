using System;
using Tyuiu.KhvorykhVA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите день года (от 1 до 365):");
            int k = Convert.ToInt32(Console.ReadLine());

            if (k < 1 || k > 365)
            {
                Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 365.");
                return;
            }

            int res = ds.Calculate(k);

            string dayOfWeek = res switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => "Некорректный день"
            };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"День недели для {k}-го дня года: {dayOfWeek}");

            Console.ReadKey();
        }
    }
}
