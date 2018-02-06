using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveNedarvning
{
    class UdvidetRandom : Random
    {

     

        public bool NextBool()
        {
      
            int tal = this.Next(1, 1002);

            if (tal < 500)
            {
                return true;
}
            else
            {
                return false;
            }
        }
    }
}
