using System;

class Program
{
    static void Main(string[] args)
    {
        string tiepTuc;
        do
        {
            double a, b;
            char toantu;

            Nhap(out a, out b, out toantu);
            double kq = Thuchien(a, b, toantu);
            InKQ(a, b, toantu, kq);

            Console.Write("Tiep tuc: ");
            tiepTuc = Console.ReadLine();
        } while (tiepTuc != "T" & tiepTuc != "t");
    }
    static void Nhap(out double a, out double b, out char toantu)
    {
        Console.Write("a=");
        a = double.Parse(Console.ReadLine());

        Console.Write("b=");
        b = double.Parse(Console.ReadLine());

        Console.Write("Toan tu: ");
        toantu = char.Parse(Console.ReadLine());
    }

    static double Thuchien(double a, double b, char toantu)
    {
        double kq = 0;
        switch (toantu)
        {
            case '+':
                kq = a + b;
                break;
            case '-':
                kq = a - b;
                break;
            case '*':
                kq = a * b;
                break;
            case '/':
                kq = a / b;           
                break;
        }
        return kq;
    }

    static void InKQ(double a, double b, char toantu, double kq)
    {
        Console.WriteLine($"{a} {toantu} {b} = {kq}");
    }
}
