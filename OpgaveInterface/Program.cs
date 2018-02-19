using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] dbFunktioner= new IDbFunktioner[4];
            dbFunktioner[0] = new Hund() { Navn = "Fido1" };
            dbFunktioner[1] = new Ubåd() { Nummer = 1, Turbine = 0.25 };
            dbFunktioner[2] = new Hund() { Navn = "Fido1" };
            dbFunktioner[3] = new Ubåd() { Nummer = 2, Turbine = 1.25 };

            foreach (var item in dbFunktioner)
            {
                item.Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
