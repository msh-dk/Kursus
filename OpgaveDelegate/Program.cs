using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregner(2, 3, Plus);

            res = Beregner(1, 2, Minus);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Devider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static int Beregner(int a, int b, Func<int,int,int> f)
        {
            return f(a, b);
        }
    }
}
