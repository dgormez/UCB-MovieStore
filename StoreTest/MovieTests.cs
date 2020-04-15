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
    class MovieTests
    {
        [Test]
        public void Movie_UnknownMovieType_ExpectionAxpected()
        {
            Assert.Throws<Exception>(() => MovieFactory.GetMovieByName("This movie does not exist"));
        }

        [Test]
        public void Movie_TitleAndTypeAreCorrect()
        {
            var CinderellaChildrenMovie = MovieFactory.GetMovieByName(MovieTitles.Cinderella);
            var StarWarsRegularMovie = MovieFactory.GetMovieByName(MovieTitles.StarWars);
            var GladiatorNewReleaseMovie = MovieFactory.GetMovieByName(MovieTitles.Gladiator);

            Assert.AreEqual(CinderellaChildrenMovie.Title, MovieTitles.Cinderella);
            Assert.AreEqual(StarWarsRegularMovie.Title, MovieTitles.StarWars);
            Assert.AreEqual(GladiatorNewReleaseMovie.Title, MovieTitles.Gladiator);
            Assert.AreEqual(CinderellaChildrenMovie.PriceCode, PriceCodes.Childrens);
            Assert.AreEqual(StarWarsRegularMovie.PriceCode, PriceCodes.Regular);
            Assert.AreEqual(GladiatorNewReleaseMovie.PriceCode, PriceCodes.NewRelease);

        }


    }
}
