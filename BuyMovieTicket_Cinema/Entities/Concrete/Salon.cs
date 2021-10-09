using BuyMovieTicket_Cinema.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMovieTicket_Cinema.Entities.Concrete
{
    public class Salon:BaseCinemaTicket
    {
        public string SalonName { get; set; }
        public string TotalySeat { get; set; }
        public Movie Movie { get; set; }
    }
}
