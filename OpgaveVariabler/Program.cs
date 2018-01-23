using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveVariabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal.ToString());

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal.ToString());

            FilTyper ft = FilTyper.cvs;
            Console.WriteLine(ft.ToString());
            Console.WriteLine((int)ft);

            System.DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("ddMMyy"));
            Console.WriteLine(dt.ToString("dd-MM-yyyy"));

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine(p.Navn);

            Person2 navn1 = new Person2 { Id = 2, Navn = "Mikkel" };
            Person2 navn2 = new Person2 { Id = 1, Navn = "Jens" };
            navn1 = navn2;
            Person2 navn3;
            navn3 = (Person2)navn1.Clone();
            navn3.Navn = "TEST CLONE";

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    enum FilTyper{
        cvs,
        pdf,
        text

    }

    struct Person
    {
        public int Id;
        public string Navn;
    }

    class Person2 : ICloneable
    {
        public int Id;
        public string Navn;
        public object Clone()
        {
            return this.MemberwiseClone();
            
        }
    }
}
