using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biler {
    public class Bil {
        public void StartMotor() {
            Console.WriteLine("Motoren er startet.");
        }
        public void SlukMotor() {
            Console.WriteLine("Motoren er slukket.");
        }
        public void FillGas(double liters, bool isDiesel) {
            string type = "";
            if (isDiesel == true) {
                type = "diesel";
            }
            else {
                type = "benzin";
            }
            Console.WriteLine("Filled tank with: " + liters + " liters of " + type);
        }
        public double RemainingGas(double rGas) {
            return rGas;
        }
    }
}
