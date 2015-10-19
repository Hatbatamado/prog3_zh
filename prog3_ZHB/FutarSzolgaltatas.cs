using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3_ZHB
{
    public class FutarSzolgaltatas
    {
        string nev;
        int minSzallitasNap, maxSzallitasNap, alapAr, grammAr;

        public string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                nev = value;
            }
        }

        public int MinSzallitasNap
        {
            get
            {
                return minSzallitasNap;
            }

            set
            {
                minSzallitasNap = value;
            }
        }

        public int MaxSzallitasNap
        {
            get
            {
                return maxSzallitasNap;
            }

            set
            {
                maxSzallitasNap = value;
            }
        }

        public int AlapAr
        {
            get
            {
                return alapAr;
            }

            set
            {
                alapAr = value;
            }
        }

        public int GrammAr
        {
            get
            {
                return grammAr;
            }

            set
            {
                grammAr = value;
            }
        }
    }
}
