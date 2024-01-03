using System;
class Sach
{
    public string TenSach { get; set; } //định nghĩa cac thuoc tinh
    public string TacGia { get; set; }
    public int NamXB { get; set; }
    public int SoLuong { get; set; }
    public Sach()
    {

    }
    ~Sach()
    {

    }
    public void Nhap()
    {
        Console.Write("Ten sach: ");
        TenSach = Console.ReadLine();
        Console.Write("Tac gia: ");
        TacGia = Console.ReadLine();
        Console.Write("Nam xuat ban: ");
        NamXB = Convert.ToInt32(Console.ReadLine());
        Console.Write("So luong: ");
        SoLuong = Convert.ToInt32(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Ten sach: " + TenSach);
        Console.WriteLine("Tac gia: " + TacGia);
        Console.WriteLine("Nam xuat ban: " + NamXB);
        Console.WriteLine("So luong: " + SoLuong);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Sach sach1 = new Sach();
        sach1.Nhap();
        Sach sach2 = new Sach();
        sach2.TenSach = "lich su 12";
        sach2.TacGia = "Nguyen Van A";
        sach2.NamXB = 2021;
        sach2.SoLuong = 50;
        Console.WriteLine("Thong tin cac loai sach da nhap:");
        sach1.Xuat();
        Console.WriteLine();
        sach2.Xuat();
        Console.ReadLine();
    }
}