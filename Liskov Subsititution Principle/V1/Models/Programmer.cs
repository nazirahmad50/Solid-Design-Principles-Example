using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1.Models
{
    public class Programmer : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Calculate for programmer");
        }

        public override void ShowIdCard()
        {
            Console.WriteLine("Show Card programmer");
        }
    }
}
