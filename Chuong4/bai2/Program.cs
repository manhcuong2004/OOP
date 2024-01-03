using System;

class SoPhuc
{
    public double phanthuc, phanao;
    
    public SoPhuc()
    {
        phanthuc = 0.0;
        phanao = 0.0;
    }
    
    public static SoPhuc Nhap()
    {
        SoPhuc soPhuc = new SoPhuc();
        Console.Write("Nhap phan thuc: ");
        soPhuc.phanthuc = double.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao: ");
        soPhuc.phanao = double.Parse(Console.ReadLine());
        return soPhuc;
    }
    
    public static void Xuat(SoPhuc a, SoPhuc b)
    {
        Console.WriteLine("Cong " + SoPhuc.Cong(a, b));
        Console.WriteLine("Tru " + SoPhuc.Tru(a, b));
        Console.WriteLine("Nhan " + SoPhuc.Nhan(a, b));
        Console.WriteLine("Chia " + SoPhuc.Chia(a, b));
    }
    
    public static string Cong(SoPhuc a, SoPhuc b)
    {
        return $"{a.phanthuc + b.phanthuc} + {a.phanao + b.phanao}i";
    }
    
    public static string Tru(SoPhuc a, SoPhuc b)
    {
        return $"{a.phanthuc - b.phanthuc} + {a.phanao - b.phanao}i";
    }
    
    public static string Nhan(SoPhuc a, SoPhuc b)
    {
        return $"{a.phanthuc * b.phanthuc - a.phanao * b.phanao} + {a.phanthuc * b.phanao + a.phanao * b.phanthuc}i";
    }
    
    public static string Chia(SoPhuc a, SoPhuc b)
    {
        double sochia = b.phanthuc * b.phanthuc + b.phanao * b.phanao;
        return $"{(a.phanthuc * b.phanthuc + a.phanao * b.phanao) / sochia} + {(a.phanao * b.phanthuc - a.phanthuc * b.phanao) / sochia}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so phuc A:");
        SoPhuc a = SoPhuc.Nhap();
        Console.WriteLine("Nhap so phuc B:");
        SoPhuc b = SoPhuc.Nhap();
        SoPhuc.Xuat(a, b);
    }
}
