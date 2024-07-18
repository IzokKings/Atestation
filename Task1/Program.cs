using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int N = int.Parse(Console.ReadLine());

        if (M > N)
        {
            Console.WriteLine("M должно быть меньше или равно N");
        }
        else
        {
            Console.WriteLine("Натуральные числа в промежутке от M до N:");
            PrintNumbers(M, N);
        }
    }

    static void PrintNumbers(int current, int N)
    {
        if (current > N)
        {
            return;
        }

        Console.WriteLine(current);
        PrintNumbers(current + 1, N);
    }
}

