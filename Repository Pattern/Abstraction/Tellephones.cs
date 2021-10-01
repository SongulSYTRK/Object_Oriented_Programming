using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Abstraction
{
    public abstract  class Tellephones<T>
    {

        public abstract T Id { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Unitprice { get; set; }
        public string CategoryName { get; set; }
        
        public abstract string CallSound();

        private DateTime _createdate = DateTime.Now;
        public DateTime Createdate { get => _createdate; set => _createdate = value; }
        public virtual string ShowInformation()
        {
            return $"Id : {this.Id} \nbrand {this.Brand} \nmodel {this.Model} \n";
        }
        
    }
}
