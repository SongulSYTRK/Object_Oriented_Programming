using Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Concrete
{
   public  class Samsung : Tellephones<int>
    {
        public override int  Id { get ; set ; }

        public override string CallSound() => "Samsung  kendne özel sese sahiptir";
        public Samsung(int Id, string brand, string Model, int unitprice) //contructor 
        {
            this.Id = Id;
            this.Brand = brand;
            this.Model = Model;
            this.Unitprice = unitprice;

        }
        public Samsung()
        {

        }
    }
}
