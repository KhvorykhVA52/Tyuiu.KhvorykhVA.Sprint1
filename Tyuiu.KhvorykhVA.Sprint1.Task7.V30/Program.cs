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
            Console.WriteLine(" z = x + e^x +      3^x           5y   ");
            Console.WriteLine("***************************************************************************");

            double x = GetUserInput("Введите значение X: ");
            double y = GetUserInput("Введите значение Y: ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Значение X: {x}, Значение Y: {y}");
            Console.WriteLine($"Результат вычисления: {ds.Calculate(x, y)}");
        }

        static double GetUserInput(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out value))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите корректное число.");
                }
            }
            return value;
        }
    }
}




