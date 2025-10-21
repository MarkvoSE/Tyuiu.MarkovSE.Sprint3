using tyuiu.cources.programming.interfaces.Sprint3;
using System;

namespace Tyuiu.MarkovSE.Sprint3.Task2.V24.Lib
{
    public class DataService
    {
        /// <summary>
        /// Вычисляет произведение ряда по формуле: p = ∏(a^k + k) для k от startValue до stopValue
        /// </summary>
        /// <param name="value">Значение параметра a</param>
        /// <param name="startValue">Начальное значение k</param>
        /// <param name="stopValue">Конечное значение k</param>
        /// <returns>Результат вычисления произведения ряда</returns>
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            // Проверка валидности входных данных
            if (startValue > stopValue)
            {
                throw new ArgumentException("startValue не может быть больше stopValue");
            }

            double product = 1.0;
            int k = startValue;

            // Используем цикл do...while как требуется в задании
            do
            {
                // Формула: (a^k + k)
                double term = Math.Pow(value, k) + k;
                product *= term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 3); // Округляем до 3 знаков после запятой как в тесте
        }
    }
}