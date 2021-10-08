using Genres_Movie_RepositoryExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genres_Movie_RepositoryExample
{
    public static class FakeDate // data ihtiyacımız var bu yüzden data oluşturduk
    {
        public static List<Genres> genre  = new List<Genres>()  // Oluşturduğumuz datanın liste halinde gözükmesini istiyoruz. 
        {
           new Genres{Id = 1, Name= "action" , Description="action movie is best " },
           new Genres{Id = 2, Name= "comedi" , Description="comedi movie is best " },
           new Genres{Id = 3, Name= "drama" , Description="drama  movie is best " },
        };

        public static List<Movie> movie = new List<Movie>()
        {
            new Movie {Id=1 , genre= genre[0] , Title="Insterstaller" , Content ="sxdcfvgbhnj" },
            new Movie {Id=2 ,genre= genre[1] , Title="recepivedik 1" , Content= "sdfghjk" },
            new Movie{Id=3 , genre= genre[2] , Title="john wick" , Content= "dfghj" },
        };
    }
}
