using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTerningApp2
{
    public class Terning
    {
        private int værdi;
        private static Random rnd = new Random();

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.værdi = værdi;
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);

        }
        
        public int Værdi
        {
            get { return this.værdi; }
            //set { this.værdi = value; }
        }

        public void Ryst(bool snyd)
        {
            if (snyd)
            {
                this.værdi = 6;
            }
            else
            {
                this.Ryst();
            }

        }

    }
}
