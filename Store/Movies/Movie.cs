
using Store.Interfaces;

namespace Store.Movies
{
    public abstract class Movie : IPriceable
    {
        protected PriceCodes PriceCode;
        protected string Title;

        public Movie (string title)
        {
            Title = title;
        }

        public abstract double GetPrice(int daysRented);

        public string GetName()
        {
            return Title;
        }

        public PriceCodes GetPricingCode()
        {
            return PriceCode;
        }
    }    
}