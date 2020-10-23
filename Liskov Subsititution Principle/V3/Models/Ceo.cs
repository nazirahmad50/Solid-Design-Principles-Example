using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3.Models
{
   public class Ceo : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Calculate for Ceo");
        }

        public override void ShowIdCard()
        {
            Console.WriteLine("Show Card Ceo");
        }
    }
}
