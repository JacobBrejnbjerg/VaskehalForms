using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    public class WashBase
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int Progress { get; set; }
        public string CollectPassword { get; set; }

        public virtual Car Collect(string password)
        {
            if (password == CollectPassword)
            {
                Car.CarStatus = CarStatus.Collected;
                return Car;
            }

            return null;
        }
    }
}
