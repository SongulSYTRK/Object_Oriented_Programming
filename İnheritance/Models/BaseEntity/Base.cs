using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.İnheritance.Models.BaseEntity
{
    public class Base
    {
        public Guid Id { get => Guid.NewGuid(); }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Unitprice { get; set; }
        public string CategoryName { get; set; }
        public virtual string CallSound() => "Genel telefon sesi ";
        public virtual string ShowInformation()
        {
            return $"Id : {this.Id} \nbrand {this.Brand} \nmodel {this.Model} \n";
        }
    }
}
