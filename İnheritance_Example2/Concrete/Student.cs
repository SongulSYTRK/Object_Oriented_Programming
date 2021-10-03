using İnheritance_Example2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance_Example2.Concrete
{
    public class Student : BasePeople
    {
        public Student(int Tc , string NAME )
        {
            this.TC = Tc;
            this.Name = NAME;
            
        }
        public override string WhatIsDoing() => "takes a lessons ";
       
    }
}
