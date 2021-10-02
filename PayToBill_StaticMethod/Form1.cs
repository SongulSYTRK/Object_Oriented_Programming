using PayToBill_StaticMethod.Bilss_concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayToBill_StaticMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtfatura.Text== ("Gas").ToLower())
            { 
            GasBill gas = new GasBill(txtuser.Text, Convert.ToDateTime(txtsonödeme.Text), Convert.ToDateTime(DateTime.Now), double.Parse(txthours.Text), double.Parse(txtprice.Text));
          
            MessageBox.Show($"USER= {txtuser.Text } \nLASTDATE= {Convert.ToDateTime(txtsonödeme.Text)} \n ARRİVALDATE= {DateTime.Now}  \nBİLL AMOUNT= {BillMethods.Gas(Double.Parse(txthours.Text),Double.Parse(txtprice.Text))}");

           // listBox1.Items.Add($"User: {txtuser.Text } ;
            }

            else if (txtfatura.Text == ("Electric").ToLower())
            {
                ElectricBill electric = new ElectricBill(txtuser.Text, Convert.ToDateTime(txtsonödeme.Text), Convert.ToDateTime(DateTime.Now), double.Parse(txthours.Text), double.Parse(txtprice.Text));

                MessageBox.Show($"Username=  {txtuser.Text } \nLASTDATE= {Convert.ToDateTime(txtsonödeme.Text)} \nBillarrivadate= : {DateTime.Now}  \nBill Amount= {BillMethods.ElectricBill(Double.Parse(txthours.Text), Double.Parse(txtprice.Text))}");

            }
            else if (txtfatura.Text == ("Water").ToLower())
            {
                WaterBill electric = new WaterBill(txtuser.Text, Convert.ToDateTime(txtsonödeme.Text), Convert.ToDateTime(DateTime.Now), double.Parse(txthours.Text), double.Parse(txtprice.Text));


                MessageBox.Show($"Username=  {txtuser.Text } \nLastdate= {Convert.ToDateTime(txtsonödeme.Text)} \nBillarrivadate= {DateTime.Now}  \nBill Amount= {BillMethods.WaterBill(Double.Parse(txthours.Text), Double.Parse(txtprice.Text))}");
            }
            else
            {
                MessageBox.Show("Try Again . You must  write the correct bill ");
            }
        }
    }
}
