using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhvorykhVA.Sprint1.Task7.V30.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            double firstPart = x + Math.Exp(x);

            double sinX5 = Math.Sin(Math.Pow(x, 5));
            double xCubed = Math.Pow(x, 3); 
            double threePowX = Math.Pow(3, x); 
            double secondPart = (sinX5 + xCubed) / threePowX;

            double thirdPart = Math.Pow(y, 5) / (5 * y);

            double z = firstPart + secondPart + thirdPart;


            return Math.Round(z, 3);
        }
    }
}