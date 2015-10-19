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
using System.Windows.Shapes;

namespace prog3_ZHA
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Beteg beteg;
        bool uj = false;
        public Window1(Beteg beteg)
        {
            InitializeComponent();
            if (beteg == null)
            {
                uj = true;
                beteg = new Beteg() { SzuletesiDatum = DateTime.Now };
            }
            else
                beteg.Eletkor = DateTime.Now.Year - beteg.SzuletesiDatum.Year;

            this.beteg = beteg;
            this.DataContext = beteg;
        }

        public bool Uj
        {
            get
            {
                return uj;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void tajtext_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
                e.Handled = true;
        }
    }
}
