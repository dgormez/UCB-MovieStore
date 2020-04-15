using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Movies
{
    public class ChildrensMovie : Movie
    {
        public ChildrensMovie(string title) : base(title)
        {
            PriceCode = PriceCodes.Childrens;
        }

        public override double GetPrice(int daysRented)
        {
            double price = 1.5;
            if (daysRented > 3)
                price += (daysRented - 3) * 1.5;
            return price;
        }
    }
}
