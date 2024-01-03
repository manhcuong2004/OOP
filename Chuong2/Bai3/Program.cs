using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("A = ");
        string mang = Console.ReadLine();
        mang = mang.Replace("[", "").Replace("]", "");
        string[] so = mang.Split(',');

        double[] A = new double[n];

        for (int i = 0; i < n; i++)
        {
            A[i] = double.Parse(so[i]);
        }

        // câu a
        double Tongam = 0;
        foreach (double am in A)
        {
            if (am < 0)
            {
                Tongam += Math.Abs(am);
            }
        }
        Console.WriteLine($"Tong  = {Tongam}");

        // câu b
        double max = A[0];
        double min = A[0];
        int maxindex = 0;
        int minindex = 0;
        for (int i = 1; i < n; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
                maxindex = i;
            }
            if (A[i] < min)
            {
                min = A[i];
                minindex = i;
            }
        }
        double tich = 1;
        int sd = 0;
        int sc = 0;
        if (maxindex > minindex)
        {
            sd = minindex;
            sc = maxindex;
        }
        else if (maxindex < minindex)
        {
            sc = minindex;
            sd = maxindex;
        }
        for (int i = sd + 1; i < sc; i++)
        {
            tich *= A[i];
        }
        Console.WriteLine($"Tich = {tich}");

        // câu c
        Array.Sort(A);
        Console.Write($"A_tang = [{string.Join(", ", A)}]");

        // câu d
        int[] Athuc = new int[n];
        for (int i = 0; i < n; i++)
        {
            Athuc[i] = (int)A[i];
        }
        int[] Abiendoi = new int[n];
        int indexchan = 0;
        for (int i = 0; i < n; i++)
        {
            if (Athuc[i] % 2 == 0)
            {
                Abiendoi[indexchan] = Athuc[i];
                indexchan++;
            }
        }
        int indexle = indexchan;
        for (int i = 0; i < n; i++)
        {
            if (Athuc[i] % 2 != 0)
            {
                Abiendoi[indexle] = Athuc[i];
                indexle++;
            }
        }
        Console.WriteLine();
        Console.Write($"A_biendoi = [{string.Join(", ", Abiendoi)}]");
    }
}
