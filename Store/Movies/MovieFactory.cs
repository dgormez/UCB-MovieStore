using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Movies
{

    public static class MovieFactory
    {
        public static Movie GetMovieByName(string name)
        {
            switch (name)
            {
                case MovieTitles.Cinderella:
                    return new ChildrensMovie(MovieTitles.Cinderella);
                case MovieTitles.StarWars:
                    return new RegularMovie(MovieTitles.StarWars);
                case MovieTitles.Gladiator:
                    return new NewReleaseMovie(MovieTitles.Gladiator);
                default:
                    throw new Exception("Unknown movie title");
            }
        }

    }
}
