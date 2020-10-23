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
        public void CalculateSalaries(dynamic[] employees)
        {
            foreach (var employee in employees)
            {
                if (employee is Ceo)
                {
                    Ceo ceo = (Ceo)employee;
                    ceo.CalculateSalary();
                }
                else if (employee is Programmer)
                {
                    Programmer programmer = (Programmer)employee;
                    programmer.CalculateSalary();
                }
            }
        }
    }
}
