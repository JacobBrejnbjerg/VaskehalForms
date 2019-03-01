using System;
using System.Collections.Generic;
using System.Text;

namespace CarwashLib
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CarStatus CarStatus { get; set; }
        public bool IsCollected
        {
            get { return CarStatus.Collected == this.CarStatus; }
        }
    }
}
