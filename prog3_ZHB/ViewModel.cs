using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3_ZHB
{
    public class ViewModel
    {
        static ViewModel peldany;
        ObservableCollection<FutarSzolgaltatas> futarSzolg;
        ObservableCollection<Kuldemeny> kuldemenyek;

        public ObservableCollection<FutarSzolgaltatas> FutarSzolg
        {
            get
            {
                return futarSzolg;
            }

            set
            {
                futarSzolg = value;
            }
        }

        public ObservableCollection<Kuldemeny> Kuldemenyek
        {
            get
            {
                return kuldemenyek;
            }

            set
            {
                kuldemenyek = value;
            }
        }

        public static ViewModel Get()
        {
            if (peldany == null)
                peldany = new ViewModel();
            return peldany;
        }

        private ViewModel()
        {
            futarSzolg = new ObservableCollection<FutarSzolgaltatas>();
            kuldemenyek = new ObservableCollection<Kuldemeny>();
        }
    }
}
