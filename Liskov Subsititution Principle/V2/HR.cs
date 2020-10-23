using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Models;

namespace V2
{
    public class HR
    {
        public void ShowIdCards(List<IVisitor> employees)
        {
            foreach (IVisitor employee in employees)
            {
                employee.ShowIdCard();

            }
        }
    }
}
