using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture {
    public class Furniture{
        public string Navn {get; set;}

        public Furniture(string navn) {
            Navn = navn;
        }
    }
    public class Chair : Furniture {
        public int Kg {get; set;}

        public Chair(string navn, int kg) : base(navn) {
            Kg = kg;
        }
        public void print() {
            Console.WriteLine($"{Navn} {Kg}");
        }

    }
    public class Computer : Furniture
    {
        public string Processor { get; set; }

        public Computer(string navn, string processor) : base(navn)
        {
            Processor = processor;
        }
        public void print()
        {
            Console.WriteLine($"{Navn} {Processor}");
        }

    }
}
