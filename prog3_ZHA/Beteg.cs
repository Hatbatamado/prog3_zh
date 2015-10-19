using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3_ZHA
{
    public class Beteg
    {
        string nev, szuletesiHely, tAJSzam;
        DateTime szuletesiDatum;
        List<Kezeles> kezelesek = new List<Kezeles>();
        int eletkor;

        public string TAJSzam
        {
            get { return tAJSzam; }
            set { tAJSzam = value; }
        }

        public string SzuletesiHely
        {
            get { return szuletesiHely; }
            set { szuletesiHely = value; }
        }

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }        

        public DateTime SzuletesiDatum
        {
            get { return szuletesiDatum; }
            set { szuletesiDatum = value; }
        }
        
        public List<Kezeles> Kezelesek
        {
            get { return kezelesek; }
            set { kezelesek = value; }
        }

        public int Eletkor
        {
            get
            {
                return eletkor;
            }

            set
            {
                eletkor = value;
            }
        }
    }
}
