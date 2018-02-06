using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTerningApp2
{
    public class Terning
    {
        private static Random r = new Random();

        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set {
                if((value<1) && (value > 6)){
                    værdi = 1;
                }
                else
                {
                    værdi = value;
                }
                    
            }
        }


        public Terning()
        {
            this.Ryst(); 
        }

        public Terning(int startVærdi)
        {
           this.Værdi = startVærdi; 
        }

        public void Ryst()
        {
            this.Værdi = r.Next(1, 7);
        }
        
        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }
    }
}
