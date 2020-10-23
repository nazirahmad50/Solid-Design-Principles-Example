using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using V4.Preconditions;
using V4.Postconditions;

namespace V4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pre-conditions cannot be strengtened, but you can weaken them
            // The LSP states that the preconditions of a base class must not be strengthened by a subclass
            // This means that parent class should have more strict pre-condition than its child class
            #region Precondition

            //double finalPrice = new Parent().CalcuateEBookPrice("james bond", 30);
            //Console.WriteLine(finalPrice);

            //Console.Read();

            #endregion



            // Post-conditions cannot be weakened, but you can strengtene them
            // The LSP states that the postconditions of a base class must not be weakened by a subclass
            #region Precondition

            double finalPrice = new Child().CalcuateEBookPrice("james bond", 30, Promo.BlackFriday);
            int booksPaymentTotal = 300;
            double numberOfBooks = booksPaymentTotal / finalPrice;

            Console.WriteLine(numberOfBooks);

            Console.Read();

            #endregion
        }
    }
}
