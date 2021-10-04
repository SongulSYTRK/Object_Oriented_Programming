using İnheritance_Example2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnheritance_Example2.Concrete
{
    public class Student : BasePeople
    {
        public Student(int Tc , string NAME )
        {
            this.TC = Tc;
            this.Name = NAME;
            
        }

        public override int Age
        {
            get => Age;
            set
            {
                if (Age >= 20)
                {

                    MessageBox.Show("He/She is student ");
                }
                else
                {
                    MessageBox.Show("He/She isn't student  ");
                }
            }
        }
        public override string WhatIsDoing() => "takes a lessons ";
       
    }
}
