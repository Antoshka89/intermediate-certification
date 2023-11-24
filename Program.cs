using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Вывести все натуральные числа в промежутке от M до N");
        Console.WriteLine("2. Найти сумму натуральных элементов от M до N");
        Console.WriteLine("3. Вычислить функцию Аккермана для m и n");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Вывести все натуральные числа в промежутке от M до N
                DisplayNaturalNumbers();
                break;
            case 2:
                // Найти сумму натуральных элементов от M до N
                DisplaySumOfNaturalNumbers();
                break;
            case 3:
                // Вычислить функцию Аккермана для m и n
                DisplayAckermannFunction();
                break;
            default:
                Console.WriteLine("Некорректный выбор.");
                break;
        }
    }

    // Метод для получения строки с натуральными числами от M до N
    static string GetNaturalNumbers(int M, int N)
    {
        if (M > N)
        {
            return "Некорректный ввод. M должно быть меньше или равно N.";
        }

        string result = "";
        for (int i = M; i <= N; i++)
        {
            result += i + ", ";
        }

        // Удаляем последнюю запятую и пробел
        return result.TrimEnd(',', ' ');
    }

    // Метод для вычисления суммы натуральных чисел от M до N
    static int GetSumOfNaturalNumbers(int M, int N)
    {
        if (M > N)
        {
            return 0; // Диапазон некорректен, возвращаем 0
        }

        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        return sum;
    }

    // Метод для вычисления функции Аккермана с помощью рекурсии
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }

    // Метод для вывода всех натуральных чисел в промежутке от M до N
    static void DisplayNaturalNumbers()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}: {GetNaturalNumbers(M, N)}");
    }

    // Метод для вывода суммы натуральных чисел от M до N
    static void DisplaySumOfNaturalNumbers()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = GetSumOfNaturalNumbers(M, N);
        Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum}");
    }

    // Метод для вывода значения функции Аккермана
    static void DisplayAckermannFunction()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);
        Console.WriteLine($"Значение функции Аккермана для m={m} и n={n}: {result}");
    }
}