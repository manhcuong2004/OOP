using System;

class Program
{
    static int UCLN(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            return a + b;
        }
        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        return a;
    }
    static bool SLSNT(int a, int b)
    {
        if (UCLN(a, b) == 1)
        {
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();
        string[] num = input.Split(" ");
        int count = 0;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (SLSNT(int.Parse(num[i]), int.Parse(num[j])))
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
