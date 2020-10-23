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

            List<IPayable> employees = new List<IPayable> { new Ceo(), new Programmer()};
            List<IVisitor> visitors = new List<IVisitor> { new Ceo(), new Programmer(), new Volunteer() };


            finance.CalculateSalaries(employees);
            hr.ShowIdCards(visitors);

            Console.Read();
        }
    }
}
