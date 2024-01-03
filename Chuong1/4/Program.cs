using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        while (n >= 10)
        {
            int tong = 0;

            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }

            n = tong;
        }

        Console.WriteLine(n);
    }
}
