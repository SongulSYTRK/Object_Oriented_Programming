using BuyMovieTicket_Cinema.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMovieTicket_Cinema.Entities.Concrete
{
    public class Movie:BaseCinemaTicket
    {
        public string  MovieName { get; set; }
        public DateTime VisionDate { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return MovieName;
        }
    }
}
