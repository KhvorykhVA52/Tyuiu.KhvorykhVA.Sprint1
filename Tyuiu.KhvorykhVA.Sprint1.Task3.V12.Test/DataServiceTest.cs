using Tyuiu.KhvorykhVA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 6;
            double expected = 12; 
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(expected, res);
        }
    }
}
