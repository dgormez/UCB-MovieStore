using Store.Movies;
using System;

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

        public double GetPrice()
        {
            return Movie.GetPrice(DaysRented);
        }

        public string GetMovieTitle()
        {
            return Movie.Title;
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
    }
}