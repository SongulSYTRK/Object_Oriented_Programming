using Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Concrete
{
   public  class Nokia : Tellephones<Guid>
    {
        public override Guid Id { get ; set; }

        public override string CallSound() => "Iphone kendne özel sese sahiptir";
        public Nokia (Guid Id, string brand, string Model, int unitprice)
        {
            this.Id = new Guid();
            this.Brand = brand;
            this.Model = Model;
            this.Unitprice = unitprice;

        }
        public Nokia()
        {

        }
    }
}
