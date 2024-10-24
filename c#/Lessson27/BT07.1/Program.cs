using DongVat.AnCO;
using DongVat.AnThit;

namespace BT07._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bo bo = new Bo(1, "Bo", 500.5);
            Trau trau = new Trau(2, "Trau", 600.2);
            De de = new De(3, "De", 80.0);

           CaSau caSau = new CaSau(4, "Ca Sau", 300.3);
            Ho ho = new Ho(5, "Ho", 200.7);
            SuTu suTu = new SuTu(6, "Su Tu", 250.5);

            Console.WriteLine($"Bo: ID={bo.ID}, Name={bo.Name}, Weight={bo.Weight}");
            Console.WriteLine($"Trau: ID={trau.ID}, Name={trau.Name}, Weight={trau.Weight}");
            Console.WriteLine($"De: ID={de.ID}, Name={de.Name}, Weight={de.Weight}");
            Console.WriteLine($"Ca Sau: ID={caSau.ID}, Name={caSau.Name}, Weight={caSau.Weight}");
            Console.WriteLine($"Ho: ID={ho.ID}, Name={ho.Name}, Weight={ho.Weight}");
            Console.WriteLine($"Su Tu: ID={suTu.ID}, Name={suTu.Name}, Weight={suTu.Weight}");
        }
    }
}
