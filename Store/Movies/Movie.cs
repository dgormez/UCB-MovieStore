
namespace Store.Movies
{
    public abstract class Movie
    {
        public PriceCodes PriceCode { get; set; }
        public string Title { get; set; }

        public Movie (string title)
        {
            Title = title;
        }

        public abstract double GetPrice(int daysRented);
    }    
}