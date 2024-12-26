using Tyuiu.MarkovSE.Sprint3.Task2.V24.Lib;
namespace Tyuiu.MarkovSE.Sprint3.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 0.25;
            int st = 1;
            int end = 8;
            double wait = 3.876;
            double res = ds.GetMultiplySeries(a, st, end);
            Assert.AreEqual(wait, res);
        }
    }
}