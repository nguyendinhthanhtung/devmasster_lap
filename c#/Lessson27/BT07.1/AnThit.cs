using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat.AnThit
{
    internal class CaSau
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public CaSau(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
        public String GetInfo()
        {
            return $"CaSau-Id:(ID),Name:(Name),Weight:(Weight)kg";
        }
    }
    internal class Ho
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public Ho(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
        public String GetInfo()
        {
            return $"Ho-Id:(ID),Name:(Name),Weight:(Weight)kg";
        }
    }
    internal class SuTu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public SuTu(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
        public String GetInfo()
        {
            return $"SuTu-Id:(ID),Name:(Name),Weight:(Weight)kg";
        }
    }
}
