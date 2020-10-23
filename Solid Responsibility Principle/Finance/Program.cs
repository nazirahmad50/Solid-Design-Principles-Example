using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4;

namespace Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            // V1 Assistant
            //Assistant assistant = new Assistant(30);
            //assistant.HandleEmployee();

            // V2 Assistant
            //Assistant assistant = new Assistant(40);
            //assistant.Calculate();

            // V3 Assistant
            //Assistant assistant = new Assistant(40);
            //assistant.Calculate();

            // V4 Assistant
            Assistant assistant = new Assistant(40);
            assistant.FinanceAssistant.Calculate();

            Console.ReadKey();

        }
    }
}
