using System;
class Phanso
{
    public double tuso, mauso;
    public Phanso()
    {
        tuso = 0.0;
        mauso = 1;
    }
    public static Phanso Nhap()
    {
        Phanso phanSo = new Phanso(); 
        Console.Write("Nhap tu so: ");
        phanSo.tuso = double.Parse(Console.ReadLine());
        Console.Write("Nhap mau so: ");
        phanSo.mauso = double.Parse(Console.ReadLine());
        return phanSo;
    }
    public static void Xuat(double ts1, double ms1, double ts2, double ms2)
    {
        Console.WriteLine("Cong: " + Phanso.Cong(ts1, ms1, ts2, ms2));
        Console.WriteLine("Tru: " + Phanso.Tru(ts1, ms1, ts2, ms2));
        Console.WriteLine("Nhan: " + Phanso.Nhan(ts1, ms1, ts2, ms2));
        Console.WriteLine("Chia: " + Phanso.Chia(ts1, ms1, ts2, ms2));
    }
    public static string Cong(double ts1, double ms1, double ts2, double ms2)
    {
        return $"{ts1 * ms2 + ts2 * ms1} / {ms1 * ms2}";
    }
    public static string Tru(double ts1, double ms1, double ts2, double ms2)
    {
        return $"{ts1 * ms2 - ts2 * ms1} / {ms1 * ms2}";
    }
    public static string Nhan(double ts1, double ms1, double ts2, double ms2)
    {
        return $"{ts1 * ts2} / {ms1 * ms2}";
    }
    public static string Chia(double ts1, double ms1, double ts2, double ms2)
    {
        return $"{ts1 * ms2} / {ms1 * ts2}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap phan so A: ");
        Phanso a = Phanso.Nhap();
        Console.WriteLine("Nhap phan so B: ");
        Phanso b = Phanso.Nhap();
        Phanso.Xuat(a.tuso, a.mauso, b.tuso, b.mauso);
    }
}
