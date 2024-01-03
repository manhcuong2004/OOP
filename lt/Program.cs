class KhachHang
{
    public string TenKH;
    public int GiaVe;
    private static double s = 0;
    public KhachHang(string tenkh, int giave)
    {
        TenKH = tenkh;
        GiaVe = giave;
    }
    public virtual double TinhGiaVe()
    {
        return 0;
    }
    public double Tinh()
    {
        return s +=TinhGiaVe();
    }
    public static void TongTien()
    {
        Console.WriteLine("Tong tien: "+ s);
    }
}
class NguoiLon : KhachHang
{
    public string CMND;
    public string The;

    public NguoiLon(string tenkh, string cmnd, int giave) : base(tenkh, giave)
    {
        CMND = cmnd;
        The = "The do";
        Tinh();
    }

    public override double TinhGiaVe()
    {
        return GiaVe;
    }

    public void Xuat()
    {
        Console.WriteLine($"Ten: {TenKH}, CMND: {CMND}, Gia ve: {TinhGiaVe()}, {The}");
    }
}

class TreEm : KhachHang
{
    public double ChieuCao;
    public string The;

    public TreEm(string tenkh, double chieuCao, int giave) : base(tenkh, giave)
    {
        ChieuCao = chieuCao;
        The = "The xanh";
        Tinh();
    }

    public override double TinhGiaVe()
    {
        if (ChieuCao >= 1)
        {
            return GiaVe;
        }
        else
        {
            return 0;
        }
    }
    public void Xuat()
    {
        Console.WriteLine($"Ten: {TenKH}, Chieu cao: {ChieuCao}m, Gia ve: {TinhGiaVe()}, {The}");
    }
}
class Program
{
    static void Main()
    {
        NguoiLon nl = new NguoiLon("A", "123456789", 250000);
        TreEm te1 = new TreEm("B", 0.8, 0);
        TreEm te2 = new TreEm("C", 1.2, 130000);

        nl.Xuat();
        te1.Xuat();
        te2.Xuat();

        KhachHang.TongTien();
    }
}
