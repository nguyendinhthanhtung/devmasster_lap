﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    /// <summary>
    /// lớp sinh viên cao đẳng kế thừa từ lớp sinh viên
    /// </summary>
    internal class StudentCollege:Student 
    {
        protected double score1,score2,score3;
        //constructor
        public StudentCollege(String name,int year,double score1,double score2,
            double score3):base(name,year)
        {
            this.score1 = score1;
            this.score2 = score2;   
            this.score3 = score3;   
        }
        //ghi đè phương thức tính trung bình điểm 
        public override double Average()
        {
           return(score1+score2+score3)/3;
        }
        //hiển thị thông tin 
        public new void Display() 
        {
            base.Display();
            Console.WriteLine("Score 1:{0:N}", score1);
            Console.WriteLine("Score 2:{0:N}", score2);
            Console.WriteLine("Score 3:{0:N}", score3);

        }
    }
}
