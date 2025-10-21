using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MarkovSE.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            // Проверка валидности входных данных
            if (startValue > stopValue)
            {
                throw new ArgumentException("Начальное значение не может быть больше конечного", nameof(startValue));
            }

            double product = 1.0;
            int k = startValue;

            // Используем цикл do...while как требуется в задании
            do
            {
                // Оригинальная формула: (a^k + 4)
                double term = Math.Pow(value, k) + 4;
                product *= term;
                k++;
            }
            while (k <= stopValue);

            // Умножаем на cos(a) - это общий множитель для всего произведения
            product *= Math.Cos(value);

            // Округляем результат до 3 знаков после запятой
            return Math.Round(product, 3);
        }
    }
}