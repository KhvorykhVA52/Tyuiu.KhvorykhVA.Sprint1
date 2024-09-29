using System;
using Tyuiu.KhvorykhVA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDayOfWeekCalculation()
        {
            int k = 15;
            DataService ds = new DataService();
            int result = ds.Calculate(k);

            int expected = 1;
            Assert.AreEqual(expected, result);
        }
    }
}
