using System;

public class GoodNumbers
{
    public static void Main(string[] args)
    {
        long start = 1;
        long end = 1000000000;

        DateTime startTime = DateTime.Now; // Записываем время начала выполнения
        long goodNumberCount = CountGoodNumbers(start, end); // Вызываем функцию для подсчета хороших чисел
        DateTime endTime = DateTime.Now; // Записываем время окончания выполнения

        TimeSpan duration = endTime - startTime; // Вычисляем время выполнения

        Console.WriteLine($"Количество хороших чисел в диапазоне от {start} до {end}: {goodNumberCount}");
      
    }

    // Функция для подсчета суммы цифр числа
    public static int SumOfDigits(long number)
    {
        int sum = 0;
        string numberString = number.ToString(); // Преобразуем число в строку для удобства работы с цифрами

        foreach (char digitChar in numberString)
        {
            sum += int.Parse(digitChar.ToString()); // Преобразуем символ цифры в целое число и добавляем к сумме
        }

        return sum;
    }

    // Функция для проверки, является ли число "хорошим"
    public static bool IsGoodNumber(long number)
    {
        int sumOfDigits = SumOfDigits(number); // Вычисляем сумму цифр числа

        if (sumOfDigits == 0) // Если сумма цифр равна 0, число не может быть "хорошим"
        {
            return false;
        }

        return number % sumOfDigits == 0; // Проверяем, делится ли число на сумму своих цифр без остатка
    }

    // Функция для подсчета количества "хороших" чисел в диапазоне
    public static long CountGoodNumbers(long start, long end)
    {
        long count = 0; // Инициализируем счетчик "хороших" чисел

        for (long i = start; i <= end; i++) // Перебираем все числа в диапазоне
        {
            if (IsGoodNumber(i)) // Если число является "хорошим"
            {
                count++; // Увеличиваем счетчик
            }
        }

        return count; // Возвращаем общее количество "хороших" чисел
    }
}
