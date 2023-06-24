﻿using BrokTranslate.Api;
using BrokTranslate.Repo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BrokTranslate.Convertor
{
    public class TranslateEnglishToFarsi : IValueConverter
    {
        public string ThisToType { get; set; }
        public string ThisFromType { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                Translate translate = new Translate(value.ToString(), ThisToType, ThisFromType);
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
