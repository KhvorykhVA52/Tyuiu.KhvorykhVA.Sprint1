using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhvorykhVA.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {

            double firstPart = x + Math.Exp(x);
            Console.WriteLine($"Первая часть: {firstPart}");
            double sinX5 = Math.Sin(Math.Pow(x, 5)); 
            double xCubed = Math.Pow(x, 3); 
            double threePowX = Math.Pow(3, x);
            double secondPart = (sinX5 + xCubed) / threePowX;
            Console.WriteLine($"sin(x^5): {sinX5}, x^3: {xCubed}, 3^x: {threePowX}");
            Console.WriteLine($"Вторая часть: {secondPart}");

            double thirdPart = Math.Pow(y, 5) / (5 * y);
            Console.WriteLine($"Третья часть: {thirdPart}");

            double z = firstPart + secondPart + thirdPart;
            Console.WriteLine($"Результат до округления: {z}");

            return Math.Round(z, 3);
        }
    }
}
