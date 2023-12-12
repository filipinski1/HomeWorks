using System;
using Google.Cloud.Translation.V2;

namespace TranslationApiDemo
{
    class Program
    {
        static void Main(string[] args)


        {
            // Set the path to your JSON key file
            string keyFilePath = @"C:\Users\mliak\Documents\code\translate\homework10-407901-51543db07a37.json";

            // Set the GOOGLE_APPLICATION_CREDENTIALS environment variable
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", keyFilePath);

            // Create a TranslationClient using the credentials
            var client = TranslationClient.Create();

            // Your translation logic goes here
            var text = "Hello, how are you?";
            var response = client.TranslateText(text, LanguageCodes.Turkish);

            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Translated: {response.TranslatedText}");
        }
    }
}
