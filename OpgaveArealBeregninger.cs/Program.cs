using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveArealBeregninger.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10, 10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }


    }
}
