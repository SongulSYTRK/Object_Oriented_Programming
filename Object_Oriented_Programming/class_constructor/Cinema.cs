using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // I added messagbox class 

namespace Constructor_Example
{
    public class Cinema // Created Class 
    {

        public int TotalySeat { get; set; }
        public string salonNo { get; set; }
        public int emptySeat { get; set; }
        public double Money { get; set; }



        public Cinema(int Seat, string salonNo)  //constructor 1
        {
            this.TotalySeat = Seat;
            this.salonNo = salonNo;


        }

        public Cinema()   //constructor 2
        {
            MessageBox.Show("I  didnt add any properties ");
        }


        public Cinema(int seat, string salonNo, double moneys)  //constructor 3
        {
            this.TotalySeat = seat;
            this.salonNo = salonNo;
            this.Money = moneys;
            MessageBox.Show($"seats: {this.TotalySeat} \nsalon this.salonNo");



        }
        public Cinema(int seat, string salonNo, int empty, double moneys)  //constructor 4
        {
            this.TotalySeat = seat;
            this.salonNo = salonNo;
            this.Money = moneys;
            this.emptySeat = empty;




        }

    }
}

