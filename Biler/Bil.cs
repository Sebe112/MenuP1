using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biler {
    public class Bil {
        public void StartMotor() { // Metode der skriver noget tekst
            Console.WriteLine("Motoren er startet.");
        }
        public void SlukMotor() { // Metode der skriver noget tekst
            Console.WriteLine("Motoren er slukket.");
        }
        public void FillGas(double liters, bool isDiesel) { // Metode der vælger mellem diesel eller benzin og skriver tekst ud
            string type = "";
            if (isDiesel == true) {
                type = "diesel";
            }
            else {
                type = "benzin";
            }
            Console.WriteLine("Filled tank with: " + liters + " liters of " + type);
        }
        public double RemainingGas(double rGas) { // Metode der retunere en variable
            return rGas;
        }
    }
}
