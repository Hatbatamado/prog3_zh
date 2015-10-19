using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3_ZHA
{
    public class Kezeles
    {
        string bNOKod, jegyzet;

        public string BNOKod
        {
            get
            {
                return bNOKod;
            }

            set
            {
                bNOKod = value;
            }
        }

        public string Jegyzet
        {
            get
            {
                return jegyzet;
            }

            set
            {
                jegyzet = value;
            }
        }
    }
}
