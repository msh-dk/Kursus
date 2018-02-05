using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSimpleClass
{
   public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;
        
        public Person():this("", "", 0)
        {}

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fornavn = fornavn.ToUpper();
            this.Efternavn = efternavn.ToUpper();
            this.Fødselsår = fødselsår;
        }

        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        } //FuldtNavn()

        public int Alder()
        {
            int year = DateTime.Today.Year;
            return year - Fødselsår;

        }// Alder()


    }
}
