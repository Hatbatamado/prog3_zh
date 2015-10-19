using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prog3_ZHA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = ViewModel.Get();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 betegW = new Window1(null);
            if (betegW.ShowDialog() == true)
            {
                if (betegW.Uj)
                {
                    vm.Betegek.Add(new Beteg() { Nev = betegW.bNev.Text, SzuletesiHely = betegW.Szulhely.Text, SzuletesiDatum = (betegW.SzulDatum.SelectedDate).Value, TAJSzam = betegW.tajtext.Text });
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (betegek.SelectedIndex != -1)
            {
                Window1 betegW = new Window1(betegek.SelectedItem as Beteg);
                if (betegW.ShowDialog() == true)
                {
                    if (betegW.Uj)
                    {

                    }
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (betegek.SelectedIndex != -1)
            {
                KezelesW kezelAblak = new KezelesW(betegek.SelectedItem as Beteg);
                if (kezelAblak.ShowDialog() == true)
                {

                }
            }
        }
    }
}
