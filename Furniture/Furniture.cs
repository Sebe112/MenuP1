using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture {
    public class Furniture{ // En klasse 
        public string Navn {get; set;}

        public Furniture(string navn) {
            Navn = navn;
        }
    }
    public class Chair : Furniture { // En subKlasse
        public int Kg {get; set;}

        public Chair(string navn, int kg) : base(navn) {
            Kg = kg;
        }
        public void print() { // Skriver variablerne ud
            Console.WriteLine($"{Navn} {Kg}");
        }

    }
    public class Computer : Furniture { // Endu en subKlasse
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
