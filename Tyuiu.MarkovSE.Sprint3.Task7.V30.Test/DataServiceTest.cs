using Tyuiu.MarkovSE.Sprint3.Task7.V30.Lib;
namespace Tyuiu.MarkovSE.Sprint3.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -12.22;
            valueWaitArray[1] = -8.72;
            valueWaitArray[2] = -5.34;
            valueWaitArray[3] = 0.29;
            valueWaitArray[4] = 6.47;
            valueWaitArray[5] = 8.25;
            valueWaitArray[6] = 10.16;
            valueWaitArray[7] = 13.73;
            valueWaitArray[8] = 20.84;
            valueWaitArray[9] = 36.14;
            valueWaitArray[10] = 48.02;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
        }
    }
}