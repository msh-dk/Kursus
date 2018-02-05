using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Test";
            p.Efternavn = "te";

            Person p2 = new Person() { Fornavn = "Test", Efternavn = "Testesen" };

            string fn = p2.FuldtNavn;

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
