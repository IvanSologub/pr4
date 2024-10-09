using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число K: ");
        int K = int.Parse(Console.ReadLine());

        int lastIndex = 0; // Индекс последнего числа, большего K
        int index = 0; // Текущий индекс
        int number;

        Console.WriteLine("Введите набор целых чисел (0 для завершения):");
        
        while (true)
        {
            number = int.Parse(Console.ReadLine());
            if (number == 0) // Признак завершения
                break;

            index++; // Увеличиваем индекс

            if (number > K)
            {
                lastIndex = index; // Обновляем последний индекс
            }
        }

        Console.WriteLine(lastIndex);
    }
}
