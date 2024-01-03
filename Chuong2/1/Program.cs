using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        int b = int.Parse(Console.ReadLine());

        int slnt = 0;

        for (int i = a; i <= b; i++)
        {
            int nt = 0;
            for (int j = 2; j <= i; j++)
            {
                if (i % j == 0)
                {
                    nt++;
                    break;
                }
            }

            if (nt == 0 & i != 1)
            {
                slnt++;
            }
        }

        Console.WriteLine($"[{a},{b}] co {slnt} so nguyen to");
        Console.ReadKey();
    }
}
