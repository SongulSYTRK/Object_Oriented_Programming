
using BuyMovieTicket_Cinema.Entities.Concrete;
using BuyMovieTicket_Cinema.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BuyMovieTicket_Cinema
{
    public partial class Form1 : Form
    {
        List<GetBuyTicket> buyTicket = new List<GetBuyTicket>();
        public Form1()
        {
            InitializeComponent();
        }
  
    private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in FakeData.movie)
            {
                cmbmovie.Items.Add(item);
            }
        }

        private void cmbmovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSalon.Visible = true; 
            cmbSalon.Text = string.Empty;
            cmbSalon.Items.Clear();

            foreach (var item in FakeData.ticketInformation)
            {
                if (item.Movie == cmbmovie.SelectedItem)
                {
                    cmbSalon.Items.Add(item);
                }
            }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {               
                MessageBox.Show("Please enter personal information");
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure you want to complete the reservation?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                MessageBox.Show("Cancelled");
                Utility.Eraser(grpCustomerInformation); 
                Utility.Eraser(grpmovieInformation);
                return;

            }
            TicketRepositories CreateTicket = new TicketRepositories();

            buyTicket.Add(CreateTicket.CreateInformation(txtfirstName.Text, txtLastName.Text, (TicketInformation)cmbSalon.SelectedItem)); 

                 Utility.Listele(listView1, buyTicket);
                 Utility.Eraser(grpCustomerInformation);
                 Utility.Eraser(grpmovieInformation);
        }
    }
}
