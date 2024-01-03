using System.Runtime.CompilerServices;
abstract class Canho
{
    public string ID, Floor;
    public double Area, Price;
    public double giamax;
    public static Canho Giacaonhat;
    public Canho(string id, string fl, double ar, double pr)
    {
        ID = id;
        Floor = fl;
        Area = ar;
        Price = pr;
    }
    public abstract double Giaban();
    public abstract void Xuat();
    public void GiaMax()
    {
        if(Giaban()>giamax)
        {
            giamax = Giaban();
            Giacaonhat=this;
        }
    }
    public static void CanhoGCN()
    {
        Console.WriteLine("Can ho co gia cao nhat:");
        Giacaonhat.Xuat();
    }

}
class Basic : Canho
{
    public Basic(string id, string fl, double ar, double pr) : base(id, fl, ar, pr)
    {
        GiaMax();
    }
    public override double Giaban()
    {
        return Price * Area;
        
    }
    public override void Xuat()
    {
        Console.WriteLine($"ID:{ID}, floor: {Floor}, Area: {Area}, Gia co ban: {Price}, Gia cho thue: {Giaban()}");
    }
}
class Condo : Canho
{
    public string View;
    public Condo(string id, string fl, double ar, double pr, string view) : base(id, fl, ar, pr)
    {
        View = view;
        GiaMax();
    }
    public override double Giaban()
    {
        if (View == "Bien")
        {
            return Price * Area *1.4;
        }
        else if (View == "Ho boi")
        {
            return Price * Area*1.1;
        }
        else if (View == "Thanh pho")
        {
            return Price * Area*1.2;
        }
        else
        {
            return Price * Area*1;
        }
    }
    public override void Xuat()
    {
        Console.WriteLine($"ID:{ID}, floor: {Floor}, Area: {Area}, Gia co ban: {Price}, View: {View}, Gia cho thue: {Giaban()}");
    }
}
class Program
{
    static void Main()
    {
        Canho ch1 = new Basic("001", "2", 80, 120000);
        Canho ch2 = new Condo("002", "4", 200, 120000, "Bien");
        ch1.Xuat();
        ch2.Xuat();
        Canho.CanhoGCN();
    }
}