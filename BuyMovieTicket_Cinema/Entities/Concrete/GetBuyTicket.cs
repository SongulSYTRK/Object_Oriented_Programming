using BuyMovieTicket_Cinema.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMovieTicket_Cinema.Entities.Concrete
{
   public  class GetBuyTicket:BaseCinemaTicket
    {
        public Customer customer { get; set; }
        public DateTime PurchaseDate { get; set; }
        public TicketInformation ticketInformation { get; set; }
    }
}
