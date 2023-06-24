using BrokTranslate.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokTranslate.Repo
{
    class Translate
    {
        private GoogleApi Api { get; set; }
        private TranslatSetting TranslatSetting { get; set; }
        public string ToType { get; set; }
        public string FromType { get; set; }
        public string Content { get; set; }
        public Translate()
        {
            TranslatSetting = new TranslatSetting();
            Api = new GoogleApi();
        }

        public Translate(string content, string toType, string fromType)
        {
            ToType = toType;
            FromType = fromType;
            Content = content;
            TranslatSetting = new TranslatSetting();
            Api = new GoogleApi();
        }

        public string LanguagesTranslate()
        {
            TranslatSetting.Content = Content;
            TranslatSetting.ToLanguage = (LanguagesType)Enum.Parse(typeof(LanguagesType), ToType);
            TranslatSetting.FromLanguage = (LanguagesType)Enum.Parse(typeof(LanguagesType), FromType);
            return Api.Translate(TranslatSetting);
        }


    }
}
