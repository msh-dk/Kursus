using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTerningApp1
{
    public class Terning
    {
        public int Værdi;
        private static Random rnd = new Random();

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1,7);

        }

        public void Ryst(bool snyd)
        {
            if (snyd)
            {
                this.Værdi = 6;
            }
            else
            {
                this.Ryst();
            }

        }

    }
}
