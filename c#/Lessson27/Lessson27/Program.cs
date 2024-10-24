using Store;
namespace Lessson27
{
    internal class Program
           
    {
        static void Main( string[] args) 
        {
            Supply.Manufacturer dealer = new Supply.Manufacturer();
            dealer.Name = "coca cola";
            dealer.Email = "cocacola@gmail.com";
            dealer.phone = "(111)792-8074";
            Console.WriteLine("Dealer infomation");
            Console.WriteLine("\t Name:"+dealer.Name);
            Console.WriteLine("\t Email:" + dealer.Email);
            Console.WriteLine("\t Phone:" + dealer.phone);
            StoreItem si = new StoreItem();
            si.ItemNo = 613508;
            si.ItemName = "fanta";
            si.price = 80.00M;
            Console.WriteLine("Store Iventory");
            Console.WriteLine("\t Item#:");
            Console.WriteLine(si.ItemNo);
            Console.WriteLine("\t Item Name:");
            Console.WriteLine(si.ItemName);
            Console.WriteLine("\t Unit Price:");
            Console.WriteLine(si.price);
            Console.Read();
        }
    }
        }
    

