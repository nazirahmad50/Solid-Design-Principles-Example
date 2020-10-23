using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4
{
    public class Assistant
    {
        public FinanceAssistant FinanceAssistant { get; set; }
        public Logger Logger { get; set; }

        public Assistant(int age)
        {
            FinanceAssistant = new FinanceAssistant(age);
            Logger = new Logger();
        }

        public void HandleEmployee()
        {
            Logger.Log();
            FinanceAssistant.Calculate();
        }

    }
}
