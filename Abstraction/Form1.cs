using Abstraction.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void txtphonetype_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone()
            {
                Faceproperty = true,
                Brand = txtbrand.Text,
                Model = txtmodel.Text,
                Unitprice = Convert.ToInt32(txtunitprice.Text),

            };

            Nokia nokia = new Nokia()
                {

                  Brand = txtbrand.Text,
                  Model = txtmodel.Text,
                  Unitprice =Convert.ToInt32(txtunitprice.Text),
                

                };
               
                Samsung samsungg = new Samsung()
                 {

                    Brand = txtbrand.Text,
                    Model = txtmodel.Text,
                    Unitprice = Convert.ToInt32(txtunitprice.Text),

                 };

          Users user = new Users();
          user.UserName = txtname.Text;
          user.UserSurname = txtsurname.Text;

          user.GetTakeTelephone.Add(iphone);
          user.GetTakeTelephone.Add(samsungg);
          user.GetTakeTelephone.Add(nokia);

       MessageBox.Show($"information {user.GetTakeTelephone[0].ShowInformation()}\nusername : {user.UserName} \nusersurname : {user.UserSurname} \ngettakenphonemodel :  {user.GetTakeTelephone[0].Model} \nphonebrand:  {user.GetTakeTelephone[0].Brand } \nÇıkardığı ses : {user.GetTakeTelephone[0].CallSound()} \n Unitprice : {user.GetTakeTelephone[0].Unitprice} \n");

           
        }

        private void txtbrand_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
