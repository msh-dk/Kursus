﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTrekant
{
    public class Trekant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        public double Areal {
            get {
                return this.Grundlinje * this.Højde * 0.5;
            }
        }
        public Trekant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }
    }
}
