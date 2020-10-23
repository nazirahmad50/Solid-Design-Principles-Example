using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2
{
    public class Assistant
    {
        public int RetirementAge = 65;

        public int Age { get; set; }

        public Assistant(int age)
        {
            Age = age;
        }


        public void HandleEmployee()
        {
            Log();
            Calculate();
        }

        public void Log()
        {
            Console.WriteLine("Log Data...");

        }

        public void Calculate()
        {
            Console.WriteLine(RetirementAge - Age);

        }
    }
}
