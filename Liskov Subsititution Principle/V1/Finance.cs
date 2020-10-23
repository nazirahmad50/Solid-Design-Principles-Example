using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V1.Models;

namespace V1
{
    public class Finance
    {
        public void CalculateSalaries(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                employee.CalculateSalary();
            }
        }
    }
}
