using Tyuiu.KuchukIA.Sprint2.Task0.V2.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                                   *");
        Console.WriteLine("* Задание #0                                                                                  *");
        Console.WriteLine("* Вариант #2                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений, которая вернет         *");
        Console.WriteLine("* (False, True, False, True, False, True), при x = 123, y = 123                               *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");

        int x = 123;
        int y = 123;
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);



        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        bool[] res = ds.GetCompareOperations(x, y);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();

    }
}
