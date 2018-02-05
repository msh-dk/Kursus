using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTerningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OpgaveTerningApp2.Terning t1 = new OpgaveTerningApp2.Terning(3);
          //  t1.Skriv();
            for (int i = 0; i < 25; i++)
            {
           //     t1.Ryst();
                
           //     t1.Skriv();
            }
       //     t1.Ryst(true);

            OpgaveTerningApp1.Bæger bæger = new OpgaveTerningApp1.Bæger();
            bæger.Skriv();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
