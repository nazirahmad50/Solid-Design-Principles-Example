using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2
{
    // This vialotes the open close principle
    // it also vialotes dependancy inversion principle which states that high level moduels should not depend on low level modules,
    // but depend on abstraction. This also introduces tight coupling as report class cannot exist without csv and docx parser
    public class Reporter
    {
        private CsvParser csvParser;
        private DocxParser docxParser;

        public Reporter()
        {
            csvParser = new CsvParser();
            docxParser = new DocxParser();

        }


        public void CreateReport(RepotType repotType)
        {
            switch (repotType)
            {
                case RepotType.Csv:
                    csvParser.Read();
                    break;
                case RepotType.Docs:
                    docxParser.Read();
                    break;
                default:
                    break;
            }
        }
    }

    public enum RepotType
    {
        Csv,
        Docs
    }
}
