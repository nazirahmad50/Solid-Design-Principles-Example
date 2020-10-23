using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Models
{

    public class Volunteer : IVisitor
    {
    
        public void ShowIdCard()
        {
            Console.WriteLine("Show Card Volunteer");
        }
    }
}
