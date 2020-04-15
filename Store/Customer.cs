﻿using System;
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
            var rentals = _rentals;
            var frequentRenterPoints = 0;
            var result = "Rental Record for " + Name + "\n";
            foreach (var rental in rentals)
            {
                frequentRenterPoints += rental.GetFrequentRenterPoints();

                //show figures for this rental
                result += "\t" + rental.Movie.Title + "\t" + rental.GetPrice() + "\n";

                totalAmount += rental.GetPrice();

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

    public class Program
    {

        public static void Main(string[] args)
        {
            Movie _mCinderella;

            Movie _mStarWars;
            Movie _mGladiator;

            // Rentals
            Rental _mRental1;
            Rental _mRental2;
            Rental _mRental3;

            // Customers
            Customer _mMickeyMouse;
            Customer _mDonaldDuck;
            Customer _mMinnieMouse;

            // Create movies
            _mCinderella = new Movie("Cinderella", PriceCodes.Childrens);
            _mStarWars = new Movie("Star Wars", PriceCodes.Regular);
            _mGladiator = new Movie("Gladiator", PriceCodes.NewRelease);

            // Create rentals
            _mRental1 = new Rental(_mCinderella, 5);
            _mRental2 = new Rental(_mStarWars, 5);
            _mRental3 = new Rental(_mGladiator, 5);

            // Create customers
            _mMickeyMouse = new Customer("Mickey Mouse");
            _mDonaldDuck = new Customer("Donald Duck");
            _mMinnieMouse = new Customer("Minnie Mouse");

            //Arrange  
            _mMickeyMouse.AddRental(_mRental1);
            _mMickeyMouse.AddRental(_mRental2);
            _mMickeyMouse.AddRental(_mRental3);

            //Act
            var theResult = _mMickeyMouse.Statement();

            //Assert
            var delimiters = "\n\t".ToCharArray();
            var results = theResult.Split(delimiters);
            Console.WriteLine(theResult);
            Console.ReadLine();
        }
    }
}