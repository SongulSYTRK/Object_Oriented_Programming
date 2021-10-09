using BuyMovieTicket_Cinema.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMovieTicket_Cinema
{
    public static class FakeData
    {
        public static List<Movie> movie = new List<Movie>()
        {
            new Movie {Id=1, MovieName= "movie1 ", Genre="comedi" , VisionDate = new DateTime(2021, 10, 7), Description= "Best Comedi Movie "},
            new Movie {Id=2, MovieName= "movie2 ", Genre="action",VisionDate = new DateTime(2021, 5, 9), Description= "Best Action Movie "},
            new Movie {Id=3, MovieName= "movie3 ", Genre="emotional",VisionDate = new DateTime(2021, 8, 7), Description= "Best Emotional Movie "},

        };

        public static List<Salon> salon = new List<Salon>()
        {
          new Salon {Id=1, SalonName ="SalonA ", TotalySeat ="73" ,Movie=movie[0] },
          new Salon {Id=2, SalonName ="SalonB ", TotalySeat="77" , Movie=movie[1]},
          new Salon {Id=3, SalonName ="SalonC ", TotalySeat="50" , Movie=movie[2]},
          new Salon {Id=4, SalonName ="SalonB ", TotalySeat="77" , Movie=movie[0]},
        };

        public static List<TicketInformation> ticketInformation = new List<TicketInformation>()
        {
            new TicketInformation
            {
                Id=1,
                Movie=movie[0],
                Salon = salon[0],
                Price=10.50,
                Hour=8.30,
         
            },

             new TicketInformation
            {
                Id=2,
                Movie=movie[0],
                Salon = salon[3],
                Price=10.75,
                Hour=15.30,
                 
            },
             new TicketInformation
            {
                Id=1,
                Movie=movie[1],
                Salon = salon[2],
                Price=10,
                Hour=16.15,
            },
             new TicketInformation
            {
                Id=1,
                Movie=movie[2],
                Salon = salon[2],
                Price=14.95,
                Hour=21.45,
            },

        };

    }
}
