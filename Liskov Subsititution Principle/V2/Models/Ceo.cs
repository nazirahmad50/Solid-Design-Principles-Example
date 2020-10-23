using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Models
{
   public class Ceo : IPayable, IVisitor
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Calculate for Ceo");
        }

        public void ShowIdCard()
        {
            Console.WriteLine("Show Card Ceo");
        }
    }
}
