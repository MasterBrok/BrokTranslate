using BrokTranslate.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokTranslate.Repo
{
    class MyTranslate
    {
        private GoogleApi Api { get; set; }
        private TranslatSetting TranslatSetting { get; set; }
        public string ToType { get; set; }
        public string FromType { get; set; }
        public string Content { get; set; }
        public MyTranslate()
        {
            TranslatSetting = new TranslatSetting();
            Api = new GoogleApi();
        }

        public MyTranslate(string content, string toType, string fromType)
        {
            ToType = toType;
            FromType = fromType;
            Content = content;
            TranslatSetting = new TranslatSetting();
            Api = new GoogleApi();
        }

        private void TranslatSettings()
        {
            TranslatSetting.Content = Content;
            TranslatSetting.ToLanguage = (LanguagesType)Enum.Parse(typeof(LanguagesType), ToType);
            TranslatSetting.FromLanguage = (LanguagesType)Enum.Parse(typeof(LanguagesType), FromType);
        }
        public string LanguagesTranslate()
        {
            TranslatSettings();
            return Api.Translate(TranslatSetting);
        }
    
    }
}
