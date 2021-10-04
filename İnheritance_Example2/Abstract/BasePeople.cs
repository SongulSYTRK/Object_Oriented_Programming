using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnheritance_Example2.Abstract
{
    public abstract class BasePeople
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int TC { get; set; }
        public string Departmant { get; set; }
        public abstract string WhatIsDoing();

       

        public abstract int Age { get; set; }
        
        }
    }

