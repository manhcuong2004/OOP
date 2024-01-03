    using System;
    class People
    {
        public int ID,Tuoi;
        public string HoTen, DiaChi;
        public People(int id, string hoten, int tuoi, string diachi)
        {
            ID = id;
            HoTen = hoten;
            Tuoi = tuoi;
            DiaChi = diachi;
        }
        public void Xuat()
        {
            Console.WriteLine($"id: {ID}");
            Console.WriteLine($"ho ten: {HoTen}");
            Console.WriteLine($"tuoi {Tuoi}");
            Console.WriteLine($"dia chi: {DiaChi}");
        }
    }

    class Students : People
    {
        public string Term;
        public double TP1, TP2, TP3;

        public Students(int id, string hoten, int tuoi, string diachi, string term, double Tp1, double Tp2, double Tp3)
            : base(id, hoten, tuoi, diachi)
        {
            Term = term;
            TP1 = Tp1;
            TP2 = Tp2;
            TP3 = Tp3;
        }

        public double GPA()
        {
            return 4 * (TP1 + TP2 + TP3) / 10;
        }

        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Hocki: {Term}");
            Console.WriteLine($"Diem tp 1: {TP1}");
            Console.WriteLine($"Diem tp 2: {TP2}");
            Console.WriteLine($"Diem tp 3: {TP3}");
            Console.WriteLine($"Diem trung binh: {GPA()}");
        }
    }

    class Lecture : People
    {
        protected double Kinhnghiem;
        protected string Hocvi, Chucvu;

        public Lecture(int id, string hoten, int tuoi, string diachi, double kinhnghiem, string hocvi, string chucvu)
            : base(id, hoten, tuoi, diachi)
        {
            Kinhnghiem = kinhnghiem;
            Hocvi = hocvi;
            Chucvu = chucvu;
        }
        public void SapXep(List<Lecture> A)
        {
            List<double> c = new List<double>();

            foreach (Lecture a in A)
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

            foreach (double m in c)
            {
                foreach (Lecture a in A)
                    if (a.Kinhnghiem == m)
                    {

                        Console.WriteLine($"Ma {a.ID}"); 
                        Console.WriteLine($"Ho ten {a.HoTen}");
                        Console.WriteLine($"Tuoi {a.Tuoi}");
                        Console.WriteLine($"Dia chi {a.DiaChi}");
                        Console.WriteLine($"Kinh nghiem {a.Kinhnghiem}");
                        Console.WriteLine($"Hoc vi {a.Hocvi}");
                        Console.WriteLine($"Chuc vu {a.Chucvu}");
                    }
            }
        }
    }

    class Chinh
    {
        static void Main(string[] args)
        {
            List<Lecture> b = new List<Lecture>();

            Students hs1 = new Students(001, "mazza", 19, "khue my dong", "OOP", 10, 6, 10);
            hs1.Xuat();

            Students hs2 = new Students(002, "ssunn", 19, "khue my dong", "OOP", 7, 6, 10);
            hs2.Xuat();

            Lecture gv1 = new Lecture(001, "ina", 23, "khue my dong", 4, "Ths", "Giang vien");
            Lecture gv2 = new Lecture(002, "suji", 34, "khue my dong", 9, "Gs", "Truong khoa");
            Lecture gv3 = new Lecture(003, "mana", 20, "khue my dong", 1, "Ths", "Giang vien");

            b.Add(gv1);
            b.Add(gv2);
            b.Add(gv3);

            gv1.SapXep(b);
        }
    }
