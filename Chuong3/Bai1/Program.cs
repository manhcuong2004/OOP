    using System;

    class Sach
    {
        public string Tensach;
        public string Tacgia;
        public int NamXB;
        public int Soluong;
        public Sach(string tensach, string tacgia, int namXB, int soluong)
        {
            Tensach = tensach;
            Tacgia = tacgia;
            NamXB = namXB;
            Soluong = soluong;
        }
        public Sach()
        {
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin sach:");
            Console.Write("Ten sach: ");
            Tensach = Console.ReadLine();
            Console.Write("Tac gia: ");
            Tacgia = Console.ReadLine();
            Console.Write("Nam xuat ban: ");
            NamXB = int.Parse(Console.ReadLine());
            Console.Write("So luong: ");
            Soluong = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Thong tin sach:");
            Console.WriteLine("Ten sach: " + Tensach);
            Console.WriteLine("Tac gia: " + Tacgia);
            Console.WriteLine("Nam xuat ban: " + NamXB);
            Console.WriteLine("So luong: " + Soluong);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sach sach1 = new Sach("Doraemon", "Fujiko", 1969, 2);
            Sach sach2 = new Sach();
            Sach sach3 = new Sach();
            sach1.Xuat();

            sach2.Nhap();
            sach2.Xuat();

            sach3.Nhap();
            sach3.Xuat();
        }
    }
