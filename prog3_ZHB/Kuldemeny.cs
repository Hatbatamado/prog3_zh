using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prog3_ZHB
{
    public class Kuldemeny : INotifyPropertyChanged
    {
        string cimzettNev, cimzettOrszag, cimzettVaros, cimzettUtcaHazszam, cimzettIrszam;
        int gramm;
        List<string> megjegyzesFutarnak = new List<string>();
        FutarSzolgaltatas szolgaltatas;
        int ar;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string name = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public string CimzettNev
        {
            get
            {
                return cimzettNev;
            }

            set
            {
                cimzettNev = value;
            }
        }

        public string CimzettOrszag
        {
            get
            {
                return cimzettOrszag;
            }

            set
            {
                cimzettOrszag = value;
            }
        }

        public string CimzettVaros
        {
            get
            {
                return cimzettVaros;
            }

            set
            {
                cimzettVaros = value;
            }
        }

        public string CimzettUtcaHazszam
        {
            get
            {
                return cimzettUtcaHazszam;
            }

            set
            {
                cimzettUtcaHazszam = value;
            }
        }

        public string CimzettIrszam
        {
            get
            {
                return cimzettIrszam;
            }

            set
            {
                cimzettIrszam = value;
            }
        }

        public int Gramm
        {
            get
            {
                return gramm;
            }

            set
            {
                gramm = value; OnPropertyChanged();
            }
        }

        public List<string> MegjegyzesFutarnak
        {
            get
            {
                return megjegyzesFutarnak;
            }

            set
            {
                megjegyzesFutarnak = value;
            }
        }

        public FutarSzolgaltatas Szolgaltatas
        {
            get
            {
                return szolgaltatas;
            }

            set
            {
                szolgaltatas = value;
            }
        }

        public int Ar
        {
            get
            {
                return ar;
            }

            set
            {
                ar = value;
            }
        }
    }
}
