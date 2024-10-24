namespace Lab07._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Business.House h = new Business.House();
            h.HouseNo = "D294FF";
            h.Price = 425880;
            Console.WriteLine("House Detail");
            Console.WriteLine("\t House No:"+h.HouseNo);
            Console.WriteLine("\t Price:"+h.Price);
            Business.DeaLership.Car c=new Business.DeaLership.Car();
            c.CarNo = "A0999";
            c.Price = 38425.50M;
            Console.WriteLine("car detail");
            Console.WriteLine("\t Car No:" + h.HouseNo);
            Console.WriteLine("\t Price:"+ h.Price);
        }
    }
}
