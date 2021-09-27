using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Programming.Encapsülation
{
    public partial class encapsülation : Form
    {
        public encapsülation()
        {
            InitializeComponent();
        }

        private void btncinema_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(Convert.ToInt32(txtseat.Text), Convert.ToInt32(txtmoney.Text));
        }
    }
}
