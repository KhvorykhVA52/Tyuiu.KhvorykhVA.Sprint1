using System;
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

            double lengthCathetus1;
            Console.Write("Введите длину первого катета: ");
            lengthCathetus1 = Convert.ToDouble(Console.ReadLine());

            double lengthCathetus2;
            Console.Write("Введите длину второго катета: ");
            lengthCathetus2 = Convert.ToDouble(Console.ReadLine());

            double area = ds.TriangleArea(lengthCathetus1, lengthCathetus2);
            area = Math.Round(area, 3); 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Площадь прямоугольного треугольника = " + area);
            Console.ReadKey();
        }
    }
}







        







    







