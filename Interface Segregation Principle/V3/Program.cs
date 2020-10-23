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
            Computer computer = new Computer() { Price = 100, OS = "Windows" };
            Server server = new Server() { Price = 200, OS = "Linux" };
            Training training = new Training() { Price = 200 };
        }
    }
}
