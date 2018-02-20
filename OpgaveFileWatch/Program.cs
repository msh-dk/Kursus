using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveFileWatch
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"C:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;

            w.Changed += (s,e)=> { Console.WriteLine(e.Name); };
            do { } while (true);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

       
    }
}
