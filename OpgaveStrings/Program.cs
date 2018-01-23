using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = fornavn + " " + efternavn;

            string navnStort = samletNavn.ToUpper();

            string navnLille = samletNavn.ToLower();

            string del = efternavn.Substring(0, 4);

            string[] navnArray = samletNavn.Split(' ');

            for (int i = 0; i < navnArray.Length; i++)
            {
                Console.WriteLine(navnArray[i]);
            }

            Console.WriteLine(fornavn + "X \r\n y" + efternavn);

            StringBuilder myBuilder = new StringBuilder();
            myBuilder.Append(fornavn);
            myBuilder.Append(" ");
            myBuilder.Append(efternavn);
            myBuilder.AppendLine();
            myBuilder.Append("Dette er en test");
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\temp\myFile1.txt");
                file.WriteLine(myBuilder.ToString()); 
                file.Flush();
                file.Close();

                System.IO.File.WriteAllText(@"c:\temp\myfile2.txt", samletNavn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
