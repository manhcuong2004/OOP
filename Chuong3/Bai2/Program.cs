using System;


class Meo
{
    public string Ten; 
    public string Giong;
    public string GioiTinh;
    public int Tuoi;
    public static int dem = 0;

    public Meo(string ten, string giong, string gioiTinh, int tuoi)
    {
        Ten = ten;
        Giong = giong;
        GioiTinh = gioiTinh;
        Tuoi = tuoi;
        dem = dem + 1;
    }

    public Meo()
    {

    }

    public void Nhap()
    {
        Console.Write("Nhap ten meo: ");
        Ten = Console.ReadLine();
        Console.Write("Nhap giong cua meo: ");
        Giong = Console.ReadLine();
        Console.Write("Nhap tuoi cua meo: ");
        Tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap gioi tinh: ");
        GioiTinh = Console.ReadLine();
        dem = dem + 1;
    }

    public void Xuat()
    {
        Console.WriteLine("Ten meo la: " + Ten);
        Console.WriteLine("Giong cua meo la: " + Giong);
        Console.WriteLine("Tuoi cua meo la: " + Tuoi);
        Console.WriteLine("Gioi tinh cua meo: " + GioiTinh);
    }

    public static void Dem()
    {
        Console.WriteLine("So luong meo: " + dem);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Meo meo1 = new Meo("Chimsau", "Anh", "Duc", 3);
        Meo meo2 = new Meo();

        meo1.Xuat();

        meo2.Nhap();
        meo2.Xuat();

        Meo.Dem();
    }
}
