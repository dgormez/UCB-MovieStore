using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Movies
{
    public class RegularMovie : Movie
    {
        public RegularMovie(string title) : base(title)
        {
            PriceCode = PriceCodes.Regular;
        }

        public override double GetPrice(int daysRented)
        {
            double price = 2;
            if (daysRented > 2)
                price += (daysRented - 2) * 1.5;
            return price;
        }
    }
}
