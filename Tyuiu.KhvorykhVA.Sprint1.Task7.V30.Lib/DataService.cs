
using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.KhvorykhVA.Sprint1.Task7.V30
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {
            double z = x + Math.Exp(x) +
                       (Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3)) / Math.Pow(3, x) +
                       Math.Pow(y, 4) / 5;

            return Math.Round(z, 3);
        }
    }
}

