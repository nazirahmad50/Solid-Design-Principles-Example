using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter reporter = new Reporter(new CsvParser());
            reporter.CreateReport();

            Console.Read();
        }
    }
}
