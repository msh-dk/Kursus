using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveCompare
{
    public class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund h = obj as Hund;
            if (Alder > h.Alder)
                return 1;
            if (Alder < h.Alder)
                return -1;
            return 0;
            
        }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund");
        }
    }
}
