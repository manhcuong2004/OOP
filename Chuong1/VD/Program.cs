using System;

class Program
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int[] A = new int[n];
        for (int i = 0; i < n; i++)
        {
            A[i] = int.Parse(numbers[i]);
        }

        int slnt = 0;

        for (int i = 0; i < n; i++)
        {
            if (A[i] < 2)
            {
                continue;
            }

            bool isPrime = true;

            for (int j = 2; j * j <= A[i]; j++)
            {
                if (A[i] % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

        }

        int coprimeCount = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (GCD(A[i], A[j]) == 1)
                {
                    coprimeCount++;
                }
            }
        }

        Console.WriteLine($"Số lượng số nguyên tố trong dãy là: {slnt}");
        Console.WriteLine($"Số lượng số cùng nhau (ước chung lớn nhất là 1): {coprimeCount}");
    }
}
