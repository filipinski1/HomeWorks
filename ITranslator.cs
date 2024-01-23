using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal interface ITranslator
    {
        string DetectLanguage(string text);
        string Translate (string text, string targetLanguage);
        List<string> GetTranslationLanguages();
    }
}
