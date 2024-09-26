using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhvorykhVA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите длину первого катета (a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго катета (b): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double area = (a * b) / 2;
            area = Math.Round(area, 3);
            Console.WriteLine("Площадь прямоугольного треугольника = " + area);

            Console.ReadKey();






        }







    }







}