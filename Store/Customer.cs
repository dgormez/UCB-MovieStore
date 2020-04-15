using Store.Movies;
using System;
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

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
        }

        public string Statement()
        {
            var result = "Rental Record for " + Name + "\n";
            foreach (var rental in _rentals)
            {
                result += rental.GetFormattedDescription();
            }

            //add footer lines
            result += "Amount owed is " + GetTotalPrice() + "\n";
            result += "You earned " + GetTotalFrequentRenterPoints() + " frequent renter points";

            return result;
        }

        private double GetTotalPrice()
        {
            double totalAmount = 0;

            foreach (var rental in _rentals)
            {
                totalAmount += rental.GetPrice();
            }
            return totalAmount;
        }

        private double GetTotalFrequentRenterPoints()
        {
            double frequentRenterPoints = 0;

            foreach (var rental in _rentals)
            {
                frequentRenterPoints += rental.GetFrequentRenterPoints();
            }

            return frequentRenterPoints;
        }
    }
}