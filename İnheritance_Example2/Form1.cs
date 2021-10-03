using İnheritance_Example2.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnheritance_Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer(11232, "songül", "soytürk", "Software", 26);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student students = new Student(22555, "Ali");

            MessageBox.Show($"T.C. {students.TC} \nFirstName {students.Name} \nLastNanem {students.Lastname= "Yaman" } \nDepartment: {students.Departmant = "Mühendislik"  }  \nAge : {students.Age = 17} \nWhatDoing {students.WhatIsDoing() }");

        }
    }
}
