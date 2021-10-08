using Genres_Movie_RepositoryExample.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genres_Movie_RepositoryExample.Entities.Concrete
{
    public class Movie : BaseGenres //atasınıftan kalıtım alındı, specific özellikleri tanımlandı 
    {
        public string Title { get; set; } 
        public string Content { get; set; }
        public Genres genre  { get; set; }   // specific özellikleri içinde genre özelliğide mevcut 
}
}
