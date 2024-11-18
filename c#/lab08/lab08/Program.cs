﻿using System.Data;

namespace lab08
{
    internal class Program
    {
        /// <summary>
        /// chương trình minh hoạ việc sử dụng một số thao tác trên dữ lệu sử dụng câu lệnh LINQ
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //khởi tạo tập dữ liệu 
            string[] data = { "To","ve","hon","nguoi","thi","nguoi","se",
            "tro","thanh","ke","thu","cua","ta","chiu","nhuong","nguoi",
            "thi","nguoi","se","la","ban","cua","ta"};
            //truy vấn dữ liệu 
            IEnumerable<string> result1 = from m in data select m;
            //hiển thỉ kêt quả 
            Console.WriteLine("Hien thi tat ca ket qua");
            foreach (var item in result1)
            {
                Console.Write(item + "");

            }
            //truy vấn theo điều kiện lấy các từ là "nguoi"
            IEnumerable<string> result2= from m in data where m.Equals("nguoi") select m;
            //hiển thị kết quả 
            Console.WriteLine("\n Truy van theo dieu kien  ");
            foreach(var item in result2)
            {
                Console.WriteLine(item + "");
            }    
            //sắp xếp dữ liệu 
            IEnumerable<string> result3= from m in data orderby m select m;
            //hiển thị kết quả 
            Console.WriteLine("hien thi tat ca ket qua sap xep ");
            foreach (var item in result3)
            {
                Console.Write(item + "");
            }
            //lấy tập dữ liệu mới 
            var result4 = from m in data select (Thuong: m.ToLower(), Hoa: m.ToUpper());
            //hiển thị kết quả 
            Console.WriteLine("chu thuong va hoa");
            foreach (var item in result4) 
            {
                Console.WriteLine(item.Thuong+":"+item.Hoa);
            }

        }
    }
}
