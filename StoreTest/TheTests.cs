using System;
using NUnit.Framework;
using Store;

namespace StoreTest
{
    [TestFixture]
    public class GeneralTest
    {
        [SetUp]
        public void Init()
        {
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
        }
        /* Fields */

        // Movies
        private Movie _mCinderella;

        private Movie _mStarWars;
        private Movie _mGladiator;

        // Rentals
        private Rental _mRental1;
        private Rental _mRental2;
        private Rental _mRental3;

        // Customers
        private Customer _mMickeyMouse;
        private Customer _mDonaldDuck;
        private Customer _mMinnieMouse;

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
            Assert.AreEqual("Cinderella", _mCinderella.Title);
            Assert.AreEqual("Star Wars", _mStarWars.Title);
            Assert.AreEqual("Gladiator", _mGladiator.Title);
            Assert.AreEqual(PriceCodes.Childrens, _mCinderella.PriceCode);
            Assert.AreEqual(PriceCodes.Regular, _mStarWars.PriceCode);
            Assert.AreEqual(PriceCodes.NewRelease, _mGladiator.PriceCode);
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