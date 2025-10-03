using System;
using Tyuiu.KuchukIA.Sprint2.Task2.V5.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                                   *");
        Console.WriteLine("* Задание #2                                                                                  *");
        Console.WriteLine("* Вариант #5                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет          *");
        Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        Console.WriteLine("Введите значение x:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение y:");
        int y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        bool res = ds.CheckDotInShadedArea(x, y);

        if (res)
        {
            Console.WriteLine("Данная точка находится в закрашенной области");
        }
        else
        {
            Console.WriteLine("Данная точка не находится в закрашенной области");
        }

        Console.ReadKey();


    }
}
