using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4.Preconditions
{
    // The parent class pre-condition is more strict than the child class pre-condition
    class Parent
    {
        public virtual double CalcuateEBookPrice(string title, int bookPrice, Promo promo = Promo.WithoutPromo)
        {
            // this is pre-condition
            if (title == "" || !char.IsUpper(title, 0)) throw new Exception();

            double priceWithDelivery = bookPrice + bookPrice * 0.1;
            return priceWithDelivery;
        }
    }

    class Child : Parent
    {
        public override double CalcuateEBookPrice(string title, int bookPrice, Promo promo = Promo.WithoutPromo)
        {
            if (title == "") throw new Exception();

            double priceWithDelivery = bookPrice + bookPrice * 0.1;
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
