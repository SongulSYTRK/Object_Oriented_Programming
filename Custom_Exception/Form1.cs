using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void CheckToText(string text) 
        {
            foreach (char character in text)
                if (char.IsDigit(character)) 
                {
                    throw new HasNumber(text); 
                }
        }
        public void WriteExceptionListview()
        {

            listView1.Items.Clear();
            StreamReader streamReader = new StreamReader(Application.StartupPath + @"\log.txt");
            String[] exceptions = streamReader.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string satir in exceptions)

            {
                string[] degerler = satir.Split('-');
                ListViewItem lvi = new ListViewItem();
                lvi.Text = degerler[0];
                lvi.SubItems.Add(degerler[1]);
                lvi.SubItems.Add(degerler[2]);

                listView1.Items.Add(lvi);
            }
        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); 

            streamReader.Close();
        }

        private void btnexception_Click(object sender, EventArgs e)
        {
            try
            {
                CheckToText(txtVerigirisi.Text);

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtVerigirisi, ex.Message);
                WriteExceptionListview();


            }
        }
    }
    
    }

