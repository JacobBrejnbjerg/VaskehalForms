using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    public class SilverWash : Wash
    {
        public SilverWash(Car car, string collectPassword) : base(collectPassword)
        {
            Car = car;
        }

        public override void StartAsync()
        {
            new Thread(() =>
            {
                CancellationToken cancelToken = cts.Token;

                if (Car != null)
                {
                    if (Car.CarStatus != CarStatus.Finished)
                    {
                        for (; this.Progress < 100; this.Progress++)
                        {
                            if (cancelToken.IsCancellationRequested)
                                break;

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
                            else if (this.Progress == 99)
                            {
                                Car.CarStatus = CarStatus.Finished;
                                InvokeOnFinish(this);
                            }

                            Thread.Sleep(250);
                        }
                    }
                }
            }).Start();
        }
    }
}
