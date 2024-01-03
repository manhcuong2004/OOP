using System;

class Tron
{
    public double BanKinh, DuongKinh, DienTich;
    public Tron(double bk)
    {
        BanKinh = bk;
        DuongKinh = 2 * bk;
        DienTich = Math.PI * bk * bk;
    }
    public void Xuat()
    {
        Console.WriteLine("hinh tron:");
        Console.WriteLine("ban kinh: " + BanKinh);
        Console.WriteLine("duong kinh: " + DuongKinh);
        Console.WriteLine("dien tich: " + DienTich);
    }
}

class Cau : Tron
{
    public double TheTich, DienTichHC;

    public Cau(double bk) : base(bk)
    {
        TheTich = (4.0 / 3.0) * Math.PI * BanKinh * BanKinh * BanKinh;
        DienTichHC = 4 * Math.PI * BanKinh * BanKinh;
    }
    public new void Xuat()
    {
        Console.WriteLine("hinh cau:");
        Console.WriteLine("ban kinh: " + BanKinh);
        Console.WriteLine("the tich: " + TheTich);
        Console.WriteLine("dien tich hinh cau: " + DienTichHC);
    }
}

class HinhTruTron : Tron
{
    public double ChuViMatDay, DienTichMatDay, DienTichXungQuanh, DienTichToanPhan, TheTich, ChieuCao;

    public HinhTruTron(double bk, double h) : base(bk)
    {
        ChieuCao = h;
        ChuViMatDay = 2 * Math.PI * BanKinh;
        DienTichMatDay = Math.PI * BanKinh * BanKinh;
        DienTichXungQuanh = 2 * Math.PI * BanKinh * ChieuCao;
        DienTichToanPhan = 2 * Math.PI * BanKinh * (BanKinh + ChieuCao);
        TheTich = Math.PI * BanKinh * BanKinh * ChieuCao;
    }
    public new void Xuat()
    {
        Console.WriteLine("hinh tru tron:");
        Console.WriteLine("ban kinh: " + BanKinh);
        Console.WriteLine("chieu cao: " + ChieuCao);
        Console.WriteLine("chu vi mat day: " + ChuViMatDay);
        Console.WriteLine("dien tich mat day: " + DienTichMatDay);
        Console.WriteLine("dien tich xung quanh: " + DienTichXungQuanh);
        Console.WriteLine("dien tich toan phan: " + DienTichToanPhan);
        Console.WriteLine("the tich: " + TheTich);
    }
}

class Program
{
    static void Main()
    {
        Tron tron = new Tron(5);
        tron.Xuat();
        
        Cau cau = new Cau(5);
        cau.Xuat();
        
        HinhTruTron hinhTruTron = new HinhTruTron(3, 6);
        hinhTruTron.Xuat();
    }
}
