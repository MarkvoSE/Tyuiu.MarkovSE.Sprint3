using Tyuiu.MarkovSE.Sprint3.Task4.V26.Lib;
namespace Tyuiu.MarkovSE.Sprint3.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startVale = -5;
            int stopValue = 5;

            double res = ds.Calculate(startVale, stopValue);

            double wait = -1.924;
            Assert.AreEqual(wait, res);
        }
    }
}