using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3.Models
{
    /// <summary>
    /// This class is an extension in V2, so it doesnt break the open closed principle
    /// </summary>
    public class Accountant : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Pay Accountant");
        }

        public void ShowIdCard()
        {
            Console.WriteLine("Greet Accountant");
        }
    }
}
