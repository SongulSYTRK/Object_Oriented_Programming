using PayToBill_StaticMethod.Bill_Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayToBill_StaticMethod.Bilss_concrete
{
    public class GasBill : Bills
    {
        //public override double Methods()
        //{
        //    return BillMethods.Gas(1,2);
        //}
        public GasBill(string username , DateTime lastdate , DateTime ArrivalDate , double hour , double unitprice )
        {
            this.UserNamee = username;

            this.LastBillDate = lastdate;

            this.ArrivalDate = ArrivalDate;
        }
    }
}
