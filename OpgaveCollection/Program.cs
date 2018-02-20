using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Person> personList = new List<Person>();
            personList.Add(new Person() { Id = 1, Navn = "a" });
            personList.Add(new Person() { Id = 2, Navn = "b" });
            personList.Add(new Person() { Id = 3, Navn = "c" });

            foreach (Person p in personList)
            {
                Console.WriteLine(p.Navn);

            }


            Dictionary<int,Person> pDic = new Dictionary<int,Person>();
            pDic.Add(1, new Person() { Id = 1, Navn = "a" });
            pDic.Add(2, new Person() { Id = 2, Navn = "b" });
            pDic.Add(3, new Person() { Id = 3, Navn = "c" });

            Person p1 = pDic[3];
            Console.WriteLine("**" + p1.Navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
