using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BrokTranslate.Convertor
{
    internal class TranslateFarsiToEnglish : IValueConverter
    {
        public string ToType { get; set; }
        public string FromType { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                Class.Translate translate = new Class.Translate(value.ToString(),ToType,FromType);
                return translate.LanguagesTranslate();
            }
            return "Not Found";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}