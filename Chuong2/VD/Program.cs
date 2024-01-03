using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 10)
        {
            int sumOfDigits = 0;
            while (n > 0)
            {
                sumOfDigits += n % 10;
                n /= 10;
            }
            n = sumOfDigits;
        }
        Console.WriteLine("Kết quả: " + n);
    }
}
