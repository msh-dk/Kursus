using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTerningApp1
{
   
    public class Bæger
    {
        private Terning[] terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }
        }

        public void Skriv()
        {
            foreach (var terning in this.terninger)
            {
               Console.Write("[" + terning.Værdi + "]");
            }
            Console.WriteLine();


        }
    }
}
