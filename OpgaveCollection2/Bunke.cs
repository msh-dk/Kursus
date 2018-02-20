using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveCollection2
{
    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public Bunke()
        {

        }

        public void TilføjKort(Kort k)
        {
            bunke.Push(k);

        }

        public Kort FjernKort()
        {
            if (bunke.Count > 0)
            {
                return bunke.Pop();
            }
            else {
                return null;
            }
            
        }

        public void Vis()
        {
            foreach (Kort k in bunke)
            {
                Console.WriteLine(k);
            }
        }
    }
}
