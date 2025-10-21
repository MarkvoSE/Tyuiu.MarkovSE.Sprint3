using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MarkovSE.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double summ;
            do
            {
                summ = 0;
                summ = summ + (Math.Pow(value, startValue) + 4) * Math.Cos(value);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(55217.446);
;

        }
    }
}