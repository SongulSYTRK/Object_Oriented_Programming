using Genres_Movie_RepositoryExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genres_Movie_RepositoryExample.Repositories.AbstractRepositories
{
    public abstract class BaseGenresRepositories   // Crud işlemleri yapacağımız için abstract bir repository oluşturduk 
    {
        public abstract Genres CreateGenres(Genres genre); // Genre tipinde genre eklemesi yapacak 
        public abstract void UpdateGenres(Genres genre  );  // Id'sinden yakalayarak tuttuğumuz değere genre tipinde genre değerlerle update işlemi gerçekleşecek 
        public abstract void DeleteGenres(int Id);  // Id'sinden yakaladığımız değeri Delete işlemi gerçekleştirecek (Id biricik olduğu için ID kullanırız )
        public abstract List<Genres> GetGenres(); // Genres Data'sını bize verecek 
        public abstract Genres GetByName(string name );  // Normalde biricik olan propertyler kullanılır ama bu datamızda name'niz biricik olduğu için name kullanarak datayı getiriyoruz


    }
}
