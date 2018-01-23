using System;

namespace Module02_HelloWorld
{
    class Program
    {
        static string applicationTitle = "My application title";
        /// <summary>
        /// Main application call from cmd Window.
        /// </summary>
        /// <param name="args">Aplication arguments. Must be 1 or 2</param>
        static void Main(string[] args)
        {
            //Test 3
            Console.Title = applicationTitle;

            if (args.Length == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("No Args. Please supply arguments...");
            }
            else
            {
                if (args[0].Equals("/?"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.WriteLine("HELP FOR MY APP:");
                    Console.WriteLine("Arguments:");
                    Console.WriteLine("1 = bla bla bla");
                    Console.WriteLine("2 = bla bla.");
                    //return; //Exit
                }
                 
           

                if (args[0].Equals("1"))
                {
                    DebugDemo();
                }
                
            }

            //Reset colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            System.DateTime dt1 = new DateTime(System.DateTime.Now.Ticks);
            System.DateTime dt2 = new DateTime(2018,1,1);
            System.TimeSpan ts = dt1.Subtract(dt2);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
            
        }

        static void DebugDemo()
        {

            int i = 10;
            int u = 20;
            u = u + i;
            string name = "Mikkel";
            System.Console.WriteLine(name);
            string upperName = name.ToUpper();
            System.Console.WriteLine(upperName);

            for (int x = 0; x < 3; x++)
            {
                u += x;
            }

            Test1(5);

        }

        static void Test1(int i)
        {
            i++;
            Test2(i);
        }

        static void Test2(int i)
        {
            i--;
            Test3(i);
        }

        static void Test3(int i)
        {
            i++;
        }
    }
}
