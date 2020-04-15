namespace Store
{
    public enum PriceCodes
    {
        Regular,
        NewRelease,
        Childrens
    }

    public class Movie
    {
        public Movie(string title, PriceCodes priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public PriceCodes PriceCode { get; set; }
        public string Title { get; set; }
    }

    public abstract class MovieWrapper
    {

    }
}