using Tyuiu.KhvorykhVA.Sprint1.Task7.V30.Lib;
namespace Tyuiu.KhvorykhVA.Sprint1.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            // Заголовок программы
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                   5   3          4    ");
            Console.WriteLine("              sinx + x +         y     ");
            Console.WriteLine("               -------------  + ----   ");
            Console.WriteLine(" z = x + e^x +      3^x           5       ");


            Console.WriteLine("Введите значение: X");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение: Y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.Calculate(x, y));
        }
    }
}
