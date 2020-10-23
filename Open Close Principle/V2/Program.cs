using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Models;

namespace V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Finance finance = new Finance();
            HR hr = new HR();

            var employees = new dynamic[] { new Ceo(), new Programmer(), new Accountant() };

            finance.CalculateSalaries(employees);
            hr.ShowIdCards(employees);

            Console.Read();
        }
    }
}
