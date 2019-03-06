using System;
using System.Collections.Generic;
using System.Text;

namespace CarwashLib
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CarPlate { get; set; }
        public bool IsCollected
        {
            get { return CarStatus.Collected == this.CarStatus; }
        }
        private CarStatus carStatus;
        public CarStatus CarStatus
        {
            get => carStatus;
            set
            {
                carStatus = value;
                OnCarStatusChanged?.Invoke(carStatus);
            }
        }
        public event Action<CarStatus> OnCarStatusChanged;
    }
}
