using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prog3_ZHA
{
    class ViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Beteg> betegek;
        static ViewModel peldany;

        public ObservableCollection<Beteg> Betegek
        {
            get
            {
                return betegek;
            }

            set
            {
                betegek = value; OnPropertyChanged();
            }
        }

        public static ViewModel Get()
        {
            if (peldany == null)
                peldany = new ViewModel();
            return peldany;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public ViewModel()
        {
            betegek = new ObservableCollection<Beteg>();
        }
    }
}
