using System;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyFilePath = @"C:\Users\mliak\Documents\code\homework10-407901-51543db07a37.json";

            IConector connector = new Connector(keyFilePath);
            var translationClient = connector.CreateConnection();

            var translator = new Translator(translationClient);
            var history = new History(@"C:\Users\mliak\Documents\code\HomeWorks\TranslationHistory.txt");

            string detectedLanguage = translator.DetectLanguage("Hello, world!");
            Console.WriteLine($"Detected language: {detectedLanguage}");

            var translationLanguages = translator.GetTranslationLanguages();
            Console.WriteLine("Supported translation languages:");
            foreach (var language in translationLanguages)
            { 
                Console.WriteLine(language);
            }
            Console.Write("Enter the text to be translated: ");
            string text = Console.ReadLine();

            Console.Write("Enter the target language code: ");
            string targetLanguageCode = Console.ReadLine();

            string translatedText = translator.Translate(text, targetLanguageCode);

            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Translated: {translatedText}");

            Console.Write("Do you want to see the translation history?");
            string response = Console.ReadLine().ToLower();
            if(response == "yes")
            {
                history.DisplayHistory();
            }
        }
    }
}