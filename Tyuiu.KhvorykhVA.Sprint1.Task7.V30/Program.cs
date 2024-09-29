using System;
using Tyuiu.KhvorykhVA.Sprint1.Task7.V30.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                   5   3          5    ");
            Console.WriteLine("              sinx + x +         y     ");
            Console.WriteLine("               -------------  + ----   ");
            Console.WriteLine(" z = x + e^x +      3^x           5y      ");

            double x, y;

            Console.WriteLine("Введите значение: X");
            x = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Введите значение: Y");
            y = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}