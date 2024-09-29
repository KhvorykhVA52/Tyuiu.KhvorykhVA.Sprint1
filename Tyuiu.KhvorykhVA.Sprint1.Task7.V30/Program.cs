using Tyuiu.KhvorykhVA.Sprint1.Task7.V30.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task7.V30
{
    

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

                double x = 1.7;
                double y = 2.1;  

                Console.WriteLine($"Значение X: {x}, Значение Y: {y}");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine(ds.Calculate(x, y));
            }
        }
    }

}
