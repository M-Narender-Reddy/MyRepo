using System;
using System.Globalization;
using DataTemplateTest.ViewModels;
using Xamarin.Forms;

namespace DataTemplateTest.Converters
{
    public class PercentageToTextCoverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int coursePercentage = Course.ConvertValue<int>(value);
            string percentText = coursePercentage >= 100 ? string.Empty : coursePercentage + "% ";
            return string.Format(CultureInfo.InvariantCulture, "{0}{1}", percentText, "Completed");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Empty;
        }
    }
}
