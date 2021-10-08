using Genres_Movie_RepositoryExample.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genres_Movie_RepositoryExample.Entities.Concrete
{
    public class Genres:BaseGenres  //Concrete sınıfının specific özelliklerini tanımlandı, atasınıftan kalıtım alındı
    {
        public string Name { get; set; }
        public string Description { get; set; }
       
    }
}
