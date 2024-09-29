using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhvorykhVA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.KhvorykhVA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestDeleteMiddleLetter()
        {
            string input = "пример текста тествого слва";
            DataService ds = new DataService();
            string result = ds.DeleteMiddleLetter(input);
            string expected = "пример текста тествого слва";
            Assert.AreEqual(expected, result);
        }
    }
}
