﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveNedarvning
{
    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public Person()
        {

        }

        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }
    }
}
