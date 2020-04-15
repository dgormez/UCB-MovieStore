namespace Store
{
    public enum PriceCodes
    {
        Regular,
        NewRelease,
        Childrens
    }

    public abstract class Movie
    {
        public Movie (string title)
        {
            Title = title;
        }

        public Movie(string title, PriceCodes priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public abstract double GetPrice(int daysRented);

        public PriceCodes PriceCode { get; set; }
        public string Title { get; set; }
    }    
}