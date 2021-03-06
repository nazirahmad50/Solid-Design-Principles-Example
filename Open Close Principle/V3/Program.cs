﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3.Models;

namespace V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Finance finance = new Finance();
            HR hr = new HR();

            List<IEmployee> employees = new List<IEmployee> { new Ceo(), new Programmer(), new Accountant() };

            finance.CalculateSalaries(employees);
            hr.ShowIdCards(employees);

            Console.Read();
        }
    }
}
