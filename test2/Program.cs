public abstract class Canho
{
    public string ID, Floor;
    public double Price,Area;
    public static double GiaCaoNhat = 0;
    public static Canho CanhoGiaCaoNhat;
    public Canho(string id, double dt, string fl,double gia )
    {
        ID=id;
        Area=dt;
        Floor=fl;
        Price=gia;
    }
    public abstract double Gia();
    public abstract void Xuat();
    public void UpdateGiaCaoNhat()
    {
        if (Gia()>GiaCaoNhat)
        {
            GiaCaoNhat = Gia();
            CanhoGiaCaoNhat = this;
        }
    }
    public static void InforGiacn()
    {
        Console.WriteLine("Gia cao nhat: ");
        CanhoGiaCaoNhat.Xuat();
    } 
    
}
public class Basic : Canho
{
    public Basic(string id, double dt, string fl,double gia ) : base(id,dt,fl,gia)
    {
        UpdateGiaCaoNhat();
    }
    
    public override double Gia()
    {
        return Price * Area;
    }
    public override void Xuat()
    {
        Console.WriteLine($"ID: {ID}, area: {Area}, floor: {Floor}, price: {Price}, Gia thue: {Gia()}");
    }
}
public class Caodo : Canho
{
    public string View;
    public Caodo(string id, double dt, string fl,double gia,string view ) : base(id,dt,fl,gia)
    {
        View = view;
        UpdateGiaCaoNhat();
    }
    
    public override double Gia()
    {
        if (View == "Bien")
        {
            return Price * Area*1.4;
        }
        else if (View == "Thanh pho")
        {
            return Price * Area * 1.2;
        }
        else if (View == "Ho boi")
        {
            return Price * Area * 1.1;
        }
        else
        {
            return Price * Area * 1.0;
        }
    }
    public override void Xuat()
    {
        Console.WriteLine($"ID: {ID}, area: {Area}, floor: {Floor}, price: {Price}, view: {View}, Gia thue: {Gia()}");
    }
}
class Program
{
    static void Main()
    {
        
        Canho ch1= new Basic("1203",30,"2",100000);
        Canho ch2= new Caodo("1290",40,"3",150000,"Bien");
        
        ch1.Xuat();
        ch2.Xuat();
        Canho.InforGiacn();
    
    }
    
}