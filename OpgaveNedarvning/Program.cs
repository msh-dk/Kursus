using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveNedarvning
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person() { Fornavn = "Test 1", Efternavn = "Testesen" };
            Console.WriteLine (p.FuldtNavn());
            
            Elev e = new Elev() { Fornavn = "Test 2", Efternavn = "Testesen" };
            Console.WriteLine(e.FuldtNavn());
            e.KlasseLokale = "8.2.9";

            Instruktør i = new Instruktør() { Fornavn = "Test 3", Efternavn = "Testesen" };
            Console.WriteLine(i.FuldtNavn());
            i.NøgleId = 78;


            UdvidetRandom r = new UdvidetRandom();
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(r.NextBool());
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
