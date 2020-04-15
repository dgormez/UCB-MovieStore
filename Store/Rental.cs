using Store.Interfaces;
using Store.Movies;
using System;

namespace Store
{
    public class Rental
    {
        public IPriceable Movie { get; set; }
        public int DaysRented { get; set; }

        public Rental(IPriceable movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }

        public double GetPrice()
        {
            return Movie.GetPrice(DaysRented);
        }

        public string GetPriceableItemName()
        {
            return Movie.GetName();
        }

        internal int GetFrequentRenterPoints()
        {
            // add frequent renter points
            int frequentRenterPoints = 1;

            // add bonus for a two day new release rental
            if (Movie is NewReleaseMovie
                && DaysRented > 1)
                frequentRenterPoints++;

            return frequentRenterPoints;
        }

        public string GetFormattedDescription()
        {
            return "\t" + GetPriceableItemName() + "\t" + GetPrice() + "\n";
        }
    }
}