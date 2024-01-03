using System;
using System.Collections.Generic;   
class Phong
{
    public string TenKh, CMND;
    public int SoNgayThue;
    public Phong(string tenkh, string cmnd, int snt)
    {
        TenKh = tenkh;
        CMND = cmnd;
        SoNgayThue = snt;
    }
    public virtual double TinhTienThue()
    {
        return 0;
    }
    public void Xuat()
    {
        Console.WriteLine($"Thong tin phong:{TenKh},cmnd: {CMND},so ngay thue: {SoNgayThue}");
    }
}

class Standard : Phong
{
    public Standard(string tenkh, string cmnd, int snt) : base(tenkh, cmnd, snt)
    {
    }
    public override double TinhTienThue()
    {
        if (SoNgayThue < 5)
        {
            return 500 * SoNgayThue;
        }
        else
        {
            return 400 * SoNgayThue;
        }
    }
    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Tien thue Phong: {TinhTienThue()}");
    }
}

class VIP : Phong
{
    public string LoaiPhong;
    public VIP(string tenkh, string cmnd, int snt, string loaip) : base(tenkh, cmnd, snt)
    {
        LoaiPhong = loaip;
    }
    public override double TinhTienThue()
    {
        if (SoNgayThue < 5 && LoaiPhong == "luxury")
        {
            return 1100 * SoNgayThue;
        }
        else if (SoNgayThue < 5 && LoaiPhong == "president")
        {
            return 1300 * SoNgayThue;
        }
        else
        {
            return 1000 * SoNgayThue;
        }
    }
    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Loai Phong: {LoaiPhong} ,Tien thue Phong: {TinhTienThue()}");
    }
}

class Program
{
    static void Main()
    {
        List<Phong> phong1 = new List<Phong>();
        Standard r1 = new Standard("A", "00122", 6);
        r1.Xuat();
        phong1.Add(r1);
        VIP r2 = new VIP("B", "001231", 6, "luxury");
        r2.Xuat();
        phong1.Add(r2);
        VIP r3 = new VIP("C", "001221", 3, "president");
        r3.Xuat();
        phong1.Add(r3);
        Standard r4 = new Standard("D", "00122", 3);
        r4.Xuat();
        phong1.Add(r4);
        VIP r5 = new VIP("E", "021231", 2, "luxury");
        r5.Xuat();
        phong1.Add(r5);

        TongTien(phong1);
        pStandard(phong1);
        pLuxury(phong1);
    }

    static void TongTien(List<Phong> phongs)
    {
        double s = 0;
        foreach (var p in phongs)
        {
            s += p.TinhTienThue();
        }
        Console.WriteLine("\nTong tien: " + s);
    }

    static void pStandard(List<Phong> phongs)
    {
        Console.WriteLine("\nThong tin phong Standard:");
        foreach (var p in phongs)
        {
            if (p is Standard)
            {
                p.Xuat();
                Console.WriteLine("Tien thue phong: " + p.TinhTienThue());
            }
        }
    }

    static void pLuxury(List<Phong> phongs)
    {
        double s = 0;
        foreach (var p in phongs)
        {
            if (p is VIP lux && lux.LoaiPhong == "luxury")
            {
                s += p.TinhTienThue();
            }
        }
        Console.WriteLine("\nTong tien luxury: " + s);
    }
}
