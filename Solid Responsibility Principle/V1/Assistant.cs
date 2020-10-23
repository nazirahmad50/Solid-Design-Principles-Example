using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1
{
    public class Assistant
    {
        public int RetirementAge = 65;

        public int Age { get; set; }

        public Assistant(int age)
        {
            Age = age;
        }

        // This method handle stwo tasks which is to calculate and log which will be split in V2
        // Each method should handle one task
        public void HandleEmployee()
        {
            Console.WriteLine(RetirementAge - Age);
            Console.WriteLine("Log Data...");
        }
    }
}
