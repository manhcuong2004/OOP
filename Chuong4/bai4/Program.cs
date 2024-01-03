using System;
class Info
{
    public string ID, Hoten, Group;
    public static int dem = 0;
    public DTP bangdiem;
    public static Info Nhap()
    {
        Info sv = new Info();
        Console.Write("Nhap ID: ");
        sv.ID = Console.ReadLine();
        Console.Write("Nhap Ho ten: ");
        sv.Hoten = Console.ReadLine();
        Console.Write("Nhap Group: ");
        sv.Group = Console.ReadLine();
        sv.bangdiem = DTP.Nhap();
        dem++;
        return sv;
    }
    public void Xuat()
    {
        Console.WriteLine($"ID: {ID}, Ho ten: {Hoten}, Group: {Group}");
        Console.WriteLine("DTB: " + bangdiem.DTB()); 
    }
}
class DTP
{
    public float TP1, TP2, TP3;

    public static DTP Nhap()
    {
        DTP diem = new DTP();
        Console.Write("TP1: ");
        diem.TP1 = float.Parse(Console.ReadLine());
        Console.Write("TP2: ");
        diem.TP2 = float.Parse(Console.ReadLine());
        Console.Write("TP3: ");
        diem.TP3 = float.Parse(Console.ReadLine());
        return diem;
    }
    public float DTB()
    {
        return TP1 * 0.1f + TP2 * 0.3f + TP3 * 0.6f;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Info sv1 = Info.Nhap();
        Info sv2 = Info.Nhap();
        Console.WriteLine("Danh sach sinh vien:");
        sv1.Xuat();
        sv2.Xuat();
        Console.WriteLine("So luong sinh vien: " + Info.dem);
    }
}
