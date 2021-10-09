using BuyMovieTicket_Cinema.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyMovieTicket_Cinema
{
   public static  class Utility
    {
     public static void Listele (ListView listView , List<GetBuyTicket> getBuyTickets)
        {
            foreach (GetBuyTicket Tickets in getBuyTickets)
            {
                ListViewItem lvi = new ListViewItem(Tickets.customer.FullName);
                lvi.SubItems.Add(Tickets.ticketInformation.Movie.MovieName.ToString());
                lvi.SubItems.Add(Tickets.ticketInformation.Salon.SalonName.ToString());
                lvi.SubItems.Add(Tickets.ticketInformation.Movie.Genre.ToString());
                lvi.SubItems.Add(Tickets.ticketInformation.Price.ToString());
                lvi.SubItems.Add(Tickets.ticketInformation.Hour.ToString());
                lvi.SubItems.Add(Tickets.ticketInformation.Movie.VisionDate.ToShortDateString());
                lvi.SubItems.Add(Tickets.PurchaseDate.ToShortDateString());

                listView.Items.Add(lvi);

            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

    
    public static void Eraser(GroupBox groupBox)
        {
             foreach (Control control in groupBox.Controls)
             {
                if (control is TextBox || control is ComboBox)
                {
                    control.Text = string.Empty;
                }
             }
        }
   }
            
 }
    

