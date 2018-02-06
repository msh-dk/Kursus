using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavePolymorfi
{
    public class Dyr
    {
        public string Navn { get; set; }

        private static Random r = new Random();
        public Dyr()
        {

        }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + this.Navn);

        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            //r = new Random();
            
            int nrNavn = r.Next(0, navne.Length);
         
            if (r.Next(0, 2) == 1)
            {
                return new Hund() { Navn = navne[nrNavn] } as Dyr;
            }
            else
            {
                return new Kat() { Navn = navne[nrNavn] } as Dyr;
            }
        }
    }
}
