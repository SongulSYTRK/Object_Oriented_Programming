using BuyMovieTicket_Cinema.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMovieTicket_Cinema.Entities.Concrete
{
   public  class Customer:BaseCinemaTicket
    {
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string MailAdress { get; set; }
        public int  PhoneNumber { get; set; }
    }
}
