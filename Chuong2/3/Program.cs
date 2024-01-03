using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A= ");
        string A = Console.ReadLine();

        Console.Write("B= ");
        string B = Console.ReadLine();

        string C = "";
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == '0' & B[i] == '0' || A[i] == '1' & B[i] == '1')
            {
                C += '0';
            }
            else
            {
                C += '1';
            }
        }
        Console.WriteLine("C = A XOR B = " + C);
    }
}

