using Abstraction.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern.Repositories.Abstract_Repository
{
    public abstract class SamsungRepository
    {
        public abstract void CreateSamsung(int id, string brand, string Model, int unitprice);
        public abstract void UpdateSamsung(int id, string brand , string Model, int unitprice );
        public abstract void DeleteSamsung(int id);

        public abstract List<Samsung> GetSamsungs();

        public abstract Samsung GetSamsungIdBy(int id);

    }
}
