using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveVare
{
    public class Vare
    {
        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Property Pris. Get: " + pris);
                return pris; }
            set {
                Console.WriteLine("Property Pris. Set: " + value);
                pris = value; }
        }

        private static double momsPct = 0.25;

        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Property Navn. Get: " + navn);

                return navn; }
            set
            {
                Console.WriteLine("Property Navn. Set: " + value);
                navn = value; }
        }


        public Vare():this("",0.0)
        {

        }
        public Vare(string vareNavn, double pris)
        {
            this.Navn = vareNavn;
            this.Pris = pris;
        }

        public double PrisMedMoms()
        {
            double res = this.Pris * (1 + momsPct);
            Console.WriteLine("Method PrisMedMoms. " + res);
            return res;
        }
    }
}
