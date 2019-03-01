using System;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    class BasicWash : WashBase, IWash<BasicWash>
    {
        public event Action<int> OnFihish;

        public Task<BasicWash> StartAsync()
        {
            return Task<BasicWash>.Run(() =>
                {
                    while (Car.CarStatus != CarStatus.Finished)
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            Progress = i;

                            if (this.Progress < 25)
                            {
                                Car.CarStatus = CarStatus.Preparing;
                            }
                            else if (this.Progress < 50)
                            {
                                Car.CarStatus = CarStatus.Washing;
                            }
                            else if (this.Progress < 75)
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
