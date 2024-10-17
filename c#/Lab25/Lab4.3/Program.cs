namespace Lab4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //khởi tạo hình chữ nhật 
           Rectage rectage = new Rectage();
            //nhập dữ liệu 
            rectage.InputData();
            //in thông tin ra 
            Console.WriteLine("dien tich hinh cu nhat la:{0:N}", rectage.Area());
            Console.WriteLine("chu vi hinh chu nhat la :{0:N}",rectage.Circumference());
            //khởi tạo hình tròn 
            Circle cir = new Circle();
            //nhập dữ liệu 
            cir.inputData();
            //in ra thông tin 
            Console.WriteLine("dein tich hình tron la:{0:N}",cir.Area());
            Console.WriteLine("chu vi hinh tron la:{0:N}", cir.Circumference());

        }
    }
}
