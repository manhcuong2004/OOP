using System;
class Canho
{
    public string ID;
    public double Area, Floor, Price;
    public static double GiaCaoNhat = 0;
    public static Canho CanhoGiaCaoNhat;
    public Canho(string id, double area, double floor, double price)
    {
        ID = id;
        Area = area;
        Floor = floor;
        Price = price;
        UpdateGiaCaoNhat();
    }
    public virtual double GiaBan()
    {
        return 0;
    }
    public void Xuat()
    {
    }
    public void UpdateGiaCaoNhat()
    {
        if (GiaBan() > GiaCaoNhat)
        {
            GiaCaoNhat = GiaBan();
            CanhoGiaCaoNhat = this;
        }
    }
    public static void CHGCN()
    {
        Console.WriteLine("Can ho gia cao nhat: ");
        CanhoGiaCaoNhat.Xuat();
    }
}

class Chcb : Canho
{
    public Chcb(string id, double area, double floor, double price) : base(id, area, floor, price)
    {
        UpdateGiaCaoNhat();
    }

    public override double GiaBan()
    {
        return Price * Area;
    }

    public void Xuat()
    {
        Console.WriteLine($"id {ID}, diện tích {Area}, tầng {Floor}, giá cơ bản {Price}, Giá bán là {GiaBan()} ");
    }
}

class Chcc : Canho
{
    public string View;

    public Chcc(string id, double area, double floor, double price, string view) : base(id, area, floor, price)
    {
        View = view;
        UpdateGiaCaoNhat();
    }

    public override double GiaBan()
    {
        if (View == "Bien")
        {
            return Price * Area * 1.4;
        }
        else if (View == "Ho Boi")
        {
            return Price * Area * 1.1;
        }
        else if (View == "Thanh Pho")
        {
            return Price * Area * 1.2;
        }
        else
        {
            return Price * Area * 1;
        }
    }

    public void Xuat()
    {
        Console.WriteLine($"id {ID}, diện tích {Area}, tầng {Floor}, giá cơ bản {Price}, View {View}, Giá bán là {GiaBan()}");
    }
}

class Program
{
    static void Main()
    {
        Chcb ch1 = new Chcb("001", 100, 2, 122);
        Chcc ch2 = new Chcc("002", 400, 3, 2112, "Bien");
        Chcc ch3 = new Chcc("003", 300, 3, 2322, "Khac");

        ch1.Xuat();
        ch2.Xuat();
        ch3.Xuat();
        Canho.CHGCN();
    }
}
