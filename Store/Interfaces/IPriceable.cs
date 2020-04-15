using Store.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Interfaces
{
    public interface IPriceable
    {
        double GetPrice(int daysRented);
        string GetName();
        PriceCodes GetPricingCode();
    }
}
