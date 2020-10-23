using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Models
{
    public class Programmer : IPayable, IVisitor
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Calculate for programmer");
        }

        public void ShowIdCard()
        {
            Console.WriteLine("Show Card programmer");
        }
    }
}
