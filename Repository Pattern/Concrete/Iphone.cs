using Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Concrete
{
    public class Iphone : Tellephones <Guid>
    {
        public override string CallSound() => "Iphone kendne özel sese sahiptir";
        public bool Faceproperty { get; set; }
        public override Guid Id { get; set; }

        public override string ShowInformation()=> base.ShowInformation() + $"FaceProperty : {this.Faceproperty}";

        public Iphone(Guid Id, string brand, string Model, int  unitprice)
        {
            this.Id = new Guid();
            this.Brand = brand;
            this.Model = Model;
            this.Unitprice = unitprice;

        }
        public Iphone()
        {

        }
        
    }
}
