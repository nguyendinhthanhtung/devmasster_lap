namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            string name = "david";
            byte age = 45;
            char gender = 'm';
            //khai báo hàm 
            const float percent = 75.50F;
            //hiển thị giá trị 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("mã số:{0}", id);
            Console.WriteLine("tên:" + name);
            Console.WriteLine("tuổi:{0}", name);
            Console.WriteLine("giới tính :{0}",gender);
            Console.WriteLine("percentage:{0}", percent);

        }
    }
}
