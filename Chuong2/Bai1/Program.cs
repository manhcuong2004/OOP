using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ho va ten: ");
        string hoten = Console.ReadLine();

        Console.Write("Lop: ");
        string lop = Console.ReadLine();
        double m = 0;
        Console.Write("Diem_QTH: ");
        double diemqth = double.Parse(Console.ReadLine());
        if (diemqth >= 8.5)
        {
            m += 4.0;
        }
        else if (diemqth >= 7.0)
        {
            m += 3.0;
        }
        else if (diemqth >= 5.5)
        {
            m += 2.0;
        }
        Console.Write("Diem_HTTQL: ");
        double diemhttql = double.Parse(Console.ReadLine());
        if (diemhttql >= 8.5)
        {
            m += 4.0;
        }
        else if (diemhttql >= 7.0)
        {
            m += 3.0;
        }
        else if (diemhttql >= 5.5)
        {
            m += 2.0;
        }
        Console.Write("Diem_CSLT: ");
        double diemcslt = double.Parse(Console.ReadLine());
        if (diemcslt >= 8.5)
        {
            m += 4.0;
        }
        else if (diemcslt >= 7.0)
        {
            m += 3.0;
        }
        else if (diemcslt >= 5.5)
        {
            m += 2.0;
        }
        Console.Write("Diem_Triet: ");
        double diemtriet = double.Parse(Console.ReadLine());
        if (diemtriet >= 8.5)
        {
            m += 4.0;
        }
        else if (diemtriet >= 7.0)
        {
            m += 3.0;
        }
        else if (diemtriet >= 5.5)
        {
            m += 2.0;
        }
        double gpa = m / 4;
        string xeploai = "";
        if (gpa >= 3.6)
        {
            xeploai = "Xuat sac";
        }
        else if (gpa >= 3.2)
        {
            xeploai = "Gioi";
        }
        else if (gpa >= 2.5)
        {
            xeploai = "Kha";
        }
        else if (gpa >= 2.0)
        {
            xeploai = "Trung binh";
        }
        else
        {
            xeploai = "Yeu";
        }
        Console.WriteLine($"Sinh vien {hoten.ToUpper()}, Lop {lop}, Dat GPA {gpa}, Xep loai {xeploai}");
    }
}
