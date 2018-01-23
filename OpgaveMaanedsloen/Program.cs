using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveMaanedsloen
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double salaryTotal = 0;
            double gns = 0;
            int[] salaryArray = { 20000, 34932, 37293, 84722, 28746, 27467 };

            for (int i = 0; i < salaryArray.Length; i++)
            {
                salaryTotal += salaryArray[i];
                Console.WriteLine("Månedsløn nr. " + (i+1) + ": " + salaryArray[i].ToString("N2"));
            }

            if (salaryArray.Length != 0)
            {
                gns = salaryTotal / salaryArray.Length;
            }

            Console.WriteLine("Gennemsnit: " + gns.ToString("N2"));



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
