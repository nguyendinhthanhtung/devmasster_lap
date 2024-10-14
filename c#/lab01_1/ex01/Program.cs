namespace ex01
{ /// <summary>
/// Author:nguyendinhthanhtung
/// date:14/10/2024
/// chương Trình C# dầu tiên 
/// in ra thông tin bản thân 
/// </summary>
    internal class Program
    { 
        static void Main(string[] args)

        {//lệnh in ra chữ tiếng việt 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //lệnh in ra mnaf hình dòng văn bản và xuống dòng 
            Console.WriteLine("Họ và tên : nguyễn đình thanh tùng ");
            //lệnh in ra có định dạng 
            Console.WriteLine("ngày sinh:{0}", "21/10/2003");
            Console.WriteLine("Địa chỉ:chung trinh\n"  );
            Console.WriteLine("điện thoại :0326001258");
        }
    }
}
