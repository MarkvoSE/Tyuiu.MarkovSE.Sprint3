using Tyuiu.MarkovSE.Sprint3.Task3.V2.Lib;
namespace Tyuiu.MarkovSE.Sprint3.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: МАРКОВ С. Е. | ИСПб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: МАРКОВ С.Е. | ИСПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв z,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: asdzzz vfvfzz v gthvz        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "asdzzz vfvfzz v gthvz";
            char ch = 'z';

            Console.WriteLine("Исходная строка" + str);
            Console.WriteLine("Символ для подсчета" + ch);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество символов 'z' = " + ds.GetMaxCharCount(str, ch));



        }
    }
}