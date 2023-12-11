using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bøger {
    public class Bog {
        public string Titel {get; set;}
        public int Pris {get; set;}

        public Bog(string titel,int pris) {
            Titel = titel;
            Pris = pris;
        }

        public void PrintInfo() {
            Console.WriteLine($"{Titel} - koster {Pris} kr.");
        }
        public bool HarRåd(int penge) {
            if (penge >= Pris) {
                Console.WriteLine($"Jeg har råd til {Titel}");
                return true;
            }
            else {
                Console.WriteLine($"Jeg har desværre ikke råd til {Titel}");
                return false;
            }
        }
    }
}