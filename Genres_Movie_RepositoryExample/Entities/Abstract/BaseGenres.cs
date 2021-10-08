using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genres_Movie_RepositoryExample.Entities.Abstract
{
    public abstract class BaseGenres // Atasınıfı tanımladık.Atasınıfımız abstract olmalıdır .
    {
        public int Id { get; set; }
        
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

    }
}
