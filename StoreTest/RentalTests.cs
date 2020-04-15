using NUnit.Framework;
using Store;
using Store.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTest
{
    [TestFixture]
    class RentalTests
    {
        Customer david = new Customer("David");

        [Test]
        public void RentalPrice_RegularMovie_BeforeMaxRentalDays()
        {
            Rental RegularRental = new Rental(MovieFactory.GetMovieByName(MovieTitles.StarWars),2);

            Assert.AreEqual(RegularRental.GetPrice(), 2);            
        }

        [Test]
        public void RentalPrice_RegularMovie_AfterMaxRentalDays()
        {
            Rental RegularRental = new Rental(MovieFactory.GetMovieByName(MovieTitles.StarWars), 10);

            Assert.AreEqual(RegularRental.GetPrice(), 14);
        }

        [Test]
        public void RentalPrice_NewReleaseMovie()
        {
            Rental NewReleaseRental = new Rental(MovieFactory.GetMovieByName(MovieTitles.Gladiator), 4);

            Assert.AreEqual(NewReleaseRental.GetPrice(), 12);
        }

        [Test]
        public void RentalPrice_ChildrenMovie_BeforeMaxRentalDays()
        {
            Rental ChildrenRental = new Rental(MovieFactory.GetMovieByName(MovieTitles.Cinderella), 2);

            Assert.AreEqual(ChildrenRental.GetPrice(), 1.5);
        }

        [Test]
        public void RentalPrice_ChildrenMovie_AfterMaxRentalDays()
        {
            Rental ChildrenRental = new Rental(MovieFactory.GetMovieByName(MovieTitles.Cinderella), 10);

            Assert.AreEqual(ChildrenRental.GetPrice(), 12);
        }
    }
}
