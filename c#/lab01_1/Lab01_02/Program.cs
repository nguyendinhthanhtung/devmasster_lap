namespace Lab01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo các biến 
            int id = 1;
            string name = "david geore";
            byte age = 18;
            char gender = 'M';
            //khai báo hằng số 
            const float percent = 75.50;
            //hiển thị giá trị các biến và hằng số 
            Console.WriteLine("Student ID:{0}", id);
            Console.WriteLine("Student Name:{0}", name);
            Console.WriteLine("age :", age);
            Console.WriteLine("Gender :" + gender);
            Console.WriteLine("percentage:{0}",percent);
        }
    }
}
