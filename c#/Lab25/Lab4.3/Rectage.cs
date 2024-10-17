using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    internal class Rectage: Shape

    {
        //phương thức nhập 
        public void InputData() 
        {
            Console.Write("nhap chieu dai:");
            leght= int.Parse(Console.ReadLine());
            Console.Write("nhap chieu rong:");
            width= int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích 
        public override float Area()
        {
            return leght*width;
        }
        //ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2*leght*width;
        }

    }
}
