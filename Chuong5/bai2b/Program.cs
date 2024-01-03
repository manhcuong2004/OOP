using System;
using System.Collections.Generic;

class People
{
    protected int ID;
    protected string Hoten;
    protected int Tuoi;
    protected string Diachi;

    public void Nhap()
    {
        ID = int.Parse(Console.ReadLine());
        Hoten = Console.ReadLine();
        Tuoi = int.Parse(Console.ReadLine());
        Diachi = Console.ReadLine();
    }

    public void Xuat()
    {
        Console.Write("Ma {0}, Ho ten {1}, Tuoi {2}, Dia chi {3}", ID, Hoten, Tuoi, Diachi);
    }

    public People(int ID, string Hoten, int Tuoi, string Diachi)
    {
        this.ID = ID; this.Hoten = Hoten; this.Tuoi = Tuoi; this.Diachi = Diachi;
    }
}

class Students : People
{
    protected string Term;
    protected double TP1;
    protected double TP2;
    protected double TP3;

    public Students(int ID, string Hoten, int Tuoi, string Diachi, string Term, double TP1, double TP2, double TP3) : base(ID, Hoten, Tuoi, Diachi)
    {
        this.Term = Term; this.TP1 = TP1; this.TP2 = TP2; this.TP3 = TP3;
    }

    public void GPA()
    {
        double a = TP1 * 0.3 + TP2 * 0.1 + TP3 * 0.6;
        if (a >= 8.0)
        {
            Console.WriteLine("diem tb {0} xep loai :A", a);
        }
        else if (a >= 7)
        {
            Console.WriteLine("diem tb {0} xep loai :B", a);
        }
        else if (a >= 6)
        {
            Console.WriteLine("diem tb {0} xep loai :C", a);
        }
        else if (a < 6)
        {
            Console.WriteLine("diem tb {0} xep loai 😃", a);
        }
    }

    public new void Xuat()
    {
        Console.Write("Ma {0}, Ho ten {1}, Tuoi {2}, Dia chi {3} , hoc phan {4}", ID, Hoten, Tuoi, Diachi, Term);
        GPA();
    }
}

class Lecture : People
{
    public List<double> c = new List<double>();
    protected double Kinhnghiem;
    protected string Hocvi;
    protected string Chucvu;

    public Lecture(int ID, string Hoten, int Tuoi, string Diachi, double Kinhnghiem, string Hocvi, string Chucvu) : base(ID, Hoten, Tuoi, Diachi)
    {
        this.Kinhnghiem = Kinhnghiem;
        this.Hocvi = Hocvi;
        this.Chucvu = Chucvu;
    }

    public void SapXep(List<Lecture> b)
    {
        foreach (Lecture a in b)
        {
            c.Add(a.Kinhnghiem);
        }
        c.Sort();
        for (int i = 0; i < c.Count - 1; i++)
        {
            if (c[i] == c[i + 1])
            {
                c.RemoveAt(i + 1);
                i -= 1;
            }
        }
        foreach (double s in c)
        {
            foreach (Lecture a in b)
                if (a.Kinhnghiem == s)
                {
                    Console.WriteLine("Ma {0}, Ho ten {1}, Tuoi {2}, Dia chi {3} , Kinh nghiem {4} , hoc vi {5} , chucvu {6}", a.ID, a.Hoten, a.Tuoi, a.Diachi, a.Kinhnghiem, a.Hocvi, a.Chucvu);
                }
        }
    }
}

class Chinh
{
    static void Main(string[] args)
    {
        List<Lecture> b = new List<Lecture>();

        Students std = new Students(123, "tun", 19, "do ba", "OOP", 10, 6, 10);
        std.Xuat();
        Students std1 = new Students(13, "tun2", 19, "do ba", "OOP", 7, 6, 10);
        std1.Xuat();

        Lecture gv1 = new Lecture(133, "TUN0", 19, "do ba", 9, "11","GS");
        Lecture gv2 = new Lecture(143, "TUN1", 19, "do ba", 2.5, "11", "TS");
        Lecture gv3 = new Lecture(153, "TUN2", 19, "do ba", 7, "11", "TS");

        b.Add(gv1);
        b.Add(gv2);
        b.Add(gv3);
        gv1.SapXep(b);
    }
}