using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int result = CalculateSquare(n);
            Console.WriteLine($"Квадрат числа {n} равен: {result}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите натуральное число.");
        }
    }

    static int CalculateSquare(int n)
    {
        int square = 1; 

        for (int i = 2; i <= n; i++)
        {
            int oddNumber = 2 * i - 1;
            square += oddNumber;
        }

        return square;
    }
}
