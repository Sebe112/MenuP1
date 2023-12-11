using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bøger {
    public class Bog {
        public string Titel {get; set;}
        public int Pris {get; set;}

        public Bog(string titel,int pris) { // Constructor 
            Titel = titel;
            Pris = pris;
        }

        public void PrintInfo() { // Metode der udksriver variabler og noget tekst
            Console.WriteLine($"{Titel} - koster {Pris} kr.");
        }
        public bool HarRåd(int penge) { // Metode der tjekker om man har råd til at købe en bog og retunere noget tekst + en bool
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