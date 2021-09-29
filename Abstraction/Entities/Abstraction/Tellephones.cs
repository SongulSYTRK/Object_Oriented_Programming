using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Abstraction
{
    public abstract  class Tellephones
    {
       
        public Guid Id { get => Guid.NewGuid(); }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Unitprice { get; set; }
        public string CategoryName { get; set; }
        public abstract string CallSound();
        public virtual string ShowInformation()
        {
            return $"Id : {this.Id} \nbrand {this.Brand} \nmodel {this.Model} \n";
        }
        
    }
}
