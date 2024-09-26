using Tyuiu.KhvorykhVA.Sprint1.Task2.V24.Lib;
namespace Tyuiu.KhvorykhVA.Sprint1.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 3;
            var res = ds.CalculateDiffSquare(x, y);
            Assert.AreEqual(9, res);
        }
    }
}