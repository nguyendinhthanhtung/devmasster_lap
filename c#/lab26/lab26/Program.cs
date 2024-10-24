namespace lab26
{
    internal class Program
    {
        /// <summary>
        /// một số thao tác với mảng 1 chiều 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //khai báo và khởi tạo mảng 1 chiều 
            int[] m = { 5, 8, 3, 0, 2, 1, 7, 8 };
            //duyệt mnagr và in ra dữ liệu 
            Console.WriteLine("cac phan tu cua mang ");
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine("{0},m[i]");
            }
            //tìm phần tử lớn nhất 
            int max =m[0];
            for (int i = 0; i < m.Length; i++) 
            {
                if (max < m[i])
                    max = m[i];
            }
            Console.WriteLine("\n phan tu lon nhat: " + max);
            //kiểm tra mảng có đối xứng không 
            bool kt = true;
            for (int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
                Console.WriteLine("mang doi xung ");
            else
                Console.WriteLine("mang khong doi xung");
        }
    }
}
