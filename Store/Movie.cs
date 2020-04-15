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