using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1.Models
{
    public class Employee
    {
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Calculate for Employee");
        }

        public virtual void ShowIdCard()
        {
            Console.WriteLine("Show card Employee");
        }
    }
}
