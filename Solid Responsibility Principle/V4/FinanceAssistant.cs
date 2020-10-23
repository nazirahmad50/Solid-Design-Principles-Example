using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4
{
    public class FinanceAssistant
    {
        public int RetirementAge = 65;

        public int Age { get; set; }

        public FinanceAssistant(int age)
        {
            Age = age;
        }

        public void Calculate()
        {
            Console.WriteLine(RetirementAge - Age);

        }
    }
}
