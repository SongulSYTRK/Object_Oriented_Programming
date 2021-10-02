using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayToBill_StaticMethod
{
   public static class BillMethods
    {
        public static double ElectricBill (double UsedEnergy, double Unitprice ) => UsedEnergy* Unitprice;

        public static double WaterBill(double WaterRatio, double Unitprice ) => WaterRatio * Unitprice;

       
        public static double Gas(double GasRatio, double Unitprice) => GasRatio * Unitprice;

        
    }
}
