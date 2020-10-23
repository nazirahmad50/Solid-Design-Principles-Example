using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3.Models;

namespace V3.Models
{
   public class Ceo : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Pay Ceo");
        }

        public void ShowIdCard()
        {
            Console.WriteLine("Greet Ceo");
        }
    }
}
