using Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Concrete
{
    public class Iphone : Tellephones <int>
    {
        public override string CallSound() => "Iphone kendne özel sese sahiptir";
        public bool Faceproperty { get; set; }
      
        
        public override int Id { get ; set ; }

        public override string ShowInformation()=> base.ShowInformation() + $"FaceProperty : {this.Faceproperty}";

        public Iphone(int  Id, string brand, string Model, int  unitprice)
        {
            this.Id = Id;
            this.Brand = brand;
            this.Model = Model;
            this.Unitprice = unitprice;

        }
        public Iphone()
        {

        }
        
        
    }
}
