using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Models;

namespace V2
{
    /// <summary>
    /// In V2, the existing code is modified when accountant is added, so this breaks the open closed principle
    /// what if there were more than like 50 departments in a real company
    /// </summary>
    /// <param name="employees"></param>
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
                else if (employee is Accountant)
                {
                    Accountant accountant = (Accountant)employee;
                    accountant.CalculateSalary();
                }

            }
        }
    }
}
