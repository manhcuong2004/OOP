using System;
class HinhHoc
{
    public virtual double TinhChuVi()
    {
        return 0;
    }
    public virtual double TinhDienTich()
    {
        return 0;
    }
}
class HinhChuNhat : HinhHoc
{
    private double ChieuDai;
    private double ChieuRong;

    public HinhChuNhat(double cd, double cr)
    {
        ChieuDai = cd;
        ChieuRong = cr;
    }

    public override double TinhChuVi()
    {
        return 2 * (ChieuDai + ChieuRong);
    }

    public override double TinhDienTich()
    {
        return ChieuDai * ChieuRong;
    }
}
class HinhTron : HinhHoc
{
    private double BanKinh;

    public HinhTron(double bk)
    {
        BanKinh = bk;
    }
    public override double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public override double TinhDienTich()
    {
        return Math.PI * Math.Pow(BanKinh, 2);
    }
}
class Program
{
    static void Main()
    {
        HinhChuNhat hcn = new HinhChuNhat(5, 7);
        Console.WriteLine($"chu vi hcn: {hcn.TinhChuVi()}");
        Console.WriteLine($"dien tich hcn: {hcn.TinhDienTich()}");
        HinhTron ht = new HinhTron(4);
        Console.WriteLine($"chu vi hinh tron: {ht.TinhChuVi()}");
        Console.WriteLine($"dien tich hinh tron: {ht.TinhDienTich()}");
    }
}
