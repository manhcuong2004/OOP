using System;

class Program
{
    static void Main()
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
                int a = int.Parse(num[i]);
                int b = int.Parse(num[j]);

                while (b != 0)
                {
                    int nt = b;
                    b = a % b;
                    a = nt;
                }
                if (a == 1)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}
