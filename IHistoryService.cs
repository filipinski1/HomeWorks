using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal interface IHistoryService 
    {
        public void WriteHistory(string entry);
        public void DisplayHistory();

    }
}
   