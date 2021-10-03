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

        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                if (value >= 20)
                {
                    _age = value;
                    MessageBox.Show("he/she can go university");
                }
                else
                {
                    MessageBox.Show("he/she can'T go university");
                }
            }
        }
    }
}
