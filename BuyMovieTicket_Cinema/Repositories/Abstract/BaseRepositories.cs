using BuyMovieTicket_Cinema.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMovieTicket_Cinema.Repositories.Abstract
{
  public abstract  class BaseRepositories
    {
        public abstract GetBuyTicket  CreateInformation(string Firstname , string Lastname, TicketInformation ticketInformation);
    }
}
