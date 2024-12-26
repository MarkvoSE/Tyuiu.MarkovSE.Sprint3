using Tyuiu.MarkovSE.Sprint3.Task4.V26.Lib;
namespace Tyuiu.MarkovSE.Sprint3.Task4.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Марков. С. Е. | ИСПб-24-2";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #3                                                            *");
            Console.WriteLine("* Тема:                                                                *");
            Console.WriteLine("* Задание #4                                                           *");
            Console.WriteLine("* Вариант #26                                                          *");
            Console.WriteLine("* Выполнил: Марков С.Е.  | ИСПб-24-2                                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("startValue =" + startValue);

            Console.WriteLine("stopValue =" + stopValue);


            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Ответ = " + ds.Calculate(startValue, stopValue));
            Console.ReadLine();
        }
    }
}