using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Models;

namespace V2
{
    public class Finance
    {
        public void CalculateSalaries(List<IPayable> employees)
        {
            foreach (IPayable employee in employees)
            {
                employee.CalculateSalary();
            }
        }
    }
}
