using Abstraction.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public static class FakePhoneData
    {

       
        public static List<Iphone> iphones = new List<Iphone>()
        {
            new Iphone { Id=Guid.NewGuid(),CategoryName = "11 ",Brand ="Iphone ",Model ="İphone 11S " , Unitprice = 20000},
            new Iphone {Id=Guid.NewGuid(), CategoryName = "8", Brand="Iphone " ,  Model ="İphone 8S", Unitprice =14000,},
           new Iphone {Id=Guid.NewGuid(), CategoryName = "7",Brand="Iphone ", Model ="İphone 7S " , Unitprice = 2000},
        };
        public static List<Samsung> samsungs = new List<Samsung >()
        {
            new Samsung {Id=Guid.NewGuid(), CategoryName = "Galaxy  ", Brand="Samsung " , Unitprice = 21000, Model ="Galaxy A72 "},
            new Samsung {Id=Guid.NewGuid(), CategoryName = "Galaxy  ", Brand="Samsung " , Unitprice = 13000, Model ="Galaxy A02 "},
           new Samsung {Id=Guid.NewGuid(), CategoryName = "Galaxy  ", Brand="Samsung " , Unitprice = 8000, Model ="Galaxy A12 "},
        };

        public static List<Nokia> nokias = new List<Nokia>()
        {
             new Nokia {Id=Guid.NewGuid(), CategoryName = "3310  ", Brand="Nokia  " , Unitprice = 210, Model ="Nokia 212"},
            new Nokia {Id=Guid.NewGuid(), CategoryName = "3310 ", Brand = "Nokia " , Unitprice = 170, Model ="Nokia 244 "},
           new Nokia {Id=Guid.NewGuid(), CategoryName = "3310  ", Brand="Nokia  " , Unitprice = 800, Model ="Nokia 515 "},
        };


    }
}
