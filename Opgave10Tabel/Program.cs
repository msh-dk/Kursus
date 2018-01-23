using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave10Tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in numbers1)
            {

                for (int i = 0; i < numbers2.Length; i++)
                {
                    int sum = 0;

                    sum = item * numbers2[i];
                    if (sum > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
     
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                      }

                    Console.Write(sum.ToString().PadLeft(4));
            
                }
               
                Console.WriteLine();

            }
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(TestOverLoad("ertyu"));
            Console.WriteLine(TestOverLoad(23));

            OptionalTest(8);
            OptionalTest(5, 4);
            OptionalTest(7, 7, true);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        private static void OptionalTest(int x, int y=1, bool z = false)
        {

        }
        private static int TestOverLoad(int y)
        {
            return y;
        }

        private static int TestOverLoad(string x)
        {
            return x.Length;
        }
    }

    
}
