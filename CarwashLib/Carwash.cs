using CarwashLib.Wash;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarwashLib
{
    public class Carwash
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IWash> Washes { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
