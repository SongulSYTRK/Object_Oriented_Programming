using Constructor_Example;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cinema cinema = new Cinema(Convert.ToInt32(txtseat.Text), (txtsalon.Text));
            MessageBox.Show($"seats: {cinema.TotalySeat} \nsalon {cinema.salonNo}");
        }


       

        private void btncinameseat_1_Click(object sender, EventArgs e)
        {
            Cinema cinema = new Cinema();
        }

        private void btncinema_3_Click(object sender, EventArgs e)
        {
            Cinema cinema = new Cinema(Convert.ToInt32(txtseat.Text), (txtsalon.Text), Convert.ToInt32(txtticket.Text));

            // We wrote messagebox in background 
        }
    }
}
