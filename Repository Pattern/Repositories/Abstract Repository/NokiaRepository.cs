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
        public abstract  void DeleteNokia(int id );
        public abstract void CreateNokia (int id, string brand, string Model, int  unitprice);
        public abstract void UpdateNokia(int id, string brand, string Model, int unitprice);
        public abstract List<Nokia> GetNokia();
        public abstract Nokia GetNokiaById(int id );

    }
}
