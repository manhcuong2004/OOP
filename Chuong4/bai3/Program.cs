using System;

class TamGiac
{
    private double a,b,c;
    public void Nhap()
    {
        Console.Write("nhap do dai a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("nhap do dai b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("nhap do dai c: ");
        c = double.Parse(Console.ReadLine());
    }
    public string KiemTra()
    {
        if (a + b > c & a + c > b & b + c > a)
        {
            if (a == b & b == c)
                return "Tam giac deu";
            else if (a == b || b == c || a == c)
            {
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    return "Tam giac vuong can";
                else
                    return "Tam giac can";
            }
            else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                return "Tam giac vuong";
            else
                return "Tam giac thuong";
        }
        else
        {
            return "Khong phai tam giac";
        }
    }
       
}
class Program
{
    static void Main()
    {
        TamGiac tamGiac = new TamGiac();
        tamGiac.Nhap();
        tamGiac.KiemTra();
    }
}
