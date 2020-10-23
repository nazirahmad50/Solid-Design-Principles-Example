using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V1.Models;

namespace V1
{
    public class HR
    {
        public void ShowIdCards(dynamic[] employees)
        {
            foreach (var employee in employees)
            {
                if (employee is Ceo)
                {
                    Ceo ceo = (Ceo)employee;
                    ceo.ShowIdCard();
                }
                else if (employee is Programmer)
                {
                    Programmer programmer = (Programmer)employee;
                    programmer.ShowIdCard();
                }
            }
        }
    }
}
