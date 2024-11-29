using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhvorykhVA.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {


            double z = x + Math.Exp(x) + (Math.Pow(x, 3) + Math.Sin(Math.Pow(x, 5))) / Math.Pow(3, x) + Math.Pow(y, 5) / Math.Pow(5, y);

            double zR = Math.Round(z, 3);


            return zR;





        }
    }
}