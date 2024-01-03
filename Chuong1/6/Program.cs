using System;

class Program
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Gia tri lan luot cac mat hang la: ");
        string gtmh = Console.ReadLine();

        string[] Agtmh = gtmh.Split(' ');

        double[] A = new double[n];
        for (int i = 0; i < n; i++)
        {
            A[i] = double.Parse(Agtmh[i]);
        }
        Array.Sort(A);

        double tonghang = 0;
        double tongkm = 0;

        for (int i = 0; i < n; i++)
        {
            double giatrimathang = A[i];
            tonghang += giatrimathang;
        }

        if (n >= 3)
        {
            int k = n / 3;
            for (int j = 0; j < k; j++)
            {
                double km = A[j];
                tongkm += km;
            }
        }

        double tongphaitra = tonghang - tongkm;
        Console.WriteLine($"Tong so tien phai tra la: {tongphaitra}");
    }
}
