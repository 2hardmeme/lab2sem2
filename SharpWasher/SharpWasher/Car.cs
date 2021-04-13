using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Car
    {
        public Car(string name)
        {
            this.name = name;
            this.clean = false;
        }
        public string name { get; set; }
        public bool clean { get; set; }
    }
}
