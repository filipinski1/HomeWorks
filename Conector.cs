using Google.Cloud.Translation.V2;
using System;

namespace HomeWorks
{
  

    internal class Connector : IConector
    {
        private readonly string _keyFilePath;

        public Connector(string keyFilePath)
        {
            _keyFilePath = keyFilePath;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", _keyFilePath);
        }

        public TranslationClient CreateConnection()
        {
            return TranslationClient.Create();

        }
    }
}