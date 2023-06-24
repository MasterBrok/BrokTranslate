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
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                Api.TranslatSetting translat = new Api.TranslatSetting();
                translat.Content = value.ToString();
                translat.FromLanguage = Api.LanguagesType.English;
                translat.ToLanguage = Api.LanguagesType.Persian;
                Api.GoogleApi api = new Api.GoogleApi();
                return api.Translate(translat);
            }
            return "Not Found";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}