using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTerningApp2
{
    public class LudoTerning : Terning
    {
        public LudoTerning():base()
        {

        }

        public LudoTerning(int startVærdi):base(startVærdi)
        {

        }

        public override void Skriv()
        {
            switch (this.Værdi)
            {
                case 3:
                    Console.WriteLine("[G]");
                    break;
                case 5:
                    Console.WriteLine("[S]");
                    break;
                default:
                    base.Skriv();
                    break;
            }

                       
        }

        public bool ErGlobus()
        {
            if (this.Værdi == 3)
                return true;
            return false;
        }

        public bool ErStjerne()
        {
            if (this.Værdi == 5)
                return true;
            return false;
        }
    }
}
