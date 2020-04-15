using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using Store;
using Store.Movies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTest
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void CustomerStatement()
        {
            Customer Mickey = new Customer("Mickey Mouse");

            Rental rental1 = new Rental(MovieFactory.GetMovieByName(MovieTitles.Cinderella), 5);
            Rental rental2 = new Rental(MovieFactory.GetMovieByName(MovieTitles.StarWars), 5);
            Rental rental3 = new Rental(MovieFactory.GetMovieByName(MovieTitles.Gladiator), 5);

            Mickey.AddRental(rental1);
            Mickey.AddRental(rental2);
            Mickey.AddRental(rental3);

            var statement = Mickey.Statement();

            Approvals.Verify(statement);
        }
    }
}
