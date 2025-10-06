using System;
using Tyuiu.KuchukIA.Sprint2.Task6.V1.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                                   *");
        Console.WriteLine("* Задание #6                                                                                  *");
        Console.WriteLine("* Вариант #1                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* По данному номеру месяца, определите количество дней в этом месяце.                         *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        Console.WriteLine("Введите номер месяца:");
        int num = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        if ((num < 1) || (num > 12))
        {
            Console.WriteLine("Введено неверное значение");
        }

        else
        {
            Console.WriteLine("Кол-во дней в этом месяце: " + ds.FindMonthDaysCount(num));
        }

            Console.ReadKey();

    }
}
