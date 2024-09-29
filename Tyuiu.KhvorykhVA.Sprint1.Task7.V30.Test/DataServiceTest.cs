using Tyuiu.KhvorykhVA.Sprint1.Task7.V30.Lib;
namespace Tyuiu.KhvorykhVA.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double expected = ds.Calculate(x, y);
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result, 0.001); 
        }
    }
}