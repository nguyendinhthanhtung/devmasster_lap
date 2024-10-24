﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat.AnCO
{
    internal class Bo
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public double Weight {  get; set; }
        public Bo(int id, string name, double weight) 
        {
            ID = id;
            Name = name;
            Weight = weight;    
        }
        public String GetInfo()
        {
            return $"Bo-Id:(ID),Name:(Name),Weight:(Weight)kg";
        }
    }
    internal class Trau
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public Trau(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
        public String GetInfo()
        {
            return $"Trau-Id:(ID),Name:(Name),Weight:(Weight)kg";
        }
    }
    internal class De
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public De(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
        public String GetInfo()
        {
            return $"De-Id:(ID),Name:(Name),Weight:(Weight)kg";
        }
    }
}
