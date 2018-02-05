using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTrekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(10, 5);
            double areal = t.Areal;



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}

