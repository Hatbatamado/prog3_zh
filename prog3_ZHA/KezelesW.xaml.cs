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
    /// Interaction logic for KezelesW.xaml
    /// </summary>
    public partial class KezelesW : Window
    {
        Beteg beteg;
        public KezelesW(Beteg beteg)
        {
            InitializeComponent();
            this.beteg = beteg;
            this.DataContext = beteg;
            BNOcomboBox.Items.Add("BNO 4658 - Sör");
            BNOcomboBox.Items.Add("BNO 7815 - Bor");
            BNOcomboBox.Items.Add("BNO 1854 - Pálinka");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                beteg.Kezelesek.Add(new Kezeles() { BNOKod = BNOcomboBox.Text, Jegyzet = textBox.Text });
            }
            this.DialogResult = true;
        }
    }
}
