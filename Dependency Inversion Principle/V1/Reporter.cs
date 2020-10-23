using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1
{
    public class Reporter
    {
        private CsvParser csvParser;

        public Reporter()
        {
            csvParser = new CsvParser();
        }

        public void CreateReport()
        {
            csvParser.Read();
        }
    }
}
