using Tyuiu.KuchukIA.Sprint2.Task1.V5.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                                   *");
        Console.WriteLine("* Задание #1                                                                                  *");
        Console.WriteLine("* Вариант #5                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно    *");
        Console.WriteLine("* чередовать, но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^,*");
        Console.WriteLine("* последовательность операций не должна нарушаться), а также арифметических выражений,        *");
        Console.WriteLine("* которая вернет: (True, False, False, False, True, False),                                   *");
        Console.WriteLine("* при a = 154, b = 163, c = 134, d = 137                                                      *");



        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");

        int a = 154;
        int b = 163;
        int c = 134;
        int d = 137;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);



        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        bool[] res = ds.GetLogicOperations(a, b, c, d);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();

    }
}
