using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3.Models
{
    /// <summary>
    /// This class will break the Liskov subsitition principle because of the CalculateSalary method
    /// LSP states that child class (Volunteer) should be used in place of parent class (Employee) without crashing
    /// </summary>
    public class Volunteer : Employee
    {
        /// <summary>
        /// a volunteer cannot recive salary
        /// </summary>
        public override void CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public override void ShowIdCard()
        {
            Console.WriteLine("Show Card Volunteer");
        }
    }
}
