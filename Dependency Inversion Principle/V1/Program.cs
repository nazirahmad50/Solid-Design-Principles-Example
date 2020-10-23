using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter reporter = new Reporter();
            reporter.CreateReport();

            Console.Read();
        }
    }
}
