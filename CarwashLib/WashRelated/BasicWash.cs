using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    public class BasicWash : Wash
    {
        public BasicWash(Car car, string collectPassword) : base(collectPassword)
        {
            Car = car;
        }
    }
}
