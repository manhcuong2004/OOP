using System;
using System.Collections.Generic;
using System.Linq;
class BatDongSan
{
    public string MaBDS { get; set; }
    public string TenBDS { get; set; }
    public string Huong { get; set; }
    public string DiaChi { get; set; }
    public double DienTich { get; set; }
    public double GiaBan { get; set; }
}

class DanhSachBDS
{
    private List<BatDongSan> danhSach;

    public DanhSachBDS()
    {
        danhSach = new List<BatDongSan>();
    }

    public void ThemBDS(BatDongSan bds)
    {
        danhSach.Add(bds);
    }
    public void SuaBDS(string maBDS, BatDongSan bds)
    {
        var bdsCanSua = danhSach.FirstOrDefault(b => b.MaBDS == maBDS);
        if (bdsCanSua != null)
        {
            bdsCanSua.TenBDS = bds.TenBDS;
            bdsCanSua.Huong = bds.Huong;
            bdsCanSua.DiaChi = bds.DiaChi;
            bdsCanSua.DienTich = bds.DienTich;
            bdsCanSua.GiaBan = bds.GiaBan;
        }
    }

    public void XoaBDS(string maBDS)
    {
        danhSach.RemoveAll(b => b.MaBDS == maBDS);
    }

    public void XuatDanhSach()
    {
        foreach (var bds in danhSach)
        {
            Console.WriteLine($"Mã BDS: {bds.MaBDS}");
            Console.WriteLine($"Tên BDS: {bds.TenBDS}");
            Console.WriteLine($"Hướng: {bds.Huong}");
            Console.WriteLine($"Địa chỉ: {bds.DiaChi}");
            Console.WriteLine($"Diện tích: {bds.DienTich} m2");
            Console.WriteLine($"Giá bán: {bds.GiaBan} VNĐ");
            Console.WriteLine();
        }
    }

    public void TimTheoTen(string tenBDS)
    {
        var ketQua = danhSach.Where(b => b.TenBDS == tenBDS).ToList();
        if (ketQua.Count > 0)
        {
            Console.WriteLine("Kết quả tìm kiếm:");
            foreach (var bds in ketQua)
            {
                Console.WriteLine($"Mã BDS: {bds.MaBDS}");
                Console.WriteLine($"Tên BDS: {bds.TenBDS}");
                Console.WriteLine($"Hướng: {bds.Huong}");
                Console.WriteLine($"Địa chỉ: {bds.DiaChi}");
                Console.WriteLine($"Diện tích: {bds.DienTich} m2");
                Console.WriteLine($"Giá bán: {bds.GiaBan} VNĐ");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy bất động sản nào có tên là " + tenBDS);
        }
    }

    public void TimTheoHuong(string huong)
    {
        var ketQua = danhSach.Where(b => b.Huong == huong).ToList();
        if (ketQua.Count > 0)
        {
            Console.WriteLine("Kết quả tìm kiếm theo hướng " + huong + ":");
            foreach (var bds in ketQua)
            {
                Console.WriteLine($"Mã BDS: {bds.MaBDS}");
                Console.WriteLine($"Tên BDS: {bds.TenBDS}");
                Console.WriteLine($"Hướng: {bds.Huong}");
                Console.WriteLine($"Địa chỉ: {bds.DiaChi}");
                Console.WriteLine($"Diện tích: {bds.DienTich} m2");
                Console.WriteLine($"Giá bán: {bds.GiaBan} VNĐ");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy bất động sản nào có hướng là " + huong);
        }
    }

    public void TimTheoGia(double giaMin, double giaMax)
    {
        var ketQua = danhSach.Where(b => b.GiaBan >= giaMin && b.GiaBan <= giaMax)
                            .OrderBy(b => b.GiaBan)
                            .ToList();
        if (ketQua.Count > 0)
        {
            Console.WriteLine($"Kết quả tìm kiếm theo khoảng giá từ {giaMin} VNĐ đến {giaMax} VNĐ:");
            foreach (var bds in ketQua)
            {
                Console.WriteLine($"Mã BDS: {bds.MaBDS}");
                Console.WriteLine($"Tên BDS: {bds.TenBDS}");
                Console.WriteLine($"Hướng: {bds.Huong}");
                Console.WriteLine($"Địa chỉ: {bds.DiaChi}");
                Console.WriteLine($"Diện tích: {bds.DienTich} m2");
                Console.WriteLine($"Giá bán: {bds.GiaBan} VNĐ");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy bất động sản nào trong khoảng giá từ " + giaMin + " VNĐ đến " + giaMax + " VNĐ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DanhSachBDS danhSachBDS = new DanhSachBDS();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Thêm mới danh sách");
            Console.WriteLine("2: Sửa thông tin");
            Console.WriteLine("3: Xóa thông tin");
            Console.WriteLine("4: Xuất danh sách");
            Console.WriteLine("5: Tìm theo Tên");
            Console.WriteLine("6: Tìm theo Hướng");
            Console.WriteLine("7: Tìm theo Giá");
            Console.WriteLine("0: Exit");

            Console.Write("Nhập lựa chọn: ");
            int luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    Console.WriteLine("Nhập thông tin bất động sản mới:");
                    BatDongSan bdsMoi = new BatDongSan();
                    Console.Write("Mã BDS: ");
                    bdsMoi.MaBDS = Console.ReadLine();
                    Console.Write("Tên BDS: ");
                    bdsMoi.TenBDS = Console.ReadLine();
                    Console.Write("Hướng: ");
                    bdsMoi.Huong = Console.ReadLine();
                    Console.Write("Địa chỉ: ");
                    bdsMoi.DiaChi = Console.ReadLine();
                    Console.Write("Diện tích (m2): ");
                    bdsMoi.DienTich = double.Parse(Console.ReadLine());
                    Console.Write("Giá bán (VNĐ): ");
                    bdsMoi.GiaBan = double.Parse(Console.ReadLine());

                    danhSachBDS.ThemBDS(bdsMoi);
                    break;

                case 2:
                    Console.Write("Nhập mã BDS cần sửa: ");
                    string maBDS = Console.ReadLine();
                    BatDongSan bdsSua = new BatDongSan();
                    Console.Write("Tên BDS: ");
                    bdsSua.TenBDS = Console.ReadLine();
                    Console.Write("Hướng: ");
                    bdsSua.Huong = Console.ReadLine();
                    Console.Write("Địa chỉ: ");
                    bdsSua.DiaChi = Console.ReadLine();
                    Console.Write("Diện tích (m2): ");
                    bdsSua.DienTich = double.Parse(Console.ReadLine());
                    Console.Write("Giá bán (VNĐ): ");
                    bdsSua.GiaBan = double.Parse(Console.ReadLine());

                    danhSachBDS.SuaBDS(maBDS, bdsSua);
                    break;

                case 3:
                    Console.Write("Nhập mã BDS cần xóa: ");
                    string maXoa = Console.ReadLine();
                    danhSachBDS.XoaBDS(maXoa);
                    break;

                case 4:
                    danhSachBDS.XuatDanhSach();
                    break;

                case 5:
                    Console.Write("Nhập tên BDS cần tìm: ");
                    string tenTim = Console.ReadLine();
                    danhSachBDS.TimTheoTen(tenTim);
                    break;

                case 6:
                    Console.Write("Nhập hướng cần tìm: ");
                    string huongTim = Console.ReadLine();
                    danhSachBDS.TimTheoHuong(huongTim);
                    break;

                case 7:
                    Console.Write("Nhập giá bán thấp nhất (VNĐ): ");
                    double giaMin = double.Parse(Console.ReadLine());
                    Console.Write("Nhập giá bán cao nhất (VNĐ): ");
                    double giaMax = double.Parse(Console.ReadLine());
                    danhSachBDS.TimTheoGia(giaMin, giaMax);
                    break;

                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }
}
