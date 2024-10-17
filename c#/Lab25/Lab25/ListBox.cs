using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25
{
    internal class ListBox:Window
    {
        //khai báo trường mới 
        private string ListBoxContents;
        //phương thức khởi tạo 
        public ListBox(int top,int left,string contents )
            :base(top,left)// gọi consteuctor lớp cơ sở 
        { 
            ListBoxContents = contents;
        }
        //ghi đè phương thức DrawWindown
        public override void DrawWindow()
        {
            base.DrawWindow();//gọi phương thức lớp cơ sở 
            Console.WriteLine("Writing string to the ListBox:{0}",
                ListBoxContents);
        }
    }
}
