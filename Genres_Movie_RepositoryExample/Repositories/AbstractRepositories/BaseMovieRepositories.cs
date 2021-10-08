using Genres_Movie_RepositoryExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genres_Movie_RepositoryExample.Repositories.AbstractRepositories
{
    public abstract class BaseMovieRepositories
    {
        public abstract void CreateMovie(Movie movie );
        public abstract void DeleteMovie(int Id);
        public abstract void UpdateMovie(Movie movie );
        public abstract List<Movie> GetMovie();
        public abstract List<Movie> GetIdBy(int Id );
    }
}
