using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt");
            while (stream.Peek() != -1)
            {
                string navn = stream.ReadLine();
                Console.WriteLine("**** " + navn);

            }
            stream.Close();
            stream = null;
            

            using(StreamReader stream1 = System.IO.File.OpenText(@"x:\dyrenavne.txt"))
            {
                while (stream1.Peek() != -1)
                {
                    string navn = stream1.ReadLine();
                    Console.WriteLine(navn);

                }
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
