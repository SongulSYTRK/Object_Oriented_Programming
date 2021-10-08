using Genres_Movie_RepositoryExample.Entities.Concrete;
using Genres_Movie_RepositoryExample.Repositories.AbstractRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genres_Movie_RepositoryExample.Repositories.ConcreteRepositories
{
    public class ConcreteMovie : BaseMovieRepositories
    {
        public ConcreteMovie()
        {

        }
        public override void CreateMovie(Movie movie)
        {
            FakeDate.movie.Add(movie);
        }

        public override void DeleteMovie(int Id)
        {
            foreach (Movie movie in FakeDate.movie)
            {
               if(movie.Id==Id)
                {
                    FakeDate.movie.Remove(movie);
                }

            }
        }

        public override List<Movie> GetIdBy(int genreId) //
        {
            List<Movie> findmovie = new List<Movie>();
            foreach (Movie movie in FakeDate.movie)
            {
                if (movie.Id == genreId)
                {
                    findmovie.Add(movie);
                }

            }
            return findmovie;

        }

        public override List<Movie> GetMovie() => FakeDate.movie.ToList();
        

        public override void UpdateMovie(Movie movie)
        {   

            foreach (Movie item in FakeDate.movie)
            {
                if (movie.Id == item.Id)
                {
                    item.Title = movie.Title;
                    item.Id = movie.Id;
                    item.genre = movie.genre;
                    item.Content = movie.Content;
                    break;

                }

            }
        }
    }
}
