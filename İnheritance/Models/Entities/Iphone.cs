using Object_Oriented_Programming.İnheritance.Models.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.İnheritance.Models.Entities
{
   public  class Iphone:Base
    {
        public override string CallSound() => "Iphone kendne özel sese sahiptir";
    }
}
