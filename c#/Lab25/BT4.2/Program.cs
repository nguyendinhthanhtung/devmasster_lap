﻿namespace BT4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            NhanVienBanHang nvbh = new NhanVienBanHang();
            Console.WriteLine("Nhan vien ban hang");
            nvbh.HienThi("damquocdan", "tuson");
            Console.WriteLine("Luong{0}", nvbh.TinhLuong(30, 1500));
            CongNhan cn = new CongNhan();
            Console.WriteLine("cong nhan");
            cn.HienThi("Manh QUan", "tienbao");
            Console.WriteLine("Luong{0}", cn.TinhLuong(123, 454));

            Console.ReadKey();
        }
    }
}