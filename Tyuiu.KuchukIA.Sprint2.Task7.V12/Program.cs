using System;
using Tyuiu.KuchukIA.Sprint2.Task7.V12.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                                   *");
        Console.WriteLine("* Задание #7                                                                                  *");
        Console.WriteLine("* Вариант #12                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения)       *");
        Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.                *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        Console.WriteLine("Введите значение X:");
        double x = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Введите значение Y:");
        double y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        bool res = ds.CheckDotInShadedArea(x, y);

        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка НЕ находится в заштрихованной области");
        }

        Console.ReadKey();

    }
}
