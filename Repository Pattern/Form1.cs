using Repository_Pattern.Repositories.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repository_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IphoneRepositoryConcrete iphonerepo = new IphoneRepositoryConcrete();
        NokiaRepositoryConcrete nokiarepo = new NokiaRepositoryConcrete();
        SamsungRepositoryConrete samsungrepo = new SamsungRepositoryConrete();


        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = iphonerepo.GetIphone();
            dataGridView2.DataSource = samsungrepo.GetSamsungs();
            dataGridView3.DataSource = nokiarepo.GetNokia();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            iphonerepo.CreateIphone(int.Parse (txtıd.Text) , txtbrand.Text, txtmodel.Text, int.Parse(txtunitPrice.Text));
           
                dataGridView1.DataSource = iphonerepo.GetIphone();
            

           
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            iphonerepo.UpdateIphone(int.Parse(txtıd.Text), txtbrand.Text, txtmodel.Text, int.Parse(txtunitPrice.Text));

            dataGridView1.DataSource = iphonerepo.GetIphone();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            iphonerepo.DeleteIphone(int.Parse(txtıd.Text));

            dataGridView1.DataSource = iphonerepo.GetIphone();

        }

        private void btncreate_2_Click(object sender, EventArgs e)
        {
            samsungrepo.CreateSamsung(int.Parse(txtıd.Text), txtbrand.Text, txtmodel.Text, int.Parse(txtunitPrice.Text));
           
                dataGridView2.DataSource = samsungrepo.GetSamsungs();
            
        }

        private void btnupdate_2_Click(object sender, EventArgs e)
        {
            samsungrepo.UpdateSamsung(int.Parse(txtıd.Text), txtbrand.Text, txtmodel.Text, int.Parse(txtunitPrice.Text));

            dataGridView2.DataSource = samsungrepo.GetSamsungs();
        }

        private void btndelete_2_Click(object sender, EventArgs e)
        {
            samsungrepo.DeleteSamsung(int.Parse(txtıd.Text));

            dataGridView2.DataSource = samsungrepo.GetSamsungs();
        }

        private void btncreate3_Click(object sender, EventArgs e)
        {
            nokiarepo.CreateNokia(int.Parse(txtıd.Text), txtbrand.Text, txtmodel.Text, int.Parse(txtunitPrice.Text));
           
                dataGridView3.DataSource = nokiarepo.GetNokia();
          
        }

        private void btnUpdate_3_Click(object sender, EventArgs e)
        {
            nokiarepo.UpdateNokia(int.Parse(txtıd.Text), txtbrand.Text, txtmodel.Text, int.Parse(txtunitPrice.Text));

            dataGridView3.DataSource = nokiarepo.GetNokia();
        }

        private void BtnDelete_3_Click(object sender, EventArgs e)
        {
            nokiarepo.DeleteNokia(int.Parse(txtıd.Text));

            dataGridView3.DataSource = nokiarepo.GetNokia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtıd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
