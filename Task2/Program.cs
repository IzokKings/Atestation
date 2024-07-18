using System;

class Program
{
    static void Main()
    {
        // Задаем значения m и n
        int m = 2; 
        int n = 3; 

        // Выводим заданные значения
        Console.WriteLine($"Заданные значения: m = {m}, n = {n}");

        // Вычисляем функцию Аккермана
        int result = Ackermann(m, n);

        // Выводим результат
        Console.WriteLine($"Функция Аккермана A({m}, {n}) = {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}
