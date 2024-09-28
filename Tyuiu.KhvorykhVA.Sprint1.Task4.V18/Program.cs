using System;
using Tyuiu.KhvorykhVA.Sprint1.Task4.V18.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            Console.Write("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.Write("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);
            result = Math.Round(result, 3); 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
    }
}
