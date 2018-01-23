using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            Udskriv("Dette er en test");

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);

            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res3 = BeregnOgSorterArray(test);

            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2,3));
            Console.WriteLine(Beregn(1, 2,4,5));



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        public static int LægSammen(int a, int b)
        {
            return a + b;
        }

        public static double BeregnAreal(int radius)
        {
            return radius * radius * System.Math.PI;
        }

        public static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

        public static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            foreach (var item in månedsløn)
            {
                sum += item;
            }

            return sum / månedsløn.Length;
        }

        public static double SumArray(int[] månedsløn)
        {
            double sum = 0;
            foreach (var item in månedsløn)
            {
                sum += item;
            }

            return sum;
        }

        public static ArrayResultat BeregnOgSorterArray(int[] myArray)
        {
            Array.Sort(myArray);
            ArrayResultat result = new ArrayResultat();
            result.sum = 0;
            foreach (var item in myArray)
            {
                result.sum += item;
            }

            result.gennemsnit = result.sum / myArray.Length;
            return result;


        }

        public struct ArrayResultat
        {
            public double sum;
            public double gennemsnit;
        }


        public static int Beregn(int a, int b)
        {
            return Beregn(a, b, 0, 0);
        }

        public static int Beregn (int a, int b, int c)
        {
            return Beregn(a, b, c, 0);
        }

        public static int Beregn (int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
}
