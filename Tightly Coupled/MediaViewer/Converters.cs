using System;
using System.Windows.Data;

namespace MediaViewer
{
    public class DecadeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int year = ((DateTime)value).Year;
            return string.Format("{0}0s", year.ToString().Substring(0, 3));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
