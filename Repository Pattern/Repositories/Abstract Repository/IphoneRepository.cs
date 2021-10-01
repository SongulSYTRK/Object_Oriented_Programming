using Abstraction.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern.Repositories.Abstract_Repository
{
   public abstract  class IphoneRepository
    {
        public abstract void CreateIphone(Guid Id, string brand, string Model, int unitprice);
        public abstract void DeleteIphone(Guid id);
        public abstract  void UpdateIphone(Guid Id, string brand, string Model, int unitprice);
        public abstract List<Iphone> GetIphone();
        public abstract Iphone  GetIphoneById(Guid id);
        public abstract void Find(Guid Id, string brand, string Model, int unitprice);

    }
}
