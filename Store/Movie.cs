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

        public PriceCodes PriceCode { get; set; }
        public string Title { get; set; }
    }

    public class RegularMovie : Movie
    {
        public RegularMovie(string title) : base(title)
        {
            PriceCode = PriceCodes.Regular;
        }
    }

    public class ChildrensMovie : Movie
    {
        public ChildrensMovie(string title) : base(title)
        {
            PriceCode = PriceCodes.Childrens;
        }
    }

    public class NewReleaseMovie : Movie
    {
        public NewReleaseMovie(string title) : base(title)
        {
            PriceCode = PriceCodes.NewRelease;
        }
    }
}