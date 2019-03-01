using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    class GoldWash : WashBase, IWash<GoldWash>
    {
        public event Action<GoldWash> OnFihish;

        public Task<GoldWash> StartAsync()
        {
            return Task<BasicWash>.Run(() =>
            {
                while (Car.CarStatus != CarStatus.Finished)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Progress = i;

                        if (this.Progress < 15)
                        {
                            Car.CarStatus = CarStatus.Preparing;
                        }
                        else if (this.Progress < 30)
                        {
                            Car.CarStatus = CarStatus.Soaping;
                        }
                        else if (this.Progress < 45)
                        {
                            Car.CarStatus = CarStatus.Unterwagen;
                        }
                        else if (this.Progress < 60)
                        {
                            Car.CarStatus = CarStatus.Waxing;
                        }
                        else if (this.Progress < 75)
                        {
                            Car.CarStatus = CarStatus.Washing;
                        }
                        else if (this.Progress < 90)
                        {
                            Car.CarStatus = CarStatus.Drying;
                        }
                        else if (this.Progress == 100)
                        {
                            Car.CarStatus = CarStatus.Finished;
                            OnFihish?.Invoke(this);
                        }

                        Thread.Sleep(500);
                    }
                }

                return this;
            });
        }
    }
}
