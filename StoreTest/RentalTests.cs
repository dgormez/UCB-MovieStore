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
        [Test]
        public void RentalPrice()
        {
            Customer david = new Customer("David");
            Movie starWarsMovie = MovieFactory.GetMovieByName(MovieTitles.StarWars);
            Rental rental = new Rental(starWarsMovie,5);

            Assert.AreEqual(rental.Movie, starWarsMovie);
            Assert.AreEqual(rental.GetPrice(), 6.5);
            
        }
    }
}
