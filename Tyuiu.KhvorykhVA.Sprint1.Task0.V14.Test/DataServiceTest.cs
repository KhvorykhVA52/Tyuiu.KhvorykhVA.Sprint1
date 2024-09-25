using Tyuiu.KhvorykhVA.Sprint1.Task0.V14.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(25, res);

        }
    }
}