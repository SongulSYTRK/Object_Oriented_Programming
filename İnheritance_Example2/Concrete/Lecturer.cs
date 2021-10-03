using İnheritance_Example2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnheritance_Example2.Concrete
{
    public class Lecturer : BasePeople
    {
        public Lecturer(int TC, string name, string lastname , string departmant , int age  )
        {
            this.TC = TC;
            this.Name = name;
            this.Lastname = lastname;
            this.Departmant = departmant;
            this.Age = age;
            MessageBox.Show($"TC:  {TC} \nNAME:  {name} \nLastname: {lastname} \nDepartman: {departmant} \nage: {age} \nWhat doing:  {this.WhatIsDoing()} \nResult:  {ExamsResult.Accepted(80,70,80)} ");
        }

        public override string WhatIsDoing() => "Gives a lesson";


    }
}