using CarwashLib.Wash;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    class BasicWash : IWash
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int Progress { get; set; }
        public string CollectPassword { get; set; }
        CancellationTokenSource cts;

        public event Action<IWash> OnFihish;

        public Car Collect(string password)
        {
            if (password == CollectPassword)
            {
                Car.CarStatus = CarStatus.Collected;
                return Car;
            }

            return null;
        }

        public Task StartAsync()
        {
            return Task.Run(() =>
            {
                CancellationToken cancelToken = cts.Token;

                if (Car.CarStatus != CarStatus.Finished)
                {
                    for (; Progress < 100; Progress++)
                    {
                        if (cancelToken.IsCancellationRequested)
                            break;

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
                            OnFihish?.Invoke(this);
                        }

                        Thread.Sleep(500);
                    }
                }

                return this;
            });
        }

        public void Cancel()
        {
            cts.Cancel();
        }
    }
}
