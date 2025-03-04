using System;
using System.Text.RegularExpressions;

public class LoginValidator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите логин для проверки:");
        string login = Console.ReadLine(); // Считываем ввод пользователя

        bool isValid = IsValidLogin(login); // Вызываем функцию для проверки логина

        if (isValid)
        {
            Console.WriteLine("Логин корректный."); // Выводим сообщение об успехе
        }
        else
        {
            Console.WriteLine("Логин некорректный."); // Выводим сообщение о неудаче
        }
    }

    // Функция для проверки корректности логина
    public static bool IsValidLogin(string login)
    {
        if (string.IsNullOrEmpty(login)) // Проверяем, что логин не пустой
        {
            return false; // Если пустой, возвращаем false
        }

        if (login.Length < 2 || login.Length > 10) // Проверяем длину логина
        {
            return false; // Если длина не в диапазоне от 2 до 10, возвращаем false
        }

        Regex regex = new Regex("^[a-zA-Z][a-zA-Z0-9]{1,9}$");
        return regex.IsMatch(login); // Ну и возвращаем результат проверки
    }
}
