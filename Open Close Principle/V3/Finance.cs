using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3.Models;

namespace V3
{

    public class Finance
    {

        /// <summary>
        /// Thanks to polymorphism, this method now adheres to the open closed principle 
        /// </summary>
        /// <param name="employees"></param>
        public void CalculateSalaries(List<IEmployee> employees)
        {
            foreach (IEmployee employee in employees)
            {
                employee.CalculateSalary();

            }
        }
    }
}
