using BuyMovieTicket_Cinema.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMovieTicket_Cinema.Entities.Concrete
{
    public class TicketInformation:BaseCinemaTicket
    {
        public Movie Movie { get; set; }
        public Salon Salon { get; set; }
        public Double Price { get; set; }
        public Double Hour { get; set; }


        public override string ToString()
        {
            return $"{Movie}-{Hour}-{Movie.VisionDate.ToShortDateString()}";
        }
    }
}
