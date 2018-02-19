using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveCompare
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Navn = "Bulder", Alder = 10 };
            hunde[1] = new Hund() { Navn = "Lady", Alder = 5 };

            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);

            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
