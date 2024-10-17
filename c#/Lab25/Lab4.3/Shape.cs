using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
   abstract class Shape
    {
        protected float radius, leght, width;
        //khai báo các phương thức trừu tượng 
        public abstract float Area();//tính diện tích 
        public abstract float Circumference();//tính chu vi 
    }
}
