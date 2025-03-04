using System;
using System.Collections.Generic;
using System.Linq;

public static class Message
{
    // Выводим только те слова сообщения, которые содержат не более n букв
    public static string GetWordsWithMaxLength(string message, int maxLength)
    {
        if (string.IsNullOrEmpty(message))
        {
            return ""; // Возвращаем пустую строку, если сообщение пустое
        }

        string[] words = message.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Разделяем сообщение на слова
        IEnumerable<string> filteredWords = words.Where(word => word.Length <= maxLength); // Фильтрация слов

        return string.Join(" ", filteredWords); // Соединяем отфильтрованные слова обратно в строку
    }

    // Удаляем из сообщения все слова, которые заканчиваются на заданный символ
    public static string RemoveWordsEndingWith(string message, char endingChar)
    {
        if (string.IsNullOrEmpty(message))
        {
            return ""; // Возвращаем пустую строку, если сообщение пустое
        }

        string[] words = message.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Разделяем сообщение на слова
        IEnumerable<string> filteredWords = words.Where(word => !word.ToLower().EndsWith(char.ToLower(endingChar))); // Фильтрация слов

        return string.Join(" ", filteredWords); // Соединяем отфильтрованные слова обратно в строку
    }

    // Находим самое длинное слово сообщения
    public static string GetLongestWord(string message)
    {
        if (string.IsNullOrEmpty(message))
        {
            return ""; // Возвращаем пустую строку, если сообщение пустое
        }

        string[] words = message.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Разделяем сообщение на слова.

        if (words.Length == 0)
        {
            return ""; // Возвращаем пустую строку, если в сообщении нет слов
        }
        string longestWord = words.OrderByDescending(word => word.Length).FirstOrDefault(); // фильтарция слов

        return longestWord; // Возвращаем самое длинное слово
    }
}

public class Program
{
 // Проверка 
    public static void Main(string[] args)
    {
        string message = "This is a sample message with some very long words.";

        // Пример использования MaxLength:
        string shortWords = Message.GetWordsWithMaxLength(message, 4);
        Console.WriteLine($"Слова длиной не более 4 символов: {shortWords}"); 

        // Пример использования EndingWith:
        string noSWords = Message.RemoveWordsEndingWith(message, 's');
        Console.WriteLine($"Сообщение без слов, оканчивающихся на 's': {noSWords}"); 

        // Пример использования LongestWord:
        string longestWord = Message.GetLongestWord(message);
        Console.WriteLine($"Самое длинное слово: {longestWord}"); 
    }
}
