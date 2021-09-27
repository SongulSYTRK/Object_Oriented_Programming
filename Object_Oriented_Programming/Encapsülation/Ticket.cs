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
            get => Totalyseats;
            set
            {
                if (value >= 10)
                {
                    _TotalySeat = value;
                    MessageBox.Show("Salon open   ");
                }
                else
                {
                    MessageBox.Show("Salon closed  ");
                }

            }
        }
        public string salonNo { get; set; }
        private int _emptySeat;

        public int EmptySeats
        {
            get => EmptySeats;

            set
            {
                if (value >= 1)
                {
                    _TotalySeat = value;
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
            MessageBox.Show($"toplam: {this.Totalyseats} \n Money : {this.Money} ");
        }
    }
}
