using System.Collections.Generic;

namespace Store
{
    public class Customer
    {
        private readonly List<Rental> _rentals = new List<Rental>();
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }

        public string Statement()
        {
            double totalAmount = 0;
            var frequentRenterPoints = 0;
            var rentals = _rentals;
            var result = "Rental Record for " + Name + "\n";
            foreach (var rental in rentals)
            {
                double thisAmount = 0;
                //determine amounts for each line
                switch (rental.Movie.PriceCode)
                {
                    case PriceCodes.Regular:
                        thisAmount += 2;
                        if (rental.DaysRented > 2)
                            thisAmount += (rental.DaysRented - 2) * 1.5;
                        break;
                    case PriceCodes.NewRelease:
                        thisAmount += rental.DaysRented * 3;
                        break;
                    case PriceCodes.Childrens:
                        thisAmount += 1.5;
                        if (rental.DaysRented > 3)
                            thisAmount += (rental.DaysRented - 3) * 1.5;
                        break;
                }
                // add frequent renter points
                frequentRenterPoints++;
                // add bonus for a two day new release rental
                if (rental.Movie.PriceCode == PriceCodes.NewRelease
                    &&
                    rental.DaysRented > 1) frequentRenterPoints++;
                //show figures for this rental
                result += "\t" + rental.Movie.Title + "\t" +
                          thisAmount + "\n";
                totalAmount += thisAmount;
            }
            //add footer lines
            result += "Amount owed is " + totalAmount +
                      "\n";
            result += "You earned " + frequentRenterPoints
                      +
                      " frequent renter points";
            return result;
        }
    }
}