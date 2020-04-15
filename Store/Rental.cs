namespace Store
{
    public class Rental
    {
        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }

        public Movie Movie { get; set; }
        public int DaysRented { get; set; }

        public double GetAmount()
        {
            double result = 0;

            //determine amounts for each line
            switch (Movie.PriceCode)
            {
                case PriceCodes.Regular:
                    result += 2;
                    if (DaysRented > 2)
                        result += (DaysRented - 2) * 1.5;
                    break;
                case PriceCodes.NewRelease:
                    result += DaysRented * 3;
                    break;
                case PriceCodes.Childrens:
                    result += 1.5;
                    if (DaysRented > 3)
                        result += (DaysRented - 3) * 1.5;
                    break;
            }

            return result;
        }
    }
}