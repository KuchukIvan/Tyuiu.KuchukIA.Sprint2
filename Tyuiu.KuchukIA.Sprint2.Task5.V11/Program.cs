using System;
using Tyuiu.KuchukIA.Sprint2.Task5.V11.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                                   *");
        Console.WriteLine("* Задание #5                                                                                  *");
        Console.WriteLine("* Вариант #11                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* По заданным g, n и m определить дату следующего дня.                                        *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        Console.WriteLine("Введите число:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите месяц:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год:");
        int g = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        if (g <= 0 || m <= 0 || m > 12 || n > 31 || n <= 0)
        {
            Console.WriteLine("Введены некорректные данные. Дату следующего дня вычислить невозможно.");
        }
        else
        {
            Console.WriteLine("Дата следующего дня" + ds.FindDateOfNextDay(g, m, n));
        }

        Console.ReadKey();

    }
}
