using System;
using System.Collections.Generic;
using Google.Cloud.Translation.V2;

namespace TranslationApiDemo
{
    class Program
    {
        static void Main(string[] args)


        {
            // Set the path to your JSON key file
            string keyFilePath = @"C:\Users\mliak\Documents\code\homework10-407901-51543db07a37.json";

            // Set the GOOGLE_APPLICATION_CREDENTIALS environment variable
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", keyFilePath);

            // Create a TranslationClient using the credentials
            var client = TranslationClient.Create();

            var supportedLanguages = client.ListLanguages();

            // Display the list of supported languages to the user
            Console.WriteLine("Supported Languages:");

            // Create a dictionary to store language code and name mappings
            var languageDictionary = new Dictionary<string, string>();

            foreach (var language in supportedLanguages)
            {
                Console.WriteLine($"{language.Code}: {language.Name}");
                languageDictionary[language.Code] = language.Name;
            }


            // Get user input for the text to be translated
            Console.Write("Enter the text to be translated: ");
            string text = Console.ReadLine();

            // Get user input for the target language
            Console.Write("Enter the target language code (e.g., 'es' for Spanish): ");
            string targetLanguageCode = Console.ReadLine();

            if (languageDictionary.TryGetValue(targetLanguageCode, out var targetLanguageName))
            {
                Console.WriteLine($"Selected language: {targetLanguageName}");
            }
            else
            {
                Console.WriteLine("Invalid language code. Using default.");
                targetLanguageCode = "en"; // Use English as the default language
            }

            try
            {
                // Your translation logic goes here
                var response = client.TranslateText(text, targetLanguageCode);
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine($"Original: {text}");
                Console.WriteLine($"Translated: {response.TranslatedText}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    }

