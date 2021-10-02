using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayToBill_StaticMethod.Bill_Abstract
{
    public abstract class Bills
    {
        public  string UserNamee { get; set; }
        public  DateTime LastBillDate { get; set; }
        private DateTime _ArrivalDate = DateTime.Now;
        public DateTime ArrivalDate { get => _ArrivalDate; set => _ArrivalDate = value; }

        public abstract double Methods();

    }
}
