using System;

public class Student
{
    //  переменные
    private string name; // Имя
    private int age; // Возраст
    private int grade; // Успеваемость (от 1 до 5)

    // Конструктор класса
    public Student(string name, int age, int initialGrade)
    {
      // Проверка
        this.name = name;
        this.age = age;
        SetGrade(initialGrade);
    }

    // Проверка в пределах от 1 до 5
    public void SetGrade(int value)
    {
        if (value >= 1 && value <= 5)
        {
            this.grade = value;
        }
        else
        {
            Console.WriteLine("Ошибка: Успеваемость должна быть в диапазоне от 1 до 5. Значение не изменено.");
        }
    }

    // Информация
    public void DisplayInfo()
    {
        Console.WriteLine("Информация о студенте:");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Успеваемость: {grade}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Настя", 20); // создаем студента
        student.SetGrade(4); // устанавливаем оценку
        student.DisplayInfo(); // выводим информацию
    }
}
