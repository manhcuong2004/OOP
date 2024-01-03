using System;
class Triangle
{
    public int a = 0;
    public int b = 0;
    public int c = 0;

    public void Nhap()
    {
        Console.Write("Do dai canh a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Do dai canh b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Do dai canh c: ");
        c = int.Parse(Console.ReadLine());
    }
    public bool KTTamGiac()
    {
        return (a + b > c) & (a + c > b) & (b + c > a);
    }
    public int Chuvi()
    {
        return a + b + c;
    }
    public double DienTinh()
    {
        double s = Chuvi() / 2.0;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public void Xuat()
    {
        Console.WriteLine("Canh a = " + a);
        Console.WriteLine("Canh b = " + b);
        Console.WriteLine("Canh c = " + c);
    }
}
class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle();
        bool exit = true;

        while (exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Bam 1: Nhap cac canh a, b, c cua mot tam giac");
            Console.WriteLine("Bam 2: Tinh chu vi va dien tich cua mot tam giac");
            Console.WriteLine("Bam 3: Xuat cac gia tri a, b, c");
            Console.WriteLine("Bam 0: Thoat");

            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    triangle.Nhap();
                    break;
                case "2":
                    if (triangle.KTTamGiac())
                    {
                        double p = triangle.Chuvi();
                        double s = triangle.DienTinh();
                        Console.WriteLine("Chu vi cua tam giac: " + p);
                        Console.WriteLine("Dien tich cua tam giac: " + s);
                    }
                    else
                    {
                        Console.WriteLine("Khong hop le.");
                    }
                    break;
                case "3":
                    triangle.Xuat();
                    break;
                case "0":
                    exit = false;
                    break;
            }
        }
    }
}
