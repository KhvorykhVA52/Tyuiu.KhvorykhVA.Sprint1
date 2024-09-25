using Tyuiu.KhvorykhVA.Sprint1.Task1.V30.Lib;
namespace Tyuiu.KhvorykhVA.Sprint1.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(-2, res);

        }
    }
}