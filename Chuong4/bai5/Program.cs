using System;
class DoanhNghiep
{
    public string TenDN, MST, Diachi;
}
class DanhsachDN
{
    private static int size = 0;
    private static DoanhNghiep[] A;
    public DanhsachDN()
    {
        Array.Resize(ref A, size + 1);
        A[size] = new DoanhNghiep();

        Console.Write("TenDN: ");
        A[size].TenDN = Console.ReadLine();
        Console.Write("MST: ");
        A[size].MST = Console.ReadLine();
        Console.Write("Diachi: ");
        A[size].Diachi = Console.ReadLine();

        size++;
    }

    public static void Xuat()
    {
        Console.WriteLine("Danh sach doanh nghiep:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Ten doanh nghiep: {A[i].TenDN}");
            Console.WriteLine($"MST: {A[i].MST}");
            Console.WriteLine($"Dia chi: {A[i].Diachi}");
        }
    }

    public static string TimMST(string tendn)
    {
        for (int i = 0; i < size; i++)
        {
            if (A[i].TenDN == tendn)
            {
                return A[i].MST;
            }
        }
        return "";
    }

    public static string TimThongTin(string mst)
    {
        for (int i = 0; i < size; i++)
        {
            if (A[i].MST == mst)
            {
                return $"{A[i].TenDN} {A[i].Diachi}";
            }
        }
        return "";
    }
}

class Program
{
    static void Main(string[] args)
    {
        DanhsachDN DN1 = new DanhsachDN();
        DanhsachDN DN2 = new DanhsachDN();
        DanhsachDN.Xuat();

        Console.Write("TenDN can tim MST: ");
        string tpdn = Console.ReadLine();
        string mst = DanhsachDN.TimMST(tpdn);

        if (mst != "")
        {
            Console.WriteLine($"MST cua {tpdn} la: {mst}");
        }
        else
        {
            Console.WriteLine("Khong tim thay ten doanh nghiep");
        }

        Console.Write("MST cua dn can tim: ");
        string mstct = Console.ReadLine();
        string thongtin = DanhsachDN.TimThongTin(mstct);

        if (thongtin != "")
        {
            Console.WriteLine($"Thong tin cua MST {mstct} la: {thongtin}");
        }
        else
        {
            Console.WriteLine("Khong tim thay thong tin cho MST");
        }
    }
}
