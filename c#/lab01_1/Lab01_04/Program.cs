namespace Lab01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo các biến để lưu trữ thông tin của nhân viên
            string maNhanVien = "NV001";
            string hoTen = "Nguyễn Đình Thanh Tùng ";
            string ngaySinh = "21/10/2003";
            string diaChi = "123 Đường ABC, Hà Nội";
            string dienThoai = "0901234567";
            string email = "nguyendinhthanhtung@gmail.com";

            // Hiển thị thông tin nhân viên
            Console.WriteLine("Thông tin Nhân Viên:");
            Console.WriteLine($"Mã Nhân Viên: {maNhanVien}");
            Console.WriteLine($"Họ Tên: {hoTen}");
            Console.WriteLine($"Ngày Sinh: {ngaySinh}");
            Console.WriteLine($"Địa Chỉ: {diaChi}");
            Console.WriteLine($"Điện Thoại: {dienThoai}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
