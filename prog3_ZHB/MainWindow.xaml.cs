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

namespace prog3_ZHB
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
            vm.FutarSzolg.Add(new FutarSzolgaltatas() { Nev = "Alap", AlapAr = 1000, GrammAr = 5, MaxSzallitasNap = 10, MinSzallitasNap = 3 });
            vm.FutarSzolg.Add(new FutarSzolgaltatas() { Nev = "Extra", AlapAr = 10000, GrammAr = 50, MaxSzallitasNap = 2, MinSzallitasNap = 1 });
            this.DataContext = vm;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                KuldemenyAdatWindow kaw = new KuldemenyAdatWindow(listBox.SelectedItem as FutarSzolgaltatas);
                if (kaw.ShowDialog() == true)
                {
                }
            }
        }
    }
}
