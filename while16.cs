using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число K: ");
        int K = int.Parse(Console.ReadLine());

        int lastIndex = 0; // Переменная для хранения номера последнего числа больше K
        int currentIndex = 1; // Индекс текущего числа

        Console.WriteLine("Введите набор ненулевых целых чисел (введите 0 для завершения):");

        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0) // Завершение ввода
            {
                break;
            }

            if (number > K) // Если число больше K
            {
                lastIndex = currentIndex; // Обновляем номер последнего числа
            }

            currentIndex++; // Увеличиваем индекс для следующего числа
        }

        Console.WriteLine($"Номер последнего числа, большего {K}: {lastIndex}");
    }
}



