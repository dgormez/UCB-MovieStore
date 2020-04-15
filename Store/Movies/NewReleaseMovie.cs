using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Movies
{
    public class NewReleaseMovie : Movie
    {
        public NewReleaseMovie(string title) : base(title)
        {
            PriceCode = PriceCodes.NewRelease;
        }

        public override double GetPrice(int daysRented)
        {
            return daysRented * 3;
        }
    }
}
