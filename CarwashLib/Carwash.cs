
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarwashLib
{
    public class Carwash
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Wash> Washes { get; set; }

        public Carwash()
        {
            Washes = new List<Wash>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
