using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveEgenskaber
{
    public class Person
    {
        public string Fornavn { get; set; }
        private string efternavn;

        public string Efternavn
        {
            get { return this.efternavn; }
            set {
                if(value.Length <= 3)
                {
                    value = "";
                }
                this.efternavn = value; }
        }

        public Person()
        {

        }

        //   public string FuldtNavn()
        //   {
        //       return this.Fornavn + " " + this.Efternavn;
        //
        //   }
        public string FuldtNavn { get => this.Fornavn + " " + this.Efternavn; }
    }
}
