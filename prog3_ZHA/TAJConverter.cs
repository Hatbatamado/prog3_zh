using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace prog3_ZHA
{
    public class TAJConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool valid = false;
            string taj = value.ToString();
            if (taj.Length == 9)
                valid = true;
            else
                valid = false;
            if (valid)
            {
                foreach (char c in taj)
                {
                    if (!Char.IsDigit(c))
                        valid = false;
                }
            }

            if (valid)
                return "érvényes (" + taj + ")";
            else
                return "érvénytelen (" + taj + ")";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
