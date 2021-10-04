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
        public abstract void CreateIphone(int Id, string brand, string Model, int unitprice);
        public abstract void DeleteIphone(int  id);
        public abstract  void UpdateIphone(int  Id, string brand, string Model, int unitprice);
        public abstract List<Iphone> GetIphone();
        public abstract Iphone  GetIphoneById(int  id);
       

    }
}
