using Object_Oriented_Programming.İnheritance.Models.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.İnheritance.Models.Entities
{
    public class Nokia: Base
    {
        public bool Anten { get; set; }

        public override string CallSound()
        {
            return "Nokia telefon sesi ";
        }
        public override string ShowInformation() => base.ShowInformation() + $"Anten : {this.Anten}";
    }
}
