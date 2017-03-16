using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Procreator
    {
        public Procreator() { }
        public Procreator(string n, string c, int f)
        {
            Name = n; Country = c; Foundation = f;
        }
        private string name;
        private string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private int foundation;
        public int Foundation
        {
            get { return foundation; }
            set { foundation = value; }
        }
    }
}
