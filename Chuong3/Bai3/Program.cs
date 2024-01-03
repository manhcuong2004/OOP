using System;

class Organization
{
    public string Name = "";
    public string Country = "";
    public string City = "";
    public string Address = "";
    public string Telephone = "";

    public void Nhap()
    {
        Console.Write("Ten doanh nghiep: ");
        Name = Console.ReadLine();
        Console.Write("Quoc gia: ");
        Country = Console.ReadLine();
        Console.Write("Thanh pho: ");
        City = Console.ReadLine();
        Console.Write("Dia chi: ");
        Address = Console.ReadLine();
        Console.Write("So dien thoai: ");
        Telephone = Console.ReadLine();
    }

    public void Xuat()
    {
        Console.WriteLine("Thong tin doanh nghiep:");
        Console.WriteLine("Ten: " + Name);
        Console.WriteLine("Quoc gia: " + Country);
        Console.WriteLine("Thanh pho: " + City);
        Console.WriteLine("Dia chi: " + Address);
        Console.WriteLine("So dien thoai: " + Telephone);
    }
}

class Program
{
    static void Main()
    {
        Organization organization = new Organization();

        organization.Nhap();

        if (!string.IsNullOrEmpty(organization.Name) &&
            !string.IsNullOrEmpty(organization.Country) &&
            !string.IsNullOrEmpty(organization.City) &&
            !string.IsNullOrEmpty(organization.Address) &&
            !string.IsNullOrEmpty(organization.Telephone) &&
            organization.Telephone.Length == 10 &&
            KTSDT(organization.Telephone))
        {
            organization.Xuat();
        }
        else
        {
            Console.WriteLine("Nhap thong tin loi.");
        }
    }
    static bool KTSDT(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}
