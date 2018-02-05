using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveArealBeregninger.cs
{
    public static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double højde, double bredde)
        {
            return højde * bredde;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return System.Math.PI * (radius * radius);

        }
    }
}
