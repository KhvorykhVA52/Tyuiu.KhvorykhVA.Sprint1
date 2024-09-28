
using Tyuiu.KhvorykhVA.Sprint1.Task4.V18.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1; 
            double y = 2; 
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res, 0.001); 
        }
    }
}
