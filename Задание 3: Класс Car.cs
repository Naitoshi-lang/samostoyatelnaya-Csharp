using System;

public class Car
{
    // Переменные 
    private string brand;    // Марка 
    private int year;        // Год 
    private int mileage;     // Пробег 
  
    // конструктор для создания автомобиля
    public Car(string brand, int year)
    {

        this.brand = brand;
        this.year = year;

        // Пробег по умолчанию равен 0
        this.mileage = 0;
    }

    // метод для увеличения пробега
    public void Drive(int km)
    {
        // Увеличиваем пробег на указанное количество километров
        this.mileage += km;
        Console.WriteLine($"Автомобиль {brand} проехал {km} км. Общий пробег: {mileage} км.");
    }

    // Метод DisplayInfo(), который выводит всю информацию об авто
    public void DisplayInfo()
    {
        Console.WriteLine("Информация об автомобиле:");
        Console.WriteLine($"Марка: {brand}");
        Console.WriteLine($"Год выпуска: {year}");
        Console.WriteLine($"Пробег: {mileage} км");
    }

    // Деструктор
    ~Car()
    {
        Console.WriteLine($"Объект Car {brand} {year} уничтожен.");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", 2020); // создаем автомобиль
        car.Drive(150); // увеличиваем пробег
        car.DisplayInfo(); // выводим информацию
    }
}
