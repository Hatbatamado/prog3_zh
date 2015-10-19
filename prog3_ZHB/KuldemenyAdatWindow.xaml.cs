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

namespace prog3_ZHB
{
    /// <summary>
    /// Interaction logic for KuldemenyAdatWindow.xaml
    /// </summary>
    public partial class KuldemenyAdatWindow : Window
    {
        ViewModel vm;
        
        public KuldemenyAdatWindow(FutarSzolgaltatas futarSzolg)
        {
            InitializeComponent();
            vm = ViewModel.Get();
            vm.Kuldemenyek.Add(new Kuldemeny() { Szolgaltatas = futarSzolg });
            this.DataContext = vm.Kuldemenyek.Last();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (megjegyzesText.Text.Length > 0)
            {
                Kuldemeny kuld = vm.Kuldemenyek.Last();
                kuld.MegjegyzesFutarnak.Add(megjegyzesText.Text);
                megJlistBox.Items.Refresh();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(orszagtxt.Text))
            {
                MessageBoxResult result = MessageBox.Show("Magyarországra?", "Hova?", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.Cancel)
                    e.Cancel = true;
                else if (result == MessageBoxResult.OK)
                {
                    Kuldemeny kuld = vm.Kuldemenyek.Last();
                    kuld.CimzettOrszag = "Magyarország";
                    orszagtxt.Text = kuld.CimzettOrszag;
                }

            }

            if (String.IsNullOrEmpty(nevText.Text) || String.IsNullOrEmpty(varostxt.Text) || String.IsNullOrEmpty(uthaztxt.Text) ||
                String.IsNullOrEmpty(irszamtxt.Text) || String.IsNullOrEmpty(grammTxt.Text))
            {
                MessageBox.Show("Üres mező, töltsd ki!");
                e.Cancel = true;    
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Kuldemeny kuld = vm.Kuldemenyek.Last();
            this.DialogResult = true;
        }
    }
}
