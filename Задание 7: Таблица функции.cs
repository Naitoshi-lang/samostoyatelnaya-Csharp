using System;

public class SineTable
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Таблица функции a * sin(x):");
        Console.WriteLine("-------------------------");
        Console.WriteLine("|  a  |  x  | a * sin(x) |");
        Console.WriteLine("-------------------------");

        // Перебираем пары значений a и x
        for (int a = 1, x = 1; a <= 10; a++, x++)
        {
            // Вычисляем a * sin(x)
            double result = a * Math.Sin(x);

            // Выводим строку таблицы, форматируя вывод для выравнивания
            Console.WriteLine($"| {a,3} | {x,3} | {result,10:F2} |"); // {a,3} - выравнивание по правому краю, ширина 3; {result,10:F2} - выравнивание по правому краю, ширина 10, 2 знака после запятой
        }

        Console.WriteLine("-------------------------");
    }
}
