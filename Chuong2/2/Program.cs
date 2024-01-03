using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            double j = 1 / (2 * i - 1);
            s += j;
        }
        Console.WriteLine(s);
    }
}

