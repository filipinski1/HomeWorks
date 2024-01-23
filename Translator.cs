using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Translator : ITranslator
    {
        private readonly TranslationClient _client;

        public Translator(TranslationClient client)
        {
            _client = client;
        }
        public string DetectLanguage(string text)
        {
            var detection = _client.DetectLanguage(text);
            return detection.Language;
        }

        public List<string> GetTranslationLanguages()
        {
            var languages = new List<string>();
            foreach (var language in _client.ListLanguages(LanguageCodes.English))
            {
                languages.Add(language.Name);

            }
            return languages;
        }

        public string Translate(string text, string targetLanguage)
        {
            var response = _client.TranslateText(text, targetLanguage);
            return response.TranslatedText;
        }
    }
}
