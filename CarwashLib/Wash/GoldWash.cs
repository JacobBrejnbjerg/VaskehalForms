using CarwashLib.Wash;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    class GoldWash : BaseWash, IWash
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int Progress { get; set; }
        public event Action<IWash> OnFihish;

        public GoldWash(Car car, string collectPassword) : base(collectPassword)
        {
            Car = car;  
        }

        public Car Collect(string password)
        {
            if (Hash.HashPasswordWithSalt(password, salt, amountOfRepitions) == CollectPassword)
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
