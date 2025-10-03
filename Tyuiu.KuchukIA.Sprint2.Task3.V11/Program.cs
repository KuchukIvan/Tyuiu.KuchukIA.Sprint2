using System;
using Tyuiu.KuchukIA.Sprint2.Task3.V11.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                                   *");
        Console.WriteLine("* Задание #3                                                                                  *");
        Console.WriteLine("* Вариант #11                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием         *");
        Console.WriteLine("* вложенных оператор if-else, где пользователь вводит значение переменной X с клавиатуры.     *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());




        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        double res = ds.Calculate(x);
        Console.WriteLine("y = " + res);

        Console.ReadKey();


    }
}
