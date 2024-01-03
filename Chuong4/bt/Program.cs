using System;
using System.IO;
using System.Text;
namespace RealEstateSystem
{
    class BatDongSan
    {
        public string MaBDS,TenBDS,Huong,DiaChi,DienTich,GiaBan;
    }
    class BDS
    {
        public int i = 0;
        public BatDongSan[,] res = new BatDongSan[100, 6];
        public int dem = 0;

        public BDS()
        {
            string input = File.ReadAllText(@"bds1.txt");
            int j = 0;
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(';'))
                {
                    res[i, j] = new BatDongSan();
                    switch (j)
                    {
                        case 0:
                            res[i, j].MaBDS = col.Trim();
                            break;
                        case 1:
                            res[i, j].TenBDS = col.Trim();
                            break;
                        case 2:
                            res[i, j].Huong = col.Trim();
                            break;
                        case 3:
                            res[i, j].DiaChi = col.Trim();
                            break;
                        case 4:
                            res[i, j].DienTich = col.Trim();
                            break;
                        case 5:
                            res[i, j].GiaBan = col.Trim();
                            break;
                    }
                    j++;
                }
                i++;
                dem++;
            }
        }

        public void Them()
        {
            if (dem < res.GetLength(0))
            {
                Console.WriteLine("MaBDS : ");
                string moi = Console.ReadLine();
                res[dem, 0].MaBDS = moi;
                Console.WriteLine("TenBDS  : ");
                moi = Console.ReadLine();
                res[dem, 1].TenBDS = moi;
                Console.WriteLine("Huong  : ");
                moi = Console.ReadLine();
                res[dem, 2].Huong = moi;
                Console.WriteLine("DiaChi  : ");
                moi = Console.ReadLine();
                res[dem, 3].DiaChi = moi;
                Console.WriteLine("DienTich   : ");
                moi = Console.ReadLine();
                res[dem, 4].DienTich = moi;
                Console.WriteLine("GiaBan  : ");
                moi = Console.ReadLine();
                res[dem, 5].GiaBan = moi;
                dem++;
            }
        }

        public void Sua()
        {
            int k = 0;
            Console.WriteLine("nhap ma bds can sua");
            string b = Console.ReadLine();
            for (int i = 0; i < dem; i++)
            {
                if (res[i, 0].MaBDS == b)
                {
                    k = 9;
                    Console.WriteLine("sua MaBDS : ");
                    string moi = Console.ReadLine();
                    res[i, 0].MaBDS = moi;
                    Console.WriteLine(" sua TenBDS  : ");
                    moi = Console.ReadLine();
                    res[i, 1].TenBDS = moi;
                    Console.WriteLine(" sua Huong  : ");
                    moi = Console.ReadLine();
                    res[i, 2].Huong = moi;
                    Console.WriteLine("sua DiaChi  : ");
                    moi = Console.ReadLine();
                    res[i, 3].DiaChi = moi;
                    Console.WriteLine("sua DienTich   : ");
                    moi = Console.ReadLine();
                    res[i, 4].DienTich = moi;
                    Console.WriteLine("sua GiaBan  : ");
                    moi = Console.ReadLine();
                    res[i, 5].GiaBan = moi;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("không tìm thấy");
            }
        }

        public void Timtheoten()
        {
            Console.WriteLine("nhap ten bds can tim");
            string b = Console.ReadLine();
            int c = 0;
            for (int i = 0; i < dem; i++)
            {
                if (res[i, 1].TenBDS == b)
                {
                    c = 10;
                    Console.WriteLine("MaBDS : {0} ", res[i, 0].MaBDS);
                    Console.WriteLine("Huong   : {0} ", res[i, 2].Huong);
                    Console.WriteLine("TenBDS  : {0} ", res[i, 1].TenBDS);
                    Console.WriteLine("DiaChi  : {0} ", res[i, 3].DiaChi);
                    Console.WriteLine("DienTich   : {0} ", res[i, 4].DienTich);
                    Console.WriteLine("GiaBan  : {0} ", res[i, 5].GiaBan);   
                }
            }
            if (c == 0)
            {
                Console.WriteLine("Không tồn tại");
            }
        }

        public void Timtheogia()
        {
            Console.WriteLine("nhap gia bds can tim");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c = 0;
            for (int i = 0; i < dem; i++)
            {
                float l = float.Parse(res[i, 5].GiaBan);
                if (float.Parse(a) <= l && l <= float.Parse(b))
                {
                    c = 9;
                    Console.WriteLine("MaBDS : {0} ", res[i, 0].MaBDS);
                    Console.WriteLine("Huong   : {0} ", res[i, 2].Huong);
                    Console.WriteLine("TenBDS  : {0} ", res[i, 1].TenBDS);
                    Console.WriteLine("DiaChi  : {0} ", res[i, 3].DiaChi);
                    Console.WriteLine("DienTich   : {0} ", res[i, 4].DienTich);
                    Console.WriteLine("GiaBan  : {0} ", res[i, 5].GiaBan);
                    
                }
            }
            if (c == 0)
            {
                Console.WriteLine("Không tồn tại");
            }
        }

        public void Timtheohuong()
        {
            Console.WriteLine("nhap huong bds can tim");
            string b = Console.ReadLine();
            int c = 0;
            for (int i = 0; i < dem; i++)
            {
                if (res[i, 2].Huong == b)
                {
                    c = 10;
                    Console.WriteLine("MaBDS : {0} ", res[i, 0].MaBDS);
                    Console.WriteLine("Huong   : {0} ", res[i, 2].Huong);
                    Console.WriteLine("TenBDS  : {0} ", res[i, 1].TenBDS);
                    Console.WriteLine("DiaChi  : {0} ", res[i, 3].DiaChi);
                    Console.WriteLine("DienTich   : {0} ", res[i, 4].DienTich);
                    Console.WriteLine("GiaBan  : {0} ", res[i, 5].GiaBan);
                }
            }
            if (c == 0)
            {
                Console.WriteLine("Không tồn tại");
            }
        }

        public void Xoa()
        {
            Console.WriteLine("nhap ma bds can xoa: ");
            string g = Console.ReadLine();
            for (int i = 0; i < dem; i++)
            {
                if (res[i, 0].MaBDS == g)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        res[i, j] = new BatDongSan();
                    }
                    Console.WriteLine("đã xóa bds: ");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BDS bds = new BDS();
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Bấm 1: Thêm mới danh sách ");
            Console.WriteLine("Bấm 2: Sửa thông tin ");
            Console.WriteLine("Bấm 3: Xóa thông tin ");
            Console.WriteLine("Bấm 4: Xuất danh sách  ");
            Console.WriteLine("Bấm 5: Tìm theo Tên");
            Console.WriteLine("Bấm 6: Tìm theo Hướng ");
            Console.WriteLine("Bấm 7: Tìm theo Giá ");
            Console.WriteLine("Bấm 0: Exit ");

            while (true)
            {
                Console.WriteLine("Nhap lua chon cua ban:");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        bds.Them();
                        break;
                    case 2:
                        bds.Sua();
                        break;
                    case 3:
                        bds.Xoa();
                        break;
                    case 4:
                        for (int i = 0; i < bds.dem; i++)
                        {
                            Console.WriteLine("MaBDS: {0}", bds.res[i, 0].MaBDS);
                            Console.WriteLine("TenBDS: {0}", bds.res[i, 1].TenBDS);
                            Console.WriteLine("Huong: {0}", bds.res[i, 2].Huong);
                            Console.WriteLine("DiaChi: {0}", bds.res[i, 3].DiaChi);
                            Console.WriteLine("DienTich: {0}", bds.res[i, 4].DienTich);
                            Console.WriteLine("GiaBan: {0}", bds.res[i, 5].GiaBan);
                        }
                        break;
                    case 5:
                        bds.Timtheoten();
                        break;
                    case 6:
                        bds.Timtheohuong();
                        break;
                    case 7:
                        bds.Timtheogia();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
