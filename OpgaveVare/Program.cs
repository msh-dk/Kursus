using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveVare
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v1 = new Vare();
            double p1 = v1.Pris;
            v1.Pris = 5.45;
            v1.Navn = "Vingummi";

            string n1 = v1.Navn;

            Vare v2 = new Vare("Chocolade", 45.78);
            double p2 = v2.Pris;
            string n2 = v2.Navn;
            double p2_moms = v2.PrisMedMoms();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
