using Tyuiu.MarkovSE.Sprint3.Task3.V2.Lib;
namespace Tyuiu.MarkovSE.Sprint3.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "asdzzz vfvfzz v gthvz";
            char ch = 'z';
            int res = ds.GetMaxCharCount(str, ch);
            Assert.IsTrue(res == 3);
        }
    }
}