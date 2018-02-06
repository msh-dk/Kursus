using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTerningApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t1 = new Terning();
            t1.Skriv();

            Terning t2 = new Terning(1);
            t2.Skriv();

            LudoTerning lt1 = new LudoTerning();
            lt1.Skriv();

            LudoTerning lt2 = new LudoTerning(3);
            lt2.Skriv();



            Terning[] terninger = new Terning[5];
            terninger[0] = new Terning();
            terninger[1] = new Terning();
            terninger[2] = new LudoTerning();
            terninger[3] = new LudoTerning();
            terninger[4] = new Terning();

            foreach (var item in terninger)
            {
                item.Skriv();
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
