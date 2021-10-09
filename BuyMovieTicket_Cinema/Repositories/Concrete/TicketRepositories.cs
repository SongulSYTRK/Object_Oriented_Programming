using BuyMovieTicket_Cinema.Entities.Concrete;
using BuyMovieTicket_Cinema.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMovieTicket_Cinema.Repositories.Concrete
{
    public class TicketRepositories : BaseRepositories
    {
        public override GetBuyTicket CreateInformation(string Firstname, string Lastname, TicketInformation ticketInformation)
        {
           GetBuyTicket BuyTicket = new GetBuyTicket();
           Customer Customer  = new Customer();
           Customer.FullName = Firstname + "" + Lastname;
           BuyTicket.customer = Customer; 
           BuyTicket.PurchaseDate = DateTime.Now;
            BuyTicket.ticketInformation = ticketInformation;


            return BuyTicket;
        }
    }
}
