using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Programming.Encapsülation
{
    class Ticket
    {
        private int _TotalySeat; // I don't want to show totalyseat 
        public int Totalyseats
        {
            get => _TotalySeat;
            set
            {
                if (value >= 10)
                {
                    _TotalySeat = value;
                    MessageBox.Show("  Salon open   ");
                }
                else
                {
                    _TotalySeat = value;
                    MessageBox.Show("Salon closed  ");
                }

            }
        }
        public string salonNo { get; set; }

        private int _emptyseats ;

        public int EmptySeats
        {
            get => _emptyseats;

            set
            {
                if (value >= 1)
                {
                    _emptyseats = value;
                    MessageBox.Show("You can buy it ");
                }
                else
                {
                    MessageBox.Show("We dont have any seat  ");
                }
            }
        }
        public double Money { get; set; }
        public Ticket(double money, int totalyseat)
        {
            this.Totalyseats = totalyseat;
            this.Money = money;
            
            MessageBox.Show($"TotalySeat: {this.Totalyseats} \n Money : {this.Money} \nSalonNo: {this.salonNo = "A"} ");
        }
    }
}
