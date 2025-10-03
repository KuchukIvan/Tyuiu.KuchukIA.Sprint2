using System;
using Tyuiu.KuchukIA.Sprint2.Task4.V16.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                                   *");
        Console.WriteLine("* Задание #4                                                                                  *");
        Console.WriteLine("* Вариант #16                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием                   *");
        Console.WriteLine("* тернарного оператора.                                                                       *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Введите значение x:");
        double y = Convert.ToDouble(Console.ReadLine());




        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        double res = ds.Calculate(x, y);
        Console.WriteLine("y = " + res);

        Console.ReadKey();


    }
}
