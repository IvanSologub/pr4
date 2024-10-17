using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Введите процент P (0 < P < 50): ");
        string input = Console.ReadLine();
        double P;

        // Заменяем запятую на точку для корректного парсинга
        input = input.Replace(',', '.');

        // Пробуем распарсить введенное значение
        if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out P) || P <= 0 || P >= 50)
        {
            Console.WriteLine("Процент должен быть в диапазоне от 0 до 50.");
            return;
        }

        int day = 0;
        double totalDistance = 0;
        double currentDistance = 10; // Пробег в первый день

        while (totalDistance <= 200)
        {
            day++;
            totalDistance += currentDistance; // Добавляем текущий пробег
            currentDistance *= (1 + P / 100); // Увеличиваем пробег на P%
        }

        Console.WriteLine($"Суммарный пробег превысит 200 км после {day} дня(ей).");
        Console.WriteLine($"Суммарный пробег: {totalDistance:F2} км."); // Выводим суммарный пробег с двумя знаками после запятой
    }
}


