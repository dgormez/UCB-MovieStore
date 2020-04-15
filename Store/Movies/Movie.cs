
namespace Store.Movies
{
    public abstract class Movie
    {
        public Movie (string title)
        {
            Title = title;
        }

        public abstract double GetPrice(int daysRented);

        public PriceCodes PriceCode { get; set; }
        public string Title { get; set; }
    }    
}