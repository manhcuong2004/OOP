    using System;

    public abstract class Edition
    {
        public string tieude, tacgia;

        public static void Sort(Edition[] editions)
        {
            Array.Sort(editions, CompareTo);
        }

        private static int CompareTo(Edition x, Edition y)
        {
            return x.tacgia.CompareTo(y.tacgia);
        }

        public abstract void Xuat();
    }

    public class Book : Edition
    {
        public string Nam, NhaXuatBan;

        public override void Xuat()  
        {
            Console.WriteLine($"Sach: {tieude}, tac gia {tacgia}, nha xuat ban {NhaXuatBan}, {Nam}");
        }
    }

    public class Article : Edition
    {
        public string TapChi;

        public override void Xuat()
        {
            Console.WriteLine($"Bai bao: {tieude}, tac gia {tacgia}, xuat ban trong tap chi {TapChi}");
        }
    }

    public class OnlineResource : Edition
    {
        public string Link;
        public string TomTat;

        public override void Xuat()
        {
            Console.WriteLine($"Tai nguyen truc tuyen: {tieude}, tac gia {tacgia}, link: {Link}, Tom tat: {TomTat}");
        }
    }
    class Program
    {
        static void Main()
        {
            Edition[] A = new Edition[]
            {
                new Book { tieude = "Doraemon", tacgia = "Fujiko. F. Fujio", Nam = "1969", NhaXuatBan = "Kimdong" },
                new Article { tieude = "Thanh nien", tacgia = "MC", TapChi = "vui ve" },
                new OnlineResource { tieude = "luyen Code", tacgia = "John", Link = "luyencode.com", TomTat = "Tub" }
            };

            Console.WriteLine("Danh sach:");
            foreach (var c in A)
            {
                c.Xuat();
            }

            Console.WriteLine("\nTim kiem tac gia:");
            string timtg = Console.ReadLine();
            bool found = false;

            foreach (var c in A)
            {
                if (c.tacgia == timtg)
                {
                    c.Xuat();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Khong tim thay tac gia");
            }
        }
    }
