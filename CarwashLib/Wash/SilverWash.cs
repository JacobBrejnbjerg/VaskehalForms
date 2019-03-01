using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    class SilverWash : WashBase, IWash<SilverWash>
    {
        public event Action<int> OnFihish;

        public Task<SilverWash> StartAsync()
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
                        else if (this.Progress < 40)
                        {
                            Car.CarStatus = CarStatus.Soaping;
                        }
                        else if (this.Progress < 65)
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
                            OnFihish?.Invoke(Id);
                        }

                        Thread.Sleep(500);
                    }
                }

                return this;
            });
        }
    }
}
