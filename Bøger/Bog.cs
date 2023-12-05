using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bøger
{
    public class Bog
    {
        public void PrintInfo()
        {
            Console.WriteLine("Jeg er en bog");
        }
        public bool HarRåd(int pris, int penge) {
            if (penge >= pris) {
                Console.WriteLine("Jeg har råd");
                return true;
            }
            else {
                Console.WriteLine("Jeg har desværre ikke råd");
                return false;
            }
        }
    }
}