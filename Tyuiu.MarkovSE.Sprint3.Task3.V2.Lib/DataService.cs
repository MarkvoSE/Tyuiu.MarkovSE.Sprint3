using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MarkovSE.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int currentCount = 0;
            int maxCount = 0;
            string str = "asdzzz vfvfzz v gthvz";

            foreach (char c in str)
            {
                if (c == 'z')
                {
                    currentCount++; // Увеличиваем счетчик при нахождении 'z'
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount; // Обновляем максимум, если текущий больше
                    }
                    currentCount = 0; // Сбрасываем счетчик для 'z'
                }
            }

            // Проверяем в конце, чтобы учесть случаи, когда строка заканчивается 'z'
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }

            return maxCount;
        }

    }
}