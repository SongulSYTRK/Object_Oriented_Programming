using Object_Oriented_Programming.İnheritance.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia()
            {
                Anten = true,
                Brand = "nokia",
                Model = "3310"

            };
            MessageBox.Show($"information \n{nokia.ShowInformation()} \n {nokia.CallSound()}");


            samsung samsung = new samsung()
            {

                Brand = "Galaksi",
                Model = "S10"

            };
            MessageBox.Show($"information \n{samsung.ShowInformation()} \n {samsung.CallSound()}");

            Iphone iphone = new Iphone()
            {

                Brand = "x10",
                Model = "iphone "

            };

            MessageBox.Show($"information \n{iphone.ShowInformation()} \n {iphone.CallSound()}");
        }
    }
    }

