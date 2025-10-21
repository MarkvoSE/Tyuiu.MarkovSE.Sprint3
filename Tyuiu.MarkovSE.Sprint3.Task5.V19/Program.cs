using Tyuiu.MarkovSE.Sprint3.Task5.V19.Lib;
namespace Tyuiu.MarkovSE.Sprint3.Task5.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: МАРКОВ С.Е. | ИСПб-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #3                                                            *");
            Console.WriteLine("* Тема: Операторы составного присваивания                              *");
            Console.WriteLine("* Задание #5                                                           *");
            Console.WriteLine("* Вариант #19                                                          *");
            Console.WriteLine("* Выполнил МАРКОВ С.Е. | ИСПб-24-1                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Отсутствует                                                          *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("* Формула                                                              *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

            int x = 2;
            double result = dataService.GetSumSumSeries(x, 1, 1, 3, 6);

            Console.WriteLine($"Результат суммы: {result}");
            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}