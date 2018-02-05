using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("a", "b");
            string a_navn = a.FuldtNavn();

            Person b = new Person("b", "c", 1967);
            int alder = b.Alder();

        }
    }
}
