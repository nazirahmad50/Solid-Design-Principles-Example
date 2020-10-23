using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4.Postconditions
{

    class Parent
    {
        public virtual double CalcuateEBookPrice(string title, int bookPrice, Promo promo = Promo.WithoutPromo)
        {
            // this is pre-condition
            if (title == "") throw new Exception();

            double priceWithDelivery = bookPrice + bookPrice * 0.1;

            // such check on method exit is called post-condition
            if (priceWithDelivery <= 0) throw new Exception();

            return priceWithDelivery;
        }
    }

    class Child : Parent
    {
        public override double CalcuateEBookPrice(string title, int bookPrice, Promo promo = Promo.WithoutPromo)
        {
            if (title == "") throw new Exception();

            double priceWithDelivery = bookPrice + bookPrice * 0.1;

            if (promo == Promo.BlackFriday) return priceWithDelivery * 0.0;

            return priceWithDelivery;
        }

    }

    enum Promo
    {
        WithoutPromo,
        Normal,
        BlackFriday
    }
}
