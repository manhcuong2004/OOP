abstract class Khachsan
{
    public string TenKH, CMND;
    public int Snt;
    public static double TTTP;
    public Khachsan(string ten, string cmnd, int snt)
    {
        TenKH = ten;
        CMND = cmnd;
        Snt = snt;
    }
    public abstract double TienThue();
    public abstract void Xuat();

    public double TongTien()
    {
        return TTTP += TienThue();
    }

    public static void XTT()
    {
        Console.WriteLine($"Tong tien phong Standard va VIP: {TTTP}");
    }
}
class Standard : Khachsan
{
    public Standard(string ten, string cmnd, int snt) : base(ten, cmnd, snt)
    {
        TongTien();
    }
    public override double TienThue()
    {
        if (Snt >= 5)
        { return Snt * 400; }
        else
        { return Snt * 500; };
    }

    public override void Xuat()
    {
        Console.WriteLine($"Ten: {TenKH}, CMND: {CMND}, Snt: {Snt}, Tien Phong: {TienThue()}");
    }
    
}
class Vip : Khachsan
{
    public string Loaip;
    public static double TTTPL = 0;

    public Vip(string ten, string cmnd, int snt, string lp) : base(ten, cmnd, snt)
    {
        Loaip = lp;
        TongTien();
        TTienThueLu();
    }

    public override double TienThue()
    {
        if (Loaip == "Luxury")
        {
            if (Snt >= 6)
            {
                return Snt * 1000;   
            }
            else
            {
                return Snt * 1100; 
            }
        }
        if (Loaip == "Present")
        {
            if (Snt >= 6)
            {
                return Snt * 1000;
            }
            else
            { 
                return Snt * 1300;
            }
        }
        else
        {
            return 0;
        }
    }
    public override void Xuat()
    {
        Console.WriteLine($"Ten: {TenKH}, CMND: {CMND}, Snt: {Snt}, Loai Phong: {Loaip}, Tien Phong: {TienThue()}");
    }
    public double TTienThueLu()
    {
        if (Loaip == "Luxury")
        {
            if (Snt >= 6)
            {
                return TTTPL += Snt * 1000;   
            }
            else
            {
                return TTTPL += Snt * 1100; 
            }
        }
        else
        {   return 0; }
    }
    public static void TongTienLu()
    {
        Console.WriteLine($"Tong tien phong Luxury: {TTTPL} ");
    }
}

class Program
{
    static void Main()
    {
        List<Khachsan> danhSachPhong = new List<Khachsan>();
        Khachsan p1 = new Standard("A", "26723333", 4);
        Khachsan p2 = new Standard("B", "26178333", 7);
        Khachsan p3 = new Vip("C", "29233333", 4, "Luxury");
        Khachsan p4 = new Vip("D", "29111333", 4, "Present");
        Khachsan p5 = new Vip("E", "29233333", 6, "Luxury");

        p1.Xuat();
        danhSachPhong.Add(p1);
        p2.Xuat();
        danhSachPhong.Add(p2);
        p3.Xuat();
        danhSachPhong.Add(p3);
        p4.Xuat();
        danhSachPhong.Add(p4);
        p5.Xuat();
        danhSachPhong.Add(p5);
        Khachsan.XTT();
        Vip.TongTienLu();
    
        XuatThongTinStandard(danhSachPhong);
    }
    static void XuatThongTinStandard(List<Khachsan> danhSachPhong)
    {
        Console.WriteLine("Thong tin phong Standard:");
        foreach (Khachsan phong in danhSachPhong)
        {
            if (phong is Standard)
            {
                phong.Xuat();
            }
        }
    }
}
