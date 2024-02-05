using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class HistoryService : IHistoryService
    {
        private string filePath;
        public HistoryService(string filePath)
        {
            this.filePath = filePath;
        }
        public void WriteHistory(string entry)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(entry);
            }
        }

        public void DisplayHistory()
        {
            Console.WriteLine("Translation History:");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}