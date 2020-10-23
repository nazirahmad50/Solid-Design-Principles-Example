using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4;


namespace HR
{
    class Program
    {
        static void Main(string[] args)
        {
            // V1 Assistant
            //Assistant assistant = new Assistant(40);
            //assistant.HandleEmployee();

            // V2 Assistant
            //Assistant assistant = new Assistant(40);
            //assistant.Log();

            // V3 Assistant
            //Assistant assistant = new Assistant(40);
            //assistant.Log();

            // V4 Assistant
            Assistant assistant = new Assistant(40);
            assistant.Logger.Log();

            Console.ReadKey();
        }
    }
}
