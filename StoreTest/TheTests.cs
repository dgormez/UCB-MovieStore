﻿using System;
using NUnit.Framework;
using Store;
using Store.Interfaces;
using Store.Movies;

namespace StoreTest
{
    [TestFixture]
    public class GeneralTest
    {
        [SetUp]
        public void Init()
        {
            // Create movies
            _mCinderella = MovieFactory.GetMovieByName("Cinderella");
            _mStarWars = MovieFactory.GetMovieByName("Star Wars");
            _mGladiator = MovieFactory.GetMovieByName("Gladiator");

            // Create rentals
            _mRental1 = new Rental(_mCinderella, 5);
            _mRental2 = new Rental(_mStarWars, 5);
            _mRental3 = new Rental(_mGladiator, 5);

            // Create customers
            _mMickeyMouse = new Customer("Mickey Mouse");
        }
        /* Fields */

        // Movies
        private IPriceable _mCinderella;
        private IPriceable _mStarWars;
        private IPriceable _mGladiator;

        // Rentals
        private Rental _mRental1;
        private Rental _mRental2;
        private Rental _mRental3;

        // Customers
        private Customer _mMickeyMouse;

        [Test]
        public void TestCustomer()
        {
            //Arrange  
            _mMickeyMouse.AddRental(_mRental1);
            _mMickeyMouse.AddRental(_mRental2);
            _mMickeyMouse.AddRental(_mRental3);

            //Act
            var theResult = _mMickeyMouse.Statement();

            //Assert
            var delimiters = "\n\t".ToCharArray();
            var results = theResult.Split(delimiters);

            Assert.AreEqual("Cinderella", results[2]);
            Assert.AreEqual(4.5, Convert.ToDouble(results[3]));
            Assert.AreEqual("Star Wars", results[5]);
            Assert.AreEqual(6.5, Convert.ToDouble(results[6]));
            Assert.AreEqual("Gladiator", results[8]);
            Assert.AreEqual(15, Convert.ToDouble(results[9]));
        }


        [Test]
        public void TestMovie()
        {
            //Assert
            Assert.AreEqual("Cinderella", _mCinderella.GetName());
            Assert.AreEqual("Star Wars", _mStarWars.GetName());
            Assert.AreEqual("Gladiator", _mGladiator.GetName());
            Assert.AreEqual(PriceCodes.Childrens, _mCinderella.GetPricingCode());
            Assert.AreEqual(PriceCodes.Regular, _mStarWars.GetPricingCode());
            Assert.AreEqual(PriceCodes.NewRelease, _mGladiator.GetPricingCode());
        }

        [Test]
        public void TestRental()
        {
            //Assert
            Assert.AreEqual(_mCinderella, _mRental1.Movie);
            Assert.AreEqual(_mStarWars, _mRental2.Movie);
            Assert.AreEqual(_mGladiator, _mRental3.Movie);
            Assert.AreEqual(5, _mRental1.DaysRented);
            Assert.AreEqual(5, _mRental1.DaysRented);
            Assert.AreEqual(5, _mRental1.DaysRented);
        }
    }
}