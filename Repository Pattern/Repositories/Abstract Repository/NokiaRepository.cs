using Abstraction.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern.Repositories.Abstract_Repository
{
    public abstract class NokiaRepository
    {
        public abstract  void DeleteNokia(Guid id );
        public abstract void CreateNokia (Guid Id, string brand, string Model, int  unitprice);
        public abstract void UpdateNokia(Guid Id, string brand, string Model, int unitprice);
        public abstract List<Nokia> GetNokia();
        public abstract Nokia  GetNokiaById(Guid id);

    }
}
